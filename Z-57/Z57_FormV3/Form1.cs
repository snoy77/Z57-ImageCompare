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
using Z_57_DLL;
using System.Threading;

namespace Z57_FormV3
{
    public partial class Form1 : Form
    {
        string sourceFolderPath;
        string dublicatsFoldersPath;
        string dublicatsFolderName;
        string dublicatsFolderFullName { get { return dublicatsFoldersPath + dublicatsFolderName; } }

        int progressNow;
        int progressMax = 1000;

        List<string> imageList = new List<string>();
        List<int[]> dublicatsImageIndexesList = new List<int[]>();


        List<Task> tasks = new List<Task>();
        int taskCount;
        int[][] taskIndexes;
       
        PictureComparator pictureComparator;


        public Form1()
        {
            InitializeComponent();
        }

        private void DataInterfaceUpdate()
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_sourceFolder.Text = Application.StartupPath;
            folderBrowserDialog1.SelectedPath = sourceFolderPath;
            this.pictureComparator = new PictureComparator(int.Parse(textBox_HummingsLenForDublicat.Text), 35);

            this.dublicatsFoldersPath = textBox_PathToDublicatsFolder.Text;
            this.dublicatsFolderName = textBox_dublicatsFolderName.Text;
            this.taskCount = int.Parse(textBox_TaskCount.Text);
        }
        //Установки интерфейса
        private void SetInterfacevariant(int interfaceIndex)
        {
            switch (interfaceIndex)
            {
                case 1:
                    {
                        button_start.Text = "Продолжить";
                        button_stop.Text = "Остановить";
                        panel2.Visible = true;
                        break;
                    }
            }
        }

        //Дополнительные методы
        private int Sum(int digit)
        {
            int result = 0;
            for (int i = 1; i < digit; i = i + 1)
            {
                result = result + i;
            }
            return result;
        }
          
    
        private void SetImagesNameInVisualList()
        {
            checkedListBox_imagesInFolder.Items.Clear();

            if (!Directory.Exists(this.sourceFolderPath)) { return; }

            //Добавляю в список имена файлов - изображений
            checkedListBox_imagesInFolder.Items.AddRange(Directory.GetFiles(this.sourceFolderPath).
                Select(x => Path.GetFileName(x)).
                Where(x => x.EndsWith(".jpeg") || x.EndsWith(".jpg") || x.EndsWith(".png")).ToArray());

            //Меняю на состояние "выбрано"
            for (int i = 0; i < checkedListBox_imagesInFolder.Items.Count; i++)
            {
                checkedListBox_imagesInFolder.SetItemChecked(i, true);
            }
        }
        private void ShowNumberSelectedItem()//Отложено до лучших времён
        {
            label_NumberSelectedImages.Text = "Количество изображений: " + checkedListBox_imagesInFolder.CheckedItems.Count.ToString();
        }

        //Контроллеры - события
        private void textBox_sourceFolder_TextChanged(object sender, EventArgs e)
        {
            this.sourceFolderPath = textBox_sourceFolder.Text;
            this.SetImagesNameInVisualList();
        }
        private void textBox_sourceFolder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_sourceFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void textBox_HummingsLenForDublicat_TextChanged(object sender, EventArgs e)
        {
            if (textBox_HummingsLenForDublicat.Text != "")
            {
                this.pictureComparator.hammingDistanceLimit = int.Parse(textBox_HummingsLenForDublicat.Text);
            }
        }
        private void textBox_HummingsLenForDublicat_Leave(object sender, EventArgs e)
        {
            if (textBox_HummingsLenForDublicat.Text == "")
            {
                textBox_HummingsLenForDublicat.Text = "0";
            }
        }

        private void textBox_dublicatsFolderName_TextChanged(object sender, EventArgs e)
        {
            this.dublicatsFolderName = textBox_dublicatsFolderName.Text;
        }
        private void textBox_dublicatsFolderName_Leave(object sender, EventArgs e)
        {
            if(textBox_dublicatsFolderName.Text == "")
            {
                textBox_dublicatsFolderName.Text= "Z57_Dublicats";
            }
        }

        private void textBox_PathToDublicatsFolder_TextChanged(object sender, EventArgs e)
        {
            if(textBox_PathToDublicatsFolder.Text == "")
            {
                this.dublicatsFoldersPath = this.sourceFolderPath;
                return;
            }
            this.dublicatsFoldersPath = textBox_PathToDublicatsFolder.Text;
        }
        private void textBox_PathToDublicatsFolder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_PathToDublicatsFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void textBox_TaskCount_TextChanged(object sender, EventArgs e)
        {
            this.taskCount = int.Parse(textBox_TaskCount.Text);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel_ControllersForSourceImageName.Visible = radioButton2.Checked;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (button_start.Text == "Начать")
            {
                this.SetStartData();
            }
            
            SetInterfacevariant(1);

            this.backgroundWorker1.RunWorkerAsync();//Запуск проеряльщика дубликатов
            timer1.Enabled = true;//запуск таймера прогресса

            if (radioButton1.Checked)
            {
                for (int i = 0; i < this.taskCount; i = i + 1)
                {
                    this.tasks.Add(Task.Run(() => FindDublicats(ref taskIndexes[i][0], ref taskIndexes[i][1], taskCount)));
                    Thread.Sleep(100);
                }
            }
        }
        private void button_stop_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker me = sender as BackgroundWorker;

            while (this.CheckDublicatsList() == false)
            {
                me.ReportProgress(1);

                Thread.Sleep(300);
            }
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            UpdateProgressBar();
        }
        //Рабочие функции
        private void MoveDublicats(string imageName)
        {
            if (!Directory.Exists(dublicatsFolderFullName))
            {
                Directory.CreateDirectory(dublicatsFolderFullName);
            }
            while (true)
            {
                try
                {
                    File.Move(imageName, dublicatsFolderFullName + "\\" + Path.GetFileName(imageName));
                    break;
                }
                catch { }
            }
        }
        private bool CheckDublicatsList()
        {
            while (dublicatsImageIndexesList.Count != 0)
            {
                string fileNameSource = imageList[dublicatsImageIndexesList[0][0]];
                string fileNameCompare = imageList[dublicatsImageIndexesList[0][1]];
                if (File.Exists(fileNameSource) && File.Exists(fileNameCompare))
                {
                    if (checkBox1.Checked)
                    {
                        MoveDublicats(fileNameCompare);
                    }
                    else
                    {
                        return true;
                    }
                }
                dublicatsImageIndexesList.RemoveAt(0);
            }
            return false;
        }
        private void FindDublicats(ref int sourceIndex, ref int compareIndex, int step)
        {
            int result = 0;

            Bitmap sourceImage = null;
            Bitmap compareImage = null;

            while(sourceIndex < this.imageList.Count-1)
            {
                if (File.Exists(imageList[sourceIndex]))
                {
                    bool isClose = true;
                    bool canSay = true;
                    while (isClose)
                    {
                        try
                        {
                            sourceImage = new Bitmap(imageList[sourceIndex]);
                            isClose = false;
                        }
                        catch
                        {
                            if (canSay)
                            {
                                MessageBox.Show("опачки");
                                canSay = false;
                            }
                        }
                    }

                    while (compareIndex < imageList.Count)
                    {
                        if (File.Exists(imageList[compareIndex]))
                        {
                            isClose = true;
                            while (isClose)
                            {
                                try
                                {
                                    compareImage = new Bitmap(imageList[compareIndex]);
                                    isClose = false;
                                }
                                catch
                                {
                                    if (canSay)
                                    {
                                        MessageBox.Show("опачки");
                                        canSay = false;
                                    }
                                }
                            }

                            result = this.pictureComparator.CompareImages(sourceImage, compareImage);

                            if(result == 0)
                            {
                                this.AddDublicats(sourceIndex, compareIndex);
                            }
                        }
                        compareImage = null;
                        compareIndex = compareIndex + 1;
                        progressNow = progressNow + 1;
                    }
                }
                else
                {
                    progressNow = progressNow + (imageList.Count - sourceIndex - 1);
                }
                sourceImage = null;
                sourceIndex = sourceIndex + tasks.Count;//Счётчик исходного изображения + количество потоков
                compareIndex = sourceIndex + 1;
            }
            MessageBox.Show("бб");
        }
        private void AddDublicats(int sourceIndex, int compareIndex)
        {
            dublicatsImageIndexesList.Add(new int[2] { sourceIndex, compareIndex });
        }

        private void UpdateProgressBar()
        {
            progressBar1.Value = progressNow;
            label_ProgressSteps.Text = "Сравнило: " + progressNow.ToString() + " // " + progressMax.ToString();
        }
        private void UpdateSystemWorkInformation()
        {
            listBox1.Items.Clear();
            if (checkBox2.Checked)
            {
                for (int i = 0; i < taskIndexes.Length; i = i + 1)
                {
                    listBox1.Items.Add(i.ToString() + "-0: " + taskIndexes[i][0]);
                    listBox1.Items.Add(i.ToString() + "-1: " + taskIndexes[i][1]);
                }
            }
        }
       
        private void SetStartData()
        {
            //Обновление закрытия токена


            this.imageList.Clear();
            for (int i = 0; i < checkedListBox_imagesInFolder.CheckedItems.Count; i++)
            {
                this.imageList.Add(textBox_sourceFolder.Text + "\\" + checkedListBox_imagesInFolder.CheckedItems[i].ToString());
            }

            this.tasks.Clear();

            this.taskIndexes = new int[taskCount][];
            for (int i = 0; i < taskCount; i = i + 1)
            {
                taskIndexes[i] = new int[2];
                taskIndexes[i][0] = i;
                taskIndexes[i][1] = i + 1;
            }

            //Высчитать количество максимальных шагов
            progressMax = Sum(imageList.Count);
            progressBar1.Maximum = this.progressMax;
            progressNow = 0;
            UpdateProgressBar();
            
        }
    }
}
