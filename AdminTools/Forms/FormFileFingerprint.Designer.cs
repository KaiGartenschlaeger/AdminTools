namespace AdminTools.Forms
{
    partial class FormFileFingerprint
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
            this.lblFile = new System.Windows.Forms.Label();
            this.ptbFile = new ExtendedControls.PathControl();
            this.btnCopyMD5 = new System.Windows.Forms.Button();
            this.lblMD5Value = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCopySHA1 = new System.Windows.Forms.Button();
            this.lblSHA1Value = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(9, 9);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(32, 13);
            this.lblFile.TabIndex = 1;
            this.lblFile.Text = "Datei";
            // 
            // ptbFile
            // 
            this.ptbFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbFile.CheckIfFileExists = false;
            this.ptbFile.ChooseButtonEnabled = true;
            this.ptbFile.DefaultDirectory = "C:\\";
            this.ptbFile.DirectoryOnly = false;
            this.ptbFile.FileFilter = "Alle Dateien|*.*";
            this.ptbFile.InitialPath = "C:\\Program Files (x86)\\Microsoft Visual Studio 12.0\\Common7\\IDE";
            this.ptbFile.Location = new System.Drawing.Point(12, 25);
            this.ptbFile.Name = "ptbFile";
            this.ptbFile.SelectedPath = "";
            this.ptbFile.Size = new System.Drawing.Size(410, 20);
            this.ptbFile.TabIndex = 2;
            this.ptbFile.TextBoxFolderchange = false;
            this.ptbFile.PathChanged += new System.EventHandler<ExtendedControls.PathChangedEventArgs>(this.ptbFile_PathChanged);
            // 
            // btnCopyMD5
            // 
            this.btnCopyMD5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyMD5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopyMD5.Location = new System.Drawing.Point(367, 68);
            this.btnCopyMD5.Name = "btnCopyMD5";
            this.btnCopyMD5.Size = new System.Drawing.Size(55, 24);
            this.btnCopyMD5.TabIndex = 3;
            this.btnCopyMD5.Text = "Copy";
            this.btnCopyMD5.UseVisualStyleBackColor = true;
            this.btnCopyMD5.Click += new System.EventHandler(this.btnCopyMD5_Click);
            // 
            // lblMD5Value
            // 
            this.lblMD5Value.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMD5Value.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMD5Value.Location = new System.Drawing.Point(56, 69);
            this.lblMD5Value.Name = "lblMD5Value";
            this.lblMD5Value.Size = new System.Drawing.Size(305, 23);
            this.lblMD5Value.TabIndex = 4;
            this.lblMD5Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "MD5";
            // 
            // btnCopySHA1
            // 
            this.btnCopySHA1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopySHA1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopySHA1.Location = new System.Drawing.Point(367, 98);
            this.btnCopySHA1.Name = "btnCopySHA1";
            this.btnCopySHA1.Size = new System.Drawing.Size(55, 24);
            this.btnCopySHA1.TabIndex = 3;
            this.btnCopySHA1.Text = "Copy";
            this.btnCopySHA1.UseVisualStyleBackColor = true;
            this.btnCopySHA1.Click += new System.EventHandler(this.btnCopySHA1_Click);
            // 
            // lblSHA1Value
            // 
            this.lblSHA1Value.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSHA1Value.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSHA1Value.Location = new System.Drawing.Point(56, 99);
            this.lblSHA1Value.Name = "lblSHA1Value";
            this.lblSHA1Value.Size = new System.Drawing.Size(305, 23);
            this.lblSHA1Value.TabIndex = 4;
            this.lblSHA1Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "SHA1";
            // 
            // FormFileFingerprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 134);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSHA1Value);
            this.Controls.Add(this.btnCopySHA1);
            this.Controls.Add(this.lblMD5Value);
            this.Controls.Add(this.btnCopyMD5);
            this.Controls.Add(this.ptbFile);
            this.Controls.Add(this.lblFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFileFingerprint";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File-Fingerprint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFile;
        private ExtendedControls.PathControl ptbFile;
        private System.Windows.Forms.Button btnCopyMD5;
        private System.Windows.Forms.Label lblMD5Value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCopySHA1;
        private System.Windows.Forms.Label lblSHA1Value;
        private System.Windows.Forms.Label label3;
    }
}