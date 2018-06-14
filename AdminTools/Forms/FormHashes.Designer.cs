namespace AdminTools.Forms
{
    partial class FormHashes
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMD5Value = new System.Windows.Forms.Label();
            this.btnCopyMD5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSHA1 = new System.Windows.Forms.Label();
            this.btnCopySHA1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCRC32Value = new System.Windows.Forms.Label();
            this.btnCopyCRC32 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value";
            // 
            // tbxValue
            // 
            this.tbxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxValue.Location = new System.Drawing.Point(12, 25);
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.Size = new System.Drawing.Size(386, 20);
            this.tbxValue.TabIndex = 1;
            this.tbxValue.TextChanged += new System.EventHandler(this.tbxValue_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MD5";
            // 
            // lblMD5Value
            // 
            this.lblMD5Value.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMD5Value.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMD5Value.Location = new System.Drawing.Point(64, 74);
            this.lblMD5Value.Name = "lblMD5Value";
            this.lblMD5Value.Size = new System.Drawing.Size(267, 24);
            this.lblMD5Value.TabIndex = 3;
            this.lblMD5Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCopyMD5
            // 
            this.btnCopyMD5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyMD5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopyMD5.Location = new System.Drawing.Point(337, 74);
            this.btnCopyMD5.Name = "btnCopyMD5";
            this.btnCopyMD5.Size = new System.Drawing.Size(61, 24);
            this.btnCopyMD5.TabIndex = 4;
            this.btnCopyMD5.Text = "Copy";
            this.btnCopyMD5.UseVisualStyleBackColor = true;
            this.btnCopyMD5.Click += new System.EventHandler(this.btnCopyMD5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SHA1";
            // 
            // lblSHA1
            // 
            this.lblSHA1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSHA1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSHA1.Location = new System.Drawing.Point(64, 101);
            this.lblSHA1.Name = "lblSHA1";
            this.lblSHA1.Size = new System.Drawing.Size(267, 24);
            this.lblSHA1.TabIndex = 3;
            this.lblSHA1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCopySHA1
            // 
            this.btnCopySHA1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopySHA1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopySHA1.Location = new System.Drawing.Point(337, 101);
            this.btnCopySHA1.Name = "btnCopySHA1";
            this.btnCopySHA1.Size = new System.Drawing.Size(61, 24);
            this.btnCopySHA1.TabIndex = 4;
            this.btnCopySHA1.Text = "Copy";
            this.btnCopySHA1.UseVisualStyleBackColor = true;
            this.btnCopySHA1.Click += new System.EventHandler(this.btnCopySHA1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "CRC32";
            // 
            // lblCRC32Value
            // 
            this.lblCRC32Value.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCRC32Value.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCRC32Value.Location = new System.Drawing.Point(64, 128);
            this.lblCRC32Value.Name = "lblCRC32Value";
            this.lblCRC32Value.Size = new System.Drawing.Size(267, 24);
            this.lblCRC32Value.TabIndex = 3;
            this.lblCRC32Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCopyCRC32
            // 
            this.btnCopyCRC32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyCRC32.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopyCRC32.Location = new System.Drawing.Point(337, 128);
            this.btnCopyCRC32.Name = "btnCopyCRC32";
            this.btnCopyCRC32.Size = new System.Drawing.Size(61, 24);
            this.btnCopyCRC32.TabIndex = 4;
            this.btnCopyCRC32.Text = "Copy";
            this.btnCopyCRC32.UseVisualStyleBackColor = true;
            this.btnCopyCRC32.Click += new System.EventHandler(this.btnCopyCRC32_Click);
            // 
            // FormHashes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 165);
            this.Controls.Add(this.btnCopyCRC32);
            this.Controls.Add(this.btnCopySHA1);
            this.Controls.Add(this.btnCopyMD5);
            this.Controls.Add(this.lblCRC32Value);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSHA1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMD5Value);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxValue);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHashes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hashes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMD5Value;
        private System.Windows.Forms.Button btnCopyMD5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSHA1;
        private System.Windows.Forms.Button btnCopySHA1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCRC32Value;
        private System.Windows.Forms.Button btnCopyCRC32;
    }
}