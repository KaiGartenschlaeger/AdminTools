namespace AdminTools.Forms
{
    partial class FormDummyFile
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pathFilepath = new ExtendedControls.PathControl();
            this.label2 = new System.Windows.Forms.Label();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.rbnByte = new System.Windows.Forms.RadioButton();
            this.rbnKilobyte = new System.Windows.Forms.RadioButton();
            this.rbnMegabyte = new System.Windows.Forms.RadioButton();
            this.rbnGigabyte = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(197, 205);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(80, 28);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Erstellen";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(283, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 28);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pathFilepath
            // 
            this.pathFilepath.AutoSize = true;
            this.pathFilepath.CheckIfFileExists = false;
            this.pathFilepath.ChooseButtonEnabled = true;
            this.pathFilepath.DefaultDirectory = null;
            this.pathFilepath.DirectoryOnly = false;
            this.pathFilepath.FileFilter = "Data|*.dat|Alle Dateien|*.*";
            this.pathFilepath.InitialPath = "C:\\Program Files (x86)\\Microsoft Visual Studio 12.0\\Common7\\IDE";
            this.pathFilepath.Location = new System.Drawing.Point(15, 25);
            this.pathFilepath.Name = "pathFilepath";
            this.pathFilepath.SelectedPath = "";
            this.pathFilepath.Size = new System.Drawing.Size(339, 20);
            this.pathFilepath.TabIndex = 1;
            this.pathFilepath.TextBoxFolderchange = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pfad";
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(221, 24);
            this.nudSize.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(114, 20);
            this.nudSize.TabIndex = 4;
            this.nudSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // rbnByte
            // 
            this.rbnByte.AutoSize = true;
            this.rbnByte.Location = new System.Drawing.Point(16, 24);
            this.rbnByte.Name = "rbnByte";
            this.rbnByte.Size = new System.Drawing.Size(46, 17);
            this.rbnByte.TabIndex = 5;
            this.rbnByte.Text = "Byte";
            this.rbnByte.UseVisualStyleBackColor = true;
            // 
            // rbnKilobyte
            // 
            this.rbnKilobyte.AutoSize = true;
            this.rbnKilobyte.Location = new System.Drawing.Point(16, 47);
            this.rbnKilobyte.Name = "rbnKilobyte";
            this.rbnKilobyte.Size = new System.Drawing.Size(65, 17);
            this.rbnKilobyte.TabIndex = 5;
            this.rbnKilobyte.Text = "Kilo byte";
            this.rbnKilobyte.UseVisualStyleBackColor = true;
            // 
            // rbnMegabyte
            // 
            this.rbnMegabyte.AutoSize = true;
            this.rbnMegabyte.Checked = true;
            this.rbnMegabyte.Location = new System.Drawing.Point(16, 70);
            this.rbnMegabyte.Name = "rbnMegabyte";
            this.rbnMegabyte.Size = new System.Drawing.Size(75, 17);
            this.rbnMegabyte.TabIndex = 5;
            this.rbnMegabyte.TabStop = true;
            this.rbnMegabyte.Text = "Mega byte";
            this.rbnMegabyte.UseVisualStyleBackColor = true;
            // 
            // rbnGigabyte
            // 
            this.rbnGigabyte.AutoSize = true;
            this.rbnGigabyte.Location = new System.Drawing.Point(16, 93);
            this.rbnGigabyte.Name = "rbnGigabyte";
            this.rbnGigabyte.Size = new System.Drawing.Size(70, 17);
            this.rbnGigabyte.TabIndex = 5;
            this.rbnGigabyte.Text = "Giga byte";
            this.rbnGigabyte.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnByte);
            this.groupBox1.Controls.Add(this.nudSize);
            this.groupBox1.Controls.Add(this.rbnGigabyte);
            this.groupBox1.Controls.Add(this.rbnKilobyte);
            this.groupBox1.Controls.Add(this.rbnMegabyte);
            this.groupBox1.Location = new System.Drawing.Point(15, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 125);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Größe";
            // 
            // FormDummyFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 245);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pathFilepath);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDummyFile";
            this.ShowIcon = false;
            this.Text = "Dummy File Creator";
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private ExtendedControls.PathControl pathFilepath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.RadioButton rbnByte;
        private System.Windows.Forms.RadioButton rbnKilobyte;
        private System.Windows.Forms.RadioButton rbnMegabyte;
        private System.Windows.Forms.RadioButton rbnGigabyte;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}