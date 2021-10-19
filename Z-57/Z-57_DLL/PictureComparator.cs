using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Z57_ImageComporator
{
    public enum CompareResult 
    {
        TheSame = 0,
        Simular = 1,
        Various = 2
    }

    public class PictureComparator
    {
        public double HammingDistanceLimitPercent;
        public int ImgMiniSize;

        public PictureComparator() : this(10, 35) { }
        public PictureComparator(double hammingDistanceLimitPercent, int imgMiniSize)
        {
            this.HammingDistanceLimitPercent = hammingDistanceLimitPercent;
            this.ImgMiniSize = imgMiniSize;
        }
        public CompareResult CompareTwoImage(string imageOneFileName, string imageTwoFileName)
        {
            return this.CompareTwoImage(new Bitmap(imageOneFileName), new Bitmap(imageTwoFileName), this.ImgMiniSize, this.HammingDistanceLimitPercent);
        }
        public CompareResult CompareTwoImage(Bitmap imageOne, Bitmap imageTwo)
        {
            return CompareTwoImage(imageOne, imageTwo, this.ImgMiniSize, this.HammingDistanceLimitPercent);
        }
        public CompareResult CompareTwoImage(Bitmap imageOne, Bitmap imageTwo, int imgMiniSize)
        {
            return CompareTwoImage(imageOne, imageTwo, imgMiniSize, this.HammingDistanceLimitPercent);
        }
        public CompareResult CompareTwoImage(Bitmap imageOne, Bitmap imageTwo, int imgMiniSize, double hammingDistanceLimitPercent)
        {
            //Изменяем размеры картинок
            imageOne = new Bitmap(imageOne, new Size(imgMiniSize, imgMiniSize));
            imageTwo = new Bitmap(imageTwo, new Size(imgMiniSize, imgMiniSize));

            //Получаем список значений пикселей, у каждого из которых среднее значение RGB
            List<float> imageOnePixels = new List<float>();//значения цветов пикселей первой картинки
            List<float> imageTwoPixels = new List<float>();
            imageOnePixels.AddRange(GetTheAverageValueOfPixels(imageOne));
            imageTwoPixels.AddRange(GetTheAverageValueOfPixels(imageTwo));

            //Получаем список битов -структуру(след)
            string imageOneTrack = "";//биты структуры изображений
            string imageTwoTrack = "";
            imageOneTrack = GetTrack(imageOnePixels);
            imageTwoTrack = GetTrack(imageTwoPixels);

            //Получаем Хеш изображения
            string imageOneHEX = BinaryStringToHexString(imageOneTrack);
            string imageTwoHEX = BinaryStringToHexString(imageTwoTrack);

            //Вычисляем расстояние Хэмминга
            int hammingDistanceResult = GetHammingDistance(imageOneHEX, imageTwoHEX);
            double hamingDistanceResultPersent = (double)hammingDistanceResult/((double)imageOneHEX.Length / 100);
            imageOne.Dispose();
            imageTwo.Dispose();
            Console.WriteLine($"Длина хекс представления: {imageOneHEX.Length} | Дист. Хаминга: {hammingDistanceResult.ToString()} | res: {hamingDistanceResultPersent}%");
           
            //Возвращаем результат сравнения
            if (hammingDistanceResult == 0)//одинаковые
            {
                return CompareResult.TheSame;
            }
            else if(hamingDistanceResultPersent > hammingDistanceLimitPercent)//разные
            {
                return CompareResult.Various;
            }
            else
            {
                return CompareResult.Simular;
            }         
        }
        private float[] GetTheAverageValueOfPixels(Bitmap image)
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
        private int GetHammingDistance(string imageOneHEX, string imageTwoHEX)
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
    
