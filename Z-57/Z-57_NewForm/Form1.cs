using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Diagnostics;
using Z_57_DLL;

namespace Z_57_NewForm
{
    public partial class Form1 : Form
    {
        PictureComparator pictureComparator = new PictureComparator();

        int sumOfSteps = 0;
        List<string> imageNames = new List<string>();


        public Form1()
        {
            InitializeComponent();
        }

        private void SetImageInBox(int numberBox, string imageName)
        {
            if(!checkBox_VisualImage.Checked)
            {
                return;
            }
            switch (numberBox)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile(imageName);
                    break;
                case 2:
                    pictureBox3.Image = Image.FromFile(imageName);
                    break;
            }
        }
        private string GetSmallFileName(string fileNameFull)
        {
            int len =fileNameFull.Length;
            if (len > 30)
            {
                return fileNameFull.Substring(0, 15) + "...\\" + Path.GetFileName(fileNameFull);
            }
            else
            {
                 return fileNameFull;
            }
        }
        private void SetImageInfo(int numberBox, string imageName)
        {
            SetImageInfo(numberBox, imageName, "");
        }
        private void SetImageInfo(int numberBox, string imageName, string imageHex)
        {
            switch (numberBox)
            {
                case 1:
                    {
                        pictureBox1.Image = null;
                        label_imageOneName.Text = "";
                        textBox_ImageOneName.Text = "";
                        textBox_ImageOneHEX.Text = "";
                        if (File.Exists(imageName))
                        {
                            SetImageInBox(1, imageName);
                            if (checkBoxVisibleHexOfImage.Checked)
                            {
                                if (imageHex == "")
                                {
                                    imageHex = pictureComparator.GetImageHEX(imageName);
                                }
                                textBox_ImageOneHEX.Text = imageHex;
                            }
                            label_imageOneName.Text = Path.GetFileName(imageName);
                            textBox_ImageOneName.Text = Path.GetFileName(imageName);
                        }
                    }
                    break;
                case 2:
                    {
                        pictureBox3.Image = null;
                        textBox_ImageTwoName.Text = "";
                        textBox_ImageTwoHEX.Text = "";
                        if (File.Exists(imageName))
                        {
                            SetImageInBox(2, imageName);
                            if (checkBoxVisibleHexOfImage.Checked)
                            {
                                if (imageHex == "")
                                {
                                    imageHex = pictureComparator.GetImageHEX(imageName);
                                }
                                textBox_ImageTwoHEX.Text = imageHex;
                            }
                            textBox_ImageTwoName.Text = Path.GetFileName(imageName);
                        }
                    }
                    break;
            }
            
        }
        private void SetImagesNameIntoList(string folderName)
        {
            string[] names = Directory.GetFiles(folderName).Where(x => x.Contains(".jpg") || x.Contains(".png")).ToArray();
            checkedListBox_ImagesClearName.Items.AddRange(names.Select(x => Path.GetFileName(x)).ToArray());

            for (int i = 0; i < checkedListBox_ImagesClearName.Items.Count; i++)
            {
                checkedListBox_ImagesClearName.SetItemChecked(i, true);
            }
        }
        private bool ShowFileDialog()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_OriginalImageFileName.Text = openFileDialog1.FileName;
                openFileDialog1.InitialDirectory = Path.GetDirectoryName(openFileDialog1.FileName);
                return true;
            }
            else
                return false;
        }

        private void Restart()
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_FolderOfImages.Text = Application.StartupPath;
            folderBrowserDialog1.SelectedPath = Application.StartupPath;
            openFileDialog1.InitialDirectory = Application.StartupPath;
        }

        private void UpdateprogressView(int step)
        {
            progressBar1.PerformStep();
            label_progress.Text = progressBar1.Step.ToString() + " \\ " + progressBar1.Maximum.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void RestartData()
        {
            this.imageNames.Clear();
            this.sumOfSteps = 0;
        }
        private void button_Start_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && pictureBox1.Image == null)
            {
                MessageBox.Show("Выберите сравниваемое изображение");
                return;
            }
            checkedListBox_ImagesClearName.Visible = false;
            panel_progressView.Visible = true;
            RestartData();

            //Создание списка имён изображений
            for (int i = 0; i < checkedListBox_ImagesClearName.CheckedItems.Count; i++)
            {
                imageNames.Add(textBox_FolderOfImages.Text + "\\" + checkedListBox_ImagesClearName.CheckedItems[i].ToString());
            }

            //Подсчёт шагов
            if (radioButton1.Checked)
            {
                this.sumOfSteps = imageNames.Count;
            }
            else
            {
                for (int i = 1; i < imageNames.Count; i++)
                {
                    sumOfSteps += i;
                }
            }
            progressBar1.Maximum = this.sumOfSteps;
            label_progress.Text = progressBar1.Step.ToString() + " \\ " + progressBar1.Maximum.ToString();

            //подумай про многопоточность

        }
        private void button_Stop_Click(object sender, EventArgs e)
        {
            checkedListBox_ImagesClearName.Visible = true;
            panel_progressView.Visible = false;
            RestartData();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox_OriginalImageFileName.Visible = true;
                label2.Visible = true;

                textBox_ImageOneName.Visible = false;
                label_imageOneName.Visible = true;
            }
            else
            {
                textBox_OriginalImageFileName.Visible = false;
                textBox_OriginalImageFileName.Text = "";
                label2.Visible = false;

                textBox_ImageOneName.Visible = true;
                label_imageOneName.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                panel1.Visible = true;
                radioButton3.Checked = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                panel3.Visible = true;
                radioButton6.Checked = true;
            }
            else
            {
                panel3.Visible = false;
            }
        }

        
        private void textBox_FolderOfImages_TextChanged(object sender, EventArgs e)
        {
            checkedListBox_ImagesClearName.Items.Clear();
            try
            {
                SetImagesNameIntoList(textBox_FolderOfImages.Text);
            }
            catch
            {

            }

        }
        private void textBox_FolderOfImages_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_FolderOfImages.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void ShowFileInExplorer(string fileName)
        {
            //Process PrFolder = new Process();
            //ProcessStartInfo psi = new ProcessStartInfo();
            //string file = @"C:\sample.txt";
            //psi.CreateNoWindow = true;
            //psi.WindowStyle = ProcessWindowStyle.Normal;
            //psi.FileName = "explorer";
            //psi.Arguments = @"/n, /select, " + fileName;
            //PrFolder.StartInfo = psi;
            //PrFolder.Start();
        }
        private void textBox_ImageOneName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowFileInExplorer(textBox_FolderOfImages + "\\" + textBox_ImageOneName.Text);
        }
        private void textBox_ImageTwoName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowFileInExplorer(textBox_FolderOfImages + "\\" + textBox_ImageTwoName.Text);
        }

        private void textBox_OriginalImageFileName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                ShowFileDialog();
            }
        }
        private void textBox_OriginalImageFileName_TextChanged(object sender, EventArgs e)
        {
            SetImageInfo(1, textBox_OriginalImageFileName.Text);
        }

        private void checkBox_VisualImage_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_VisualImage.Checked == true)
            {
                pictureBox1.Visible = true;
                pictureBox3.Visible = true;

                if (radioButton1.Checked)
                {
                    SetImageInfo(1, textBox_OriginalImageFileName.Text);
                }
            }
            else
            {
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox1.Image = null;
                pictureBox3.Image = null;
            }
        }
        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                ShowFileDialog();
            }
        }

        private void checkBoxVisibleHexOfImage_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVisibleHexOfImage.Checked)
            {
                panel_ImagesHEX.Visible = true;
                SetImageInfo(1, textBox_FolderOfImages.Text + "\\" + textBox_ImageOneName.Text);
                SetImageInfo(2, textBox_FolderOfImages.Text + "\\" + textBox_ImageTwoName.Text);
            }
            else
            {
                panel_ImagesHEX.Visible = false;
            }
        }
    }
}
