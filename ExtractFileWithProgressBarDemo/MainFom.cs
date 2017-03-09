/*
//A demo for indicating an accurate progressbar when extracting a zip file
//
//by xswxm.com
*/
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ExtractFileWithProgressBarDemo
{
    public partial class MainFom : Form
    {
        private BackgroundWorker extractFile;
        private long fileSize;    //the size of the zip file
        private long extractedSizeTotal;    //the bytes total extracted
        private long compressedSize;    //the size of a single compressed file
        private string compressedFileName;    //the name of the file being extracted
        public MainFom()
        {
            InitializeComponent();
            
            //Set the maximum vaue to int.MaxValue, thus, it could be more accurate
            progressBar_Individual.Maximum = int.MaxValue;
            progressBar_Total.Maximum = int.MaxValue;

            extractFile = new BackgroundWorker();
            extractFile.DoWork += ExtractFile_DoWork;
            extractFile.ProgressChanged += ExtractFile_ProgressChanged;
            extractFile.RunWorkerCompleted += ExtractFile_RunWorkerCompleted;
            extractFile.WorkerReportsProgress = true;
        }

        private void ExtractFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Set the maximum vaue to int.MaxValue because the process is completed
            progressBar_Individual.Value = int.MaxValue;
            progressBar_Total.Value = int.MaxValue;
            MessageBox.Show("Done!");
        }

        private void ExtractFile_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            textBox_ExtractFile.Text = compressedFileName;

            progressBar_Individual.Value = e.ProgressPercentage;

            //calculate the totalPercent
            long totalPercent = ((long)e.ProgressPercentage * compressedSize + extractedSizeTotal * int.MaxValue) / fileSize;
            if (totalPercent > int.MaxValue)
                totalPercent = int.MaxValue;
            progressBar_Total.Value = (int)totalPercent;
        }

        private void ExtractFile_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string fileName = textBox_FilePath.Text;
                string extractPath = textBox_ExtractionFolder.Text;

                //get the size of the zip file
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(fileName);
                fileSize = fileInfo.Length;
                using (Ionic.Zip.ZipFile zipFile = Ionic.Zip.ZipFile.Read(fileName))
                {
                    //reset the bytes total extracted to 0
                    extractedSizeTotal = 0;
                    int fileAmount = zipFile.Count;
                    int fileIndex = 0;
                    zipFile.ExtractProgress += Zip_ExtractProgress;
                    foreach (Ionic.Zip.ZipEntry ZipEntry in zipFile)
                    {
                        fileIndex++;
                        compressedFileName = "(" + fileIndex.ToString() + "/" + fileAmount + "): " + ZipEntry.FileName;
                        //get the size of a single compressed file
                        compressedSize = ZipEntry.CompressedSize;
                        ZipEntry.Extract(extractPath, Ionic.Zip.ExtractExistingFileAction.OverwriteSilently);
                        //calculate the bytes total extracted
                        extractedSizeTotal += compressedSize;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Zip_ExtractProgress(object sender, Ionic.Zip.ExtractProgressEventArgs e)
        {
            if (e.TotalBytesToTransfer > 0)
            {
                long percent = e.BytesTransferred * int.MaxValue / e.TotalBytesToTransfer;
                //Console.WriteLine("Indivual: " + percent);
                extractFile.ReportProgress((int)percent);
            }
        }

        private void btn_Extract_Click(object sender, EventArgs e)
        {
            if (textBox_FilePath.Text != string.Empty && textBox_ExtractionFolder.Text != string.Empty)
                extractFile.RunWorkerAsync();
            else
                MessageBox.Show("Please choose a zip file and extraction folder first!");
        }

        private void btn_ChooseZipFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "ZIP File|*.zip";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                textBox_FilePath.Text = openFileDialog.FileName;
        }

        private void btn_ChooseExtractionFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.Description = "Please choose a extraction folder.";
            if (dilog.ShowDialog() == DialogResult.OK)
            {
                textBox_ExtractionFolder.Text = dilog.SelectedPath;
            }
        }
    }
}
