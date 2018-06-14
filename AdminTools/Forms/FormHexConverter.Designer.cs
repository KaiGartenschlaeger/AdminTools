namespace AdminTools.Forms
{
    partial class FormHexConverter
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
            this.lblValue = new System.Windows.Forms.Label();
            this.tbxValue = new System.Windows.Forms.TextBox();
            this.tbxHexValue = new System.Windows.Forms.TextBox();
            this.lblHexValue = new System.Windows.Forms.Label();
            this.rbnStringToHex = new System.Windows.Forms.RadioButton();
            this.rbnNumberToHex = new System.Windows.Forms.RadioButton();
            this.rbnHexToString = new System.Windows.Forms.RadioButton();
            this.rbnHexToNumber = new System.Windows.Forms.RadioButton();
            this.chbRemoveWhitespaces = new System.Windows.Forms.CheckBox();
            this.chbAddPrefix = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(9, 9);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(34, 13);
            this.lblValue.TabIndex = 0;
            this.lblValue.Text = "Value";
            // 
            // tbxValue
            // 
            this.tbxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxValue.Location = new System.Drawing.Point(12, 25);
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.Size = new System.Drawing.Size(304, 20);
            this.tbxValue.TabIndex = 1;
            this.tbxValue.TextChanged += new System.EventHandler(this.tbxValue_TextChanged);
            // 
            // tbxHexValue
            // 
            this.tbxHexValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHexValue.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHexValue.Location = new System.Drawing.Point(12, 159);
            this.tbxHexValue.Multiline = true;
            this.tbxHexValue.Name = "tbxHexValue";
            this.tbxHexValue.ReadOnly = true;
            this.tbxHexValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxHexValue.Size = new System.Drawing.Size(304, 101);
            this.tbxHexValue.TabIndex = 2;
            // 
            // lblHexValue
            // 
            this.lblHexValue.AutoSize = true;
            this.lblHexValue.Location = new System.Drawing.Point(9, 143);
            this.lblHexValue.Name = "lblHexValue";
            this.lblHexValue.Size = new System.Drawing.Size(37, 13);
            this.lblHexValue.TabIndex = 3;
            this.lblHexValue.Text = "Result";
            // 
            // rbnStringToHex
            // 
            this.rbnStringToHex.AutoSize = true;
            this.rbnStringToHex.Checked = true;
            this.rbnStringToHex.Location = new System.Drawing.Point(12, 56);
            this.rbnStringToHex.Name = "rbnStringToHex";
            this.rbnStringToHex.Size = new System.Drawing.Size(80, 17);
            this.rbnStringToHex.TabIndex = 4;
            this.rbnStringToHex.TabStop = true;
            this.rbnStringToHex.Text = "Text -> Hex";
            this.rbnStringToHex.UseVisualStyleBackColor = true;
            this.rbnStringToHex.CheckedChanged += new System.EventHandler(this.rbnString_CheckedChanged);
            // 
            // rbnNumberToHex
            // 
            this.rbnNumberToHex.AutoSize = true;
            this.rbnNumberToHex.Location = new System.Drawing.Point(110, 79);
            this.rbnNumberToHex.Name = "rbnNumberToHex";
            this.rbnNumberToHex.Size = new System.Drawing.Size(99, 17);
            this.rbnNumberToHex.TabIndex = 4;
            this.rbnNumberToHex.Text = "Number -> HEX";
            this.rbnNumberToHex.UseVisualStyleBackColor = true;
            this.rbnNumberToHex.CheckedChanged += new System.EventHandler(this.rbnNumber_CheckedChanged);
            // 
            // rbnHexToString
            // 
            this.rbnHexToString.AutoSize = true;
            this.rbnHexToString.Location = new System.Drawing.Point(12, 79);
            this.rbnHexToString.Name = "rbnHexToString";
            this.rbnHexToString.Size = new System.Drawing.Size(80, 17);
            this.rbnHexToString.TabIndex = 4;
            this.rbnHexToString.Text = "Hex to Text";
            this.rbnHexToString.UseVisualStyleBackColor = true;
            this.rbnHexToString.CheckedChanged += new System.EventHandler(this.rbnString_CheckedChanged);
            // 
            // rbnHexToNumber
            // 
            this.rbnHexToNumber.AutoSize = true;
            this.rbnHexToNumber.Location = new System.Drawing.Point(110, 56);
            this.rbnHexToNumber.Name = "rbnHexToNumber";
            this.rbnHexToNumber.Size = new System.Drawing.Size(99, 17);
            this.rbnHexToNumber.TabIndex = 4;
            this.rbnHexToNumber.Text = "HEX -> Number";
            this.rbnHexToNumber.UseVisualStyleBackColor = true;
            this.rbnHexToNumber.CheckedChanged += new System.EventHandler(this.rbnNumber_CheckedChanged);
            // 
            // chbRemoveWhitespaces
            // 
            this.chbRemoveWhitespaces.AutoSize = true;
            this.chbRemoveWhitespaces.Location = new System.Drawing.Point(83, 111);
            this.chbRemoveWhitespaces.Name = "chbRemoveWhitespaces";
            this.chbRemoveWhitespaces.Size = new System.Drawing.Size(128, 17);
            this.chbRemoveWhitespaces.TabIndex = 7;
            this.chbRemoveWhitespaces.Text = "Remove whitespaces";
            this.chbRemoveWhitespaces.UseVisualStyleBackColor = true;
            this.chbRemoveWhitespaces.CheckedChanged += new System.EventHandler(this.chbRemoveWhitespaces_CheckedChanged);
            // 
            // chbAddPrefix
            // 
            this.chbAddPrefix.AutoSize = true;
            this.chbAddPrefix.Location = new System.Drawing.Point(12, 111);
            this.chbAddPrefix.Name = "chbAddPrefix";
            this.chbAddPrefix.Size = new System.Drawing.Size(59, 17);
            this.chbAddPrefix.TabIndex = 8;
            this.chbAddPrefix.Text = "Add 0x";
            this.chbAddPrefix.UseVisualStyleBackColor = true;
            this.chbAddPrefix.CheckedChanged += new System.EventHandler(this.chbAddPrefix_CheckedChanged);
            // 
            // FormHexConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 272);
            this.Controls.Add(this.chbAddPrefix);
            this.Controls.Add(this.rbnStringToHex);
            this.Controls.Add(this.rbnHexToString);
            this.Controls.Add(this.rbnHexToNumber);
            this.Controls.Add(this.rbnNumberToHex);
            this.Controls.Add(this.chbRemoveWhitespaces);
            this.Controls.Add(this.lblHexValue);
            this.Controls.Add(this.tbxHexValue);
            this.Controls.Add(this.tbxValue);
            this.Controls.Add(this.lblValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHexConverter";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hexadezimal Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox tbxValue;
        private System.Windows.Forms.TextBox tbxHexValue;
        private System.Windows.Forms.Label lblHexValue;
        private System.Windows.Forms.RadioButton rbnStringToHex;
        private System.Windows.Forms.RadioButton rbnNumberToHex;
        private System.Windows.Forms.RadioButton rbnHexToString;
        private System.Windows.Forms.RadioButton rbnHexToNumber;
        private System.Windows.Forms.CheckBox chbRemoveWhitespaces;
        private System.Windows.Forms.CheckBox chbAddPrefix;
    }
}