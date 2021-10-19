using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Z57_ImageComporator;

namespace Z_57_form
{
    
    public partial class Form1 : Form
    {
        Image image1;
        Bitmap bitmap1;
        Image image2;
        Bitmap bitmap2;

        int newSize;
        double pupu;

        List<float> sled1;
        List<float> sled2;
        string byteList3 = "";
        string byteList4 = "";
        public Form1()
        {
            InitializeComponent();
            newSize = 32;
            pupu = 0.05;
            sled1 = new List<float>();
            sled2 = new List<float>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bitmap1 = new Bitmap(Image.FromFile(textBox1.Text));
            bitmap2 = new Bitmap(Image.FromFile(textBox2.Text));
            pictureBox1.Image = bitmap1;
            pictureBox2.Image = bitmap2;
            sled1.Clear();
            sled2.Clear();
            byteList3 = "";
            byteList4 = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            bitmap1 = new Bitmap(bitmap1, new Size(newSize, newSize));
            bitmap2 = new Bitmap(bitmap2, new Size(newSize, newSize));
            pictureBox1.Image = bitmap1;
            pictureBox2.Image = bitmap2;
        }
        private void setBlackMode(Bitmap bitmap, List<float> sled)
        {
            // создаём Bitmap для черно-белого изображения
            //Bitmap output = new Bitmap(bitmap1.Width, bitmap1.Height);
            // перебираем в циклах все пиксели исходного изображения
            for (int j = 0; j < bitmap.Height; j++)
                for (int i = 0; i < bitmap.Width; i++)
                {
                    // получаем (i, j) пиксель
                    UInt32 pixel = (UInt32)(bitmap.GetPixel(i, j).ToArgb());
                    // получаем компоненты цветов пикселя
                    float R = (float)((pixel & 0x00FF0000) >> 16); // красный
                    float G = (float)((pixel & 0x0000FF00) >> 8); // зеленый
                    float B = (float)(pixel & 0x000000FF); // синий
                                                           // делаем цвет черно-белым (оттенки серого) - находим среднее арифметическое
                    R = G = B = (R + G + B) / 3.0f;
                    sled.Add(R);
                    // собираем новый пиксель по частям (по каналам)
                    UInt32 newPixel = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
                    // добавляем его в Bitmap нового изображения
                    bitmap.SetPixel(i, j, Color.FromArgb((int)newPixel));
                }
            // выводим черно-белый Bitmap в pictureBox2
            
        }
        private void setSled(Bitmap bitmap, List<float> sled,ref string byteList)
        {
            float middleColor = sled.Sum() / sled1.Count;

            for (int j = 0; j < bitmap.Height; j++)
                for (int i = 0; i < bitmap.Width; i++)
                {
                    // получаем (i, j) пиксель
                    UInt32 pixel = (UInt32)(bitmap.GetPixel(i, j).ToArgb());
                    UInt32 newPixel;
                    // получаем компоненты цветов пикселя
                    float B = (float)(pixel & 0x000000FF); // синий
                    if (B >= middleColor)
                    {
                        newPixel = 0xFF000000 | ((UInt32)255 << 16) | ((UInt32)255 << 8) | ((UInt32)255);
                        //byteList.Add(1);
                        byteList += "1";
                    }
                    else
                    {
                        newPixel = 0xFF000000 | ((UInt32)0 << 16) | ((UInt32)0 << 8) | ((UInt32)0);
                        //byteList.Add(0);
                        byteList += "0";

                    }
                    bitmap.SetPixel(i, j, Color.FromArgb((int)newPixel));
                }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            setBlackMode(bitmap1, sled1);
            setBlackMode(bitmap2, sled2);
            pictureBox1.Image = bitmap1;
            pictureBox2.Image = bitmap2;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            setSled(bitmap1, sled1,ref byteList3);
            setSled(bitmap2, sled2, ref byteList4);
            pictureBox1.Image = bitmap1;
            pictureBox2.Image = bitmap2;
        }
        public static string BinaryStringToHexString(string binary)
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
        private void button5_Click(object sender, EventArgs e)
        {
            label6.Text = BinaryStringToHexString(byteList3);/*BitConverter.ToUInt64(byteList1.ToArray(), 0).ToString();*/
            label8.Text = BinaryStringToHexString(byteList4);/*BitConverter.ToUInt64(byteList2.ToArray(), 0).ToString();*/
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int count = 0;
            for(int i = 0; i < byteList3.Length; i++)
            {
                if(byteList3[i] != byteList4[i])
                {
                    count++;
                }
            }
            if(count == 0)
            {
                label9.Text = "Абсолютно одинаковые";
            }
            else if(count > byteList3.Length*pupu)
            {
                label9.Text = "Разные";
            }
            else
            {
                label9.Text = "Вроде одинаковые";
            }

        }
        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            PictureComparator pic = new PictureComparator();
            MessageBox.Show(
                pic.CompareTwoImage(
                    new Bitmap(textBox1.Text), 
                    new Bitmap(textBox2.Text), 
                    int.Parse(textBox6.Text), 
                    double.Parse(textBox5.Text)).ToString());
        }
    }
    public class ZZ
    {
        public Image ResizeImage(int newSize, Image originalImage)
        {
            if (originalImage.Width <= newSize)
                newSize = originalImage.Width;

            var newHeight = originalImage.Height * newSize / originalImage.Width;

            if (newHeight > newSize)
            {
                // Resize with height instead
                newSize = originalImage.Width * newSize / originalImage.Height;
                newHeight = newSize;
            }

            return originalImage.GetThumbnailImage(newSize, newHeight, null, IntPtr.Zero);
        }
    }
}
