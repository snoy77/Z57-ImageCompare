using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Z_57_DLL
{
    public enum CompareResult 
    {
        TheSame = 0,
        Simular = 1,
        Various = 2
    }

    public class PictureComparator
    {
        public double hammingDistanceLimitPercent;
        public int imgMiniSize;

        public PictureComparator() : this(0.05, 35) { }
        public PictureComparator(double hammingDistanceLimitPercent, int imgMiniSize)
        {
            this.hammingDistanceLimitPercent = hammingDistanceLimitPercent;
            this.imgMiniSize = imgMiniSize;
        }
   

        //public string[] FindDuplicateImages(Bitmap sourceImage, string[] otherImageList) 
        //{ 
        //    return FindDuplicateImages(sourceImage, otherImageList, false); 
        //}
        //public string[] FindDuplicateImages(Bitmap sourceImage, string[] otherImagesName, bool considerSimilarImages)
        //{
        //    //Это функция для поиска дубликатов изображению SourceImage в списке OtherImageList
        //    List<string> result = new List<string>();

        //    for(int i = 0; i < otherImagesName.Length; i++)
        //    {
        //        int resultofCompare = this.CompareImages(sourceImage, new Bitmap(otherImagesName[i]));
        //        if(resultofCompare == 0)
        //        {
        //            result.Add(otherImagesName[i]);
        //        }
        //        else if(resultofCompare == 2 & considerSimilarImages)
        //        {
        //            result.Add(otherImagesName[i]);
        //        }
        //    }
        //    return result.ToArray();
        //}

        public CompareResult CompareImages(Bitmap imageOne, Bitmap imageTwo)
        {
            return CompareImages(imageOne, imageTwo, this.imgMiniSize, this.hammingDistanceLimitPercent);
        }
        public CompareResult CompareImages(Bitmap imageOne, Bitmap imageTwo, int imgMiniSize)
        {
            return CompareImages(imageOne, imageTwo, imgMiniSize, this.hammingDistanceLimitPercent);
        }
        public CompareResult CompareImages(Bitmap imageOne, Bitmap imageTwo, int imgMiniSize, double hammingDistanceLimitPercent)
        {
            List<float> imageOnePixels = new List<float>();//значения цветов пикселей первой картинки
            List<float> imageTwoPixels = new List<float>();
            string imageOneTrack = "";//биты структуры изображений
            string imageTwoTrack = "";

            //Изменяем размеры картинок
            ChangeSize(ref imageOne, imgMiniSize);
            ChangeSize(ref imageTwo, imgMiniSize);

            //Получаем список пикселей, у каждого из которых среднее значение RGB
            imageOnePixels.AddRange(GetBlackModePixelsList(imageOne));
            imageTwoPixels.AddRange(GetBlackModePixelsList(imageTwo));

            //Получаем список битов -структуру(след)
            imageOneTrack = GetTrack(imageOnePixels);
            imageTwoTrack = GetTrack(imageTwoPixels);

            //Получаем Хеш изображения
            string imageOneHEX = BinaryStringToHexString(imageOneTrack);
            string imageTwoHEX = BinaryStringToHexString(imageTwoTrack);

            //Вычисляем расстояние Хэмминга
            int HammingDistance = returnHammingDistance(imageOneHEX, imageTwoHEX);

            //Возвращаем результат сравнения
            if (HammingDistance == 0)//одинаковые
            {
                return CompareResult.TheSame;
            }
            else if(HammingDistance > this.hammingDistanceLimitPercent*imageOneHEX.Length)//разные
            {
                return CompareResult.Various;
            }
            else
            {
                return CompareResult.Simular;
            }         
        }
     
        private void ChangeSize(ref Bitmap image1, int imgMiniSize)
        {
            image1 = new Bitmap(image1, new Size(imgMiniSize, imgMiniSize));
        }
        private float[] GetBlackModePixelsList(Bitmap image)
        {
            List<float> result = new List<float>();//Список пикселей со средним RGB
            for (int j = 0; j < image.Height; j++)
                for (int i = 0; i < image.Width; i++)
                {
                    // получаем (i, j) пиксель
                    UInt32 pixel = (UInt32)(image.GetPixel(i, j).ToArgb());
                    // получаем компоненты цветов пикселя
                    float R = (float)((pixel & 0x00FF0000) >> 16); // красный
                    float G = (float)((pixel & 0x0000FF00) >> 8); // зеленый
                    float B = (float)(pixel & 0x000000FF); // синий
                                                           // делаем цвет черно-белым (оттенки серого) - находим среднее арифметическое
                    result.Add((R + G + B) / 3.0f);
                }
            return result.ToArray();
        }
        private string GetTrack(List<float> imagePixels)
        {
            string result = "";
            float middleColor = imagePixels.Sum() / imagePixels.Count;
            foreach(float pixselColor in imagePixels)
            {
                if(pixselColor > middleColor)
                {
                    result += "1";
                }
                else
                {
                    result += "0";
                }
            }
            return result;
        }
        public string BinaryStringToHexString(string binary)
        {
            if (string.IsNullOrEmpty(binary))
                return binary;

            StringBuilder result = new StringBuilder(binary.Length / 8 + 1);

            // TODO: check all 1's or 0's... throw otherwise

            int mod4Len = binary.Length % 8;
            if (mod4Len != 0)
            {
                // pad to length multiple of 8
                binary = binary.PadLeft(((binary.Length / 8) + 1) * 8, '0');
            }

            for (int i = 0; i < binary.Length; i += 8)
            {
                string eightBits = binary.Substring(i, 8);
                result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
            }

            return result.ToString();
        }
        public string GetImageHEX(string imageName)
        {
            return this.GetImageHEX(new Bitmap(imageName));
        }
        public string GetImageHEX(Bitmap image)
        {
            List<float> imagePixels = new List<float>();
            string imageTrack = "";
            ChangeSize(ref image, imgMiniSize);

            imagePixels.AddRange(GetBlackModePixelsList(image));

            imageTrack = GetTrack(imagePixels);

            return BinaryStringToHexString(imageTrack);
        }
        private int returnHammingDistance(string imageOneHEX, string imageTwoHEX)
        {
            int result = 0;
            for (int i = 0; i < imageOneHEX.Length; i++)
            {
                if (imageOneHEX[i] != imageTwoHEX[i])
                {
                    result++;
                }
            }
            return result;

        }

    }
}
    
