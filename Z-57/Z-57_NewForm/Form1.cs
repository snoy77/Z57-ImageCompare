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
using System.Threading;

namespace Z_57_NewForm
{
    public partial class Form1 : Form
    {
        Task task1, task2, task3;

        PictureComparator pictureComparator = new PictureComparator();
        CancellationTokenSource cancellationTokenSource;
        CancellationToken token;

        int sumOfSteps = 0;
        int stepNow = 0;
        List<string> imageNames = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_FolderOfImages.Text = Application.StartupPath;
            folderBrowserDialog1.SelectedPath = Application.StartupPath;
            openFileDialog1.InitialDirectory = Application.StartupPath;
        }

        private void SetImageInBox(int numberBox, string imageName)
        {
            if (!checkBox_VisualImage.Checked)
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
            int len = fileNameFull.Length;
            if (len > 30)
            {
                return fileNameFull.Substring(0, 15) + "...\\" + Path.GetFileName(fileNameFull);
            }
            else
            {
                return fileNameFull;
            }
        }

        private void SetInterfaceStartWork()
        {
            button_Start.Text = "Start";
            button_Stop.Visible = false;
            panel_progressView.Visible = false;
            checkedListBox_ImagesClearName.Visible = true;

            //Текстовое поле выбора папки – можно изменить
        }


        private void RestartData()
        {
            this.imageNames.Clear();
            this.progressBar1.Value = 0;
            this.sumOfSteps = 0;
        }
        private void SetStartData()
        {
            cancellationTokenSource = new CancellationTokenSource();
            token = cancellationTokenSource.Token;
            this.sumOfSteps = 0;
            this.stepNow = 0;
            imageNames.Clear();

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
            label_progress.Text = progressBar1.Value.ToString() + " \\ " + progressBar1.Maximum.ToString();
        }
        private void UpdateProgressView()
        {
            stepNow++;
           
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
        private void StopAllThread()
        {
            cancellationTokenSource.Cancel();
            while ((task1.Status == TaskStatus.Running && task2.Status == TaskStatus.Running && task3.Status == TaskStatus.Running) == false)
            {
            }
            MessageBox.Show("Все потоки остановились");
        }

        private void FindNextDublicatForListImage(int taskIndex, CancellationToken token)
        {
            
            while (true)
            {
                if (token.IsCancellationRequested) { break; }

                Thread.Sleep(50);
                UpdateProgressView();
            }
        }
        private void FindNextDublicatForSourceImage(int taskIndex, CancellationToken token)
        {

            while (true)
            {
                if (token.IsCancellationRequested) { break; }
                Thread.Sleep(50);
                UpdateProgressView();
            }
        
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (button_Start.Text == "Начать")
            {
                button_Start.Text = "Продолжить";

                panel_progressView.Visible = true;
                checkedListBox_ImagesClearName.Visible = false;
                this.SetStartData();

                timer1.Enabled = true;
              
            }
            else if (button_Start.Text == "Продолжить") 
            {

            }

            button_Start.Visible = false;
            button_Stop.Text = "Остановить";
            button_Stop.Visible = true;

            if (radioButton2.Checked == true)
            {
                task1 = Task.Run(() => FindNextDublicatForListImage(0, token));
                task2 = Task.Run(() => FindNextDublicatForListImage(1, token));
                task3 = Task.Run(() => FindNextDublicatForListImage(2, token));
            }
            else if (radioButton1.Checked == true)
            {

                task1 = Task.Run(() => FindNextDublicatForSourceImage(0, token));
                task2 = Task.Run(() => FindNextDublicatForSourceImage(1, token));
                task3 = Task.Run(() => FindNextDublicatForSourceImage(2, token));

            }
        }
        private void button_Stop_Click(object sender, EventArgs e)
        {
            if (button_Stop.Text == "Остановить")
            {
                StopAllThread();
                cancellationTokenSource = new CancellationTokenSource();
                token = cancellationTokenSource.Token;

                button_Stop.Text = "Закончить";
                button_Start.Visible = true;
            }
            else if (button_Stop.Text == "Закончить")
            {
                button_Start.Text = "Начать";
                timer1.Enabled = false;

                panel_progressView.Visible = false;
                checkedListBox_ImagesClearName.Visible = true;

                panel_buttons.Visible = false;

                button_Stop.Visible = false;
            }
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (stepNow > progressBar1.Maximum)
            {
               
                button_Start.Text = "Начать";
                button_Stop.Text = "Остановить";
                StopAllThread();
                checkedListBox_ImagesClearName.Visible = true;
                panel_progressView.Visible = false;
                MessageBox.Show("Всё сделало кароче");
                timer1.Enabled = false;
            }
            else
            {
                progressBar1.Value = stepNow;
                label_progress.Text = progressBar1.Value.ToString() + " \\ " + progressBar1.Maximum.ToString();
            }
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
    }
}
