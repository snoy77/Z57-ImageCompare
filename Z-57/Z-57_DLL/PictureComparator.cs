using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Z_57_DLL
{
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

        public string GetImageHEX(string imageName)
        {
            return this.GetImageHEX(new Bitmap(imageName));
        }
        public string GetImageHEX(Bitmap image)
        {
            List<float> imagePixels = new List<float>();
            string imageTrack = "";
            changeSize(ref image, imgMiniSize);

            setBlackMode(image, imagePixels);

            setTrack(imagePixels, ref imageTrack);

            return BinaryStringToHexString(imageTrack);
        }

        public int CompareImages(Bitmap imageOne, Bitmap imageTwo)
        {
            return CompareImages(imageOne, imageTwo, this.imgMiniSize, this.hammingDistanceLimitPercent);
        }
        public int CompareImages(Bitmap imageOne, Bitmap imageTwo, int imgMiniSize)
        {
            return CompareImages(imageOne, imageTwo, imgMiniSize, this.hammingDistanceLimitPercent);
        }
        public int CompareImages(Bitmap imageOne, Bitmap imageTwo, int imgMiniSize, double hammingDistanceLimitPercent)
        {
            List<float> imageOnePixels = new List<float>();//значения цветов пикселей первой картинки
            List<float> imageTwoPixels = new List<float>();
            string imageOneTrack = "";
            string imageTwoTrack = "";
            changeSize(ref imageOne, imgMiniSize);
            changeSize(ref imageTwo, imgMiniSize);

            setBlackMode(imageOne, imageOnePixels);
            setBlackMode(imageTwo, imageTwoPixels);

            setTrack(imageOnePixels, ref imageOneTrack);
            setTrack(imageTwoPixels, ref imageTwoTrack);

            string imageOneHEX = BinaryStringToHexString(imageOneTrack);
            string imageTwoHEX = BinaryStringToHexString(imageTwoTrack);

            int HammingDistance = returnHammingDistance(imageOneHEX, imageTwoHEX);

            if (HammingDistance == 0)//одинаковые
            {
                return 0;
            }
            else if(HammingDistance > this.hammingDistanceLimitPercent*imageOneHEX.Length)//разные
            {
                return 1;
            }
            else
            {
                return 2;//есть сомнения
            }         
        }
        public void changeSize(ref Bitmap image1, int imgMiniSize)
        {
            image1 = new Bitmap(image1, new Size(imgMiniSize, imgMiniSize));
        }
        public void setBlackMode(Bitmap image, List<float> pixels)
        {
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
                    pixels.Add((R + G + B) / 3.0f);
                }
        }
        private void setTrack(List<float> imagePixels, ref string imageTrack)
        {
            float middleColor = imagePixels.Sum() / imagePixels.Count;
            foreach(float pixselColor in imagePixels)
            {
                if(pixselColor > middleColor)
                {
                    imageTrack += "1";
                }
                else
                {
                    imageTrack += "0";
                }
            }
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
        public int returnHammingDistance(string imageOneHEX, string imageTwoHEX)
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
    
