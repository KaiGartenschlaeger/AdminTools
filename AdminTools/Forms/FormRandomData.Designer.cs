namespace AdminTools.Forms
{
    partial class FormRandomData
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbUpperChars = new System.Windows.Forms.CheckBox();
            this.chbLowerChars = new System.Windows.Forms.CheckBox();
            this.chbNumbers = new System.Windows.Forms.CheckBox();
            this.tbxMiscCharacters = new System.Windows.Forms.TextBox();
            this.chbMiscCharacters = new System.Windows.Forms.CheckBox();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.nudMinLength = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudMaxLength = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudResultCount = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinLength)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResultCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(400, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(80, 28);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "&Generieren";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbMiscCharacters);
            this.groupBox1.Controls.Add(this.tbxMiscCharacters);
            this.groupBox1.Controls.Add(this.chbNumbers);
            this.groupBox1.Controls.Add(this.chbLowerChars);
            this.groupBox1.Controls.Add(this.chbUpperChars);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 171);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mögliche Zeichen";
            // 
            // chbUpperChars
            // 
            this.chbUpperChars.AutoSize = true;
            this.chbUpperChars.Checked = true;
            this.chbUpperChars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbUpperChars.Location = new System.Drawing.Point(14, 27);
            this.chbUpperChars.Name = "chbUpperChars";
            this.chbUpperChars.Size = new System.Drawing.Size(105, 17);
            this.chbUpperChars.TabIndex = 2;
            this.chbUpperChars.Text = "Großbuchstaben";
            this.chbUpperChars.UseVisualStyleBackColor = true;
            // 
            // chbLowerChars
            // 
            this.chbLowerChars.AutoSize = true;
            this.chbLowerChars.Checked = true;
            this.chbLowerChars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLowerChars.Location = new System.Drawing.Point(14, 50);
            this.chbLowerChars.Name = "chbLowerChars";
            this.chbLowerChars.Size = new System.Drawing.Size(105, 17);
            this.chbLowerChars.TabIndex = 2;
            this.chbLowerChars.Text = "Kleinbuchstaben";
            this.chbLowerChars.UseVisualStyleBackColor = true;
            // 
            // chbNumbers
            // 
            this.chbNumbers.AutoSize = true;
            this.chbNumbers.Checked = true;
            this.chbNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbNumbers.Location = new System.Drawing.Point(14, 81);
            this.chbNumbers.Name = "chbNumbers";
            this.chbNumbers.Size = new System.Drawing.Size(59, 17);
            this.chbNumbers.TabIndex = 2;
            this.chbNumbers.Text = "Zahlen";
            this.chbNumbers.UseVisualStyleBackColor = true;
            // 
            // tbxMiscCharacters
            // 
            this.tbxMiscCharacters.Location = new System.Drawing.Point(14, 132);
            this.tbxMiscCharacters.Name = "tbxMiscCharacters";
            this.tbxMiscCharacters.Size = new System.Drawing.Size(141, 20);
            this.tbxMiscCharacters.TabIndex = 2;
            this.tbxMiscCharacters.Text = "#$/&%!?";
            // 
            // chbMiscCharacters
            // 
            this.chbMiscCharacters.AutoSize = true;
            this.chbMiscCharacters.Location = new System.Drawing.Point(14, 112);
            this.chbMiscCharacters.Name = "chbMiscCharacters";
            this.chbMiscCharacters.Size = new System.Drawing.Size(97, 17);
            this.chbMiscCharacters.TabIndex = 2;
            this.chbMiscCharacters.Text = "Sonderzeichen";
            this.chbMiscCharacters.UseVisualStyleBackColor = true;
            // 
            // tbxOutput
            // 
            this.tbxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOutput.Location = new System.Drawing.Point(12, 212);
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.ReadOnly = true;
            this.tbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxOutput.Size = new System.Drawing.Size(468, 96);
            this.tbxOutput.TabIndex = 2;
            // 
            // nudMinLength
            // 
            this.nudMinLength.Location = new System.Drawing.Point(17, 43);
            this.nudMinLength.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudMinLength.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudMinLength.Name = "nudMinLength";
            this.nudMinLength.Size = new System.Drawing.Size(59, 20);
            this.nudMinLength.TabIndex = 3;
            this.nudMinLength.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudResultCount);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nudMinLength);
            this.groupBox2.Controls.Add(this.nudMaxLength);
            this.groupBox2.Location = new System.Drawing.Point(188, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 124);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weiteres";
            // 
            // nudMaxLength
            // 
            this.nudMaxLength.Location = new System.Drawing.Point(82, 43);
            this.nudMaxLength.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudMaxLength.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMaxLength.Name = "nudMaxLength";
            this.nudMaxLength.Size = new System.Drawing.Size(59, 20);
            this.nudMaxLength.TabIndex = 3;
            this.nudMaxLength.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Anzahl an Zeichen(von / bis)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Anzahl an Zeilen";
            // 
            // nudResultCount
            // 
            this.nudResultCount.Location = new System.Drawing.Point(17, 90);
            this.nudResultCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudResultCount.Name = "nudResultCount";
            this.nudResultCount.Size = new System.Drawing.Size(59, 20);
            this.nudResultCount.TabIndex = 7;
            this.nudResultCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // FormRandomData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 320);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(508, 356);
            this.Name = "FormRandomData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Zufallsdaten";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinLength)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResultCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbMiscCharacters;
        private System.Windows.Forms.TextBox tbxMiscCharacters;
        private System.Windows.Forms.CheckBox chbNumbers;
        private System.Windows.Forms.CheckBox chbLowerChars;
        private System.Windows.Forms.CheckBox chbUpperChars;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.NumericUpDown nudMinLength;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudResultCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMaxLength;
    }
}