namespace AdminTools.Forms
{
    partial class FormFilecompare
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
            this.tbxFilepath1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChooseFile1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChooseFile2 = new System.Windows.Forms.Button();
            this.tbxFilepath2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxFilepath1
            // 
            this.tbxFilepath1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxFilepath1.Location = new System.Drawing.Point(14, 26);
            this.tbxFilepath1.Name = "tbxFilepath1";
            this.tbxFilepath1.ReadOnly = true;
            this.tbxFilepath1.Size = new System.Drawing.Size(277, 20);
            this.tbxFilepath1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChooseFile1);
            this.groupBox1.Controls.Add(this.tbxFilepath1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 61);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "First file";
            // 
            // btnChooseFile1
            // 
            this.btnChooseFile1.Location = new System.Drawing.Point(297, 25);
            this.btnChooseFile1.Name = "btnChooseFile1";
            this.btnChooseFile1.Size = new System.Drawing.Size(35, 20);
            this.btnChooseFile1.TabIndex = 2;
            this.btnChooseFile1.Text = "...";
            this.btnChooseFile1.UseVisualStyleBackColor = true;
            this.btnChooseFile1.Click += new System.EventHandler(this.btnChooseFile1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChooseFile2);
            this.groupBox2.Controls.Add(this.tbxFilepath2);
            this.groupBox2.Location = new System.Drawing.Point(12, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 61);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "First file";
            // 
            // btnChooseFile2
            // 
            this.btnChooseFile2.Location = new System.Drawing.Point(297, 25);
            this.btnChooseFile2.Name = "btnChooseFile2";
            this.btnChooseFile2.Size = new System.Drawing.Size(35, 20);
            this.btnChooseFile2.TabIndex = 2;
            this.btnChooseFile2.Text = "...";
            this.btnChooseFile2.UseVisualStyleBackColor = true;
            this.btnChooseFile2.Click += new System.EventHandler(this.btnChooseFile2_Click);
            // 
            // tbxFilepath2
            // 
            this.tbxFilepath2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxFilepath2.Location = new System.Drawing.Point(14, 26);
            this.tbxFilepath2.Name = "tbxFilepath2";
            this.tbxFilepath2.ReadOnly = true;
            this.tbxFilepath2.Size = new System.Drawing.Size(277, 20);
            this.tbxFilepath2.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.Location = new System.Drawing.Point(12, 193);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(350, 83);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Results";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(286, 153);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 4;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // FormFilecompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 288);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFilecompare";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "File compare";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxFilepath1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChooseFile1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChooseFile2;
        private System.Windows.Forms.TextBox tbxFilepath2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCompare;
    }
}