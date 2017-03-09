namespace ExtractFileWithProgressBarDemo
{
    partial class MainFom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar_Total = new System.Windows.Forms.ProgressBar();
            this.textBox_ExtractFile = new System.Windows.Forms.TextBox();
            this.progressBar_Individual = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_FilePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Extract = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ExtractionFolder = new System.Windows.Forms.TextBox();
            this.btn_ChooseExtractionFolder = new System.Windows.Forms.Button();
            this.btn_ChooseZipFile = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar_Total
            // 
            this.progressBar_Total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar_Total.Location = new System.Drawing.Point(119, 110);
            this.progressBar_Total.Name = "progressBar_Total";
            this.progressBar_Total.Size = new System.Drawing.Size(745, 23);
            this.progressBar_Total.TabIndex = 0;
            // 
            // textBox_ExtractFile
            // 
            this.textBox_ExtractFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ExtractFile.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_ExtractFile.Location = new System.Drawing.Point(119, 55);
            this.textBox_ExtractFile.Name = "textBox_ExtractFile";
            this.textBox_ExtractFile.ReadOnly = true;
            this.textBox_ExtractFile.Size = new System.Drawing.Size(745, 20);
            this.textBox_ExtractFile.TabIndex = 1;
            // 
            // progressBar_Individual
            // 
            this.progressBar_Individual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar_Individual.Location = new System.Drawing.Point(119, 81);
            this.progressBar_Individual.Name = "progressBar_Individual";
            this.progressBar_Individual.Size = new System.Drawing.Size(745, 23);
            this.progressBar_Individual.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Destination:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox_FilePath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.progressBar_Total, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.progressBar_Individual, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_ExtractFile, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_ExtractionFolder, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(867, 137);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Extracting File:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Progress (Individual):";
            // 
            // textBox_FilePath
            // 
            this.textBox_FilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_FilePath.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_FilePath.Location = new System.Drawing.Point(119, 3);
            this.textBox_FilePath.Name = "textBox_FilePath";
            this.textBox_FilePath.ReadOnly = true;
            this.textBox_FilePath.Size = new System.Drawing.Size(745, 20);
            this.textBox_FilePath.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Progress (Total):";
            // 
            // btn_Extract
            // 
            this.btn_Extract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Extract.Location = new System.Drawing.Point(801, 175);
            this.btn_Extract.Name = "btn_Extract";
            this.btn_Extract.Size = new System.Drawing.Size(75, 23);
            this.btn_Extract.TabIndex = 9;
            this.btn_Extract.Text = "Extract";
            this.btn_Extract.UseVisualStyleBackColor = true;
            this.btn_Extract.Click += new System.EventHandler(this.btn_Extract_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "File Path:";
            // 
            // textBox_ExtractionFolder
            // 
            this.textBox_ExtractionFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ExtractionFolder.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_ExtractionFolder.Location = new System.Drawing.Point(119, 29);
            this.textBox_ExtractionFolder.Name = "textBox_ExtractionFolder";
            this.textBox_ExtractionFolder.ReadOnly = true;
            this.textBox_ExtractionFolder.Size = new System.Drawing.Size(745, 20);
            this.textBox_ExtractionFolder.TabIndex = 11;
            // 
            // btn_ChooseExtractionFolder
            // 
            this.btn_ChooseExtractionFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChooseExtractionFolder.Location = new System.Drawing.Point(642, 175);
            this.btn_ChooseExtractionFolder.Name = "btn_ChooseExtractionFolder";
            this.btn_ChooseExtractionFolder.Size = new System.Drawing.Size(153, 23);
            this.btn_ChooseExtractionFolder.TabIndex = 10;
            this.btn_ChooseExtractionFolder.Text = "Choose Extraction Folder";
            this.btn_ChooseExtractionFolder.UseVisualStyleBackColor = true;
            this.btn_ChooseExtractionFolder.Click += new System.EventHandler(this.btn_ChooseExtractionFolder_Click);
            // 
            // btn_ChooseZipFile
            // 
            this.btn_ChooseZipFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChooseZipFile.Location = new System.Drawing.Point(525, 175);
            this.btn_ChooseZipFile.Name = "btn_ChooseZipFile";
            this.btn_ChooseZipFile.Size = new System.Drawing.Size(111, 23);
            this.btn_ChooseZipFile.TabIndex = 11;
            this.btn_ChooseZipFile.Text = "Choose Zip File";
            this.btn_ChooseZipFile.UseVisualStyleBackColor = true;
            this.btn_ChooseZipFile.Click += new System.EventHandler(this.btn_ChooseZipFile_Click);
            // 
            // MainFom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 210);
            this.Controls.Add(this.btn_ChooseZipFile);
            this.Controls.Add(this.btn_ChooseExtractionFolder);
            this.Controls.Add(this.btn_Extract);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainFom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extract File with ProgressBar Demo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar_Total;
        private System.Windows.Forms.TextBox textBox_ExtractFile;
        private System.Windows.Forms.ProgressBar progressBar_Individual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox_FilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Extract;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ExtractionFolder;
        private System.Windows.Forms.Button btn_ChooseExtractionFolder;
        private System.Windows.Forms.Button btn_ChooseZipFile;
    }
}

