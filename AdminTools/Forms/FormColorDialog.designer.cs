namespace AdminTools.Forms
{
    partial class FormColorDialog
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblHex = new System.Windows.Forms.Label();
            this.pbxRed = new System.Windows.Forms.PictureBox();
            this.pbxGreen = new System.Windows.Forms.PictureBox();
            this.pbxBlue = new System.Windows.Forms.PictureBox();
            this.pbxColor = new System.Windows.Forms.PictureBox();
            this.tbxHex = new System.Windows.Forms.TextBox();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.trbRed = new System.Windows.Forms.TrackBar();
            this.lblBlue = new System.Windows.Forms.Label();
            this.trbGreen = new System.Windows.Forms.TrackBar();
            this.lblGreen = new System.Windows.Forms.Label();
            this.trbAlpha = new System.Windows.Forms.TrackBar();
            this.lblRed = new System.Windows.Forms.Label();
            this.trbBlue = new System.Windows.Forms.TrackBar();
            this.tbxRed = new System.Windows.Forms.TextBox();
            this.tbxBlue = new System.Windows.Forms.TextBox();
            this.tbxGreen = new System.Windows.Forms.TextBox();
            this.tbxAlpha = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbxGreenFloat = new System.Windows.Forms.TextBox();
            this.tbxBlueFloat = new System.Windows.Forms.TextBox();
            this.tbxRedFloat = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvwPalette = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pbxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(216, 194);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 28);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(302, 194);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 28);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblHex
            // 
            this.lblHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHex.AutoSize = true;
            this.lblHex.Location = new System.Drawing.Point(286, 129);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(14, 13);
            this.lblHex.TabIndex = 31;
            this.lblHex.Text = "#";
            // 
            // pbxRed
            // 
            this.pbxRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxRed.Location = new System.Drawing.Point(252, 5);
            this.pbxRed.Name = "pbxRed";
            this.pbxRed.Size = new System.Drawing.Size(24, 20);
            this.pbxRed.TabIndex = 30;
            this.pbxRed.TabStop = false;
            // 
            // pbxGreen
            // 
            this.pbxGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxGreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxGreen.Location = new System.Drawing.Point(252, 31);
            this.pbxGreen.Name = "pbxGreen";
            this.pbxGreen.Size = new System.Drawing.Size(24, 20);
            this.pbxGreen.TabIndex = 29;
            this.pbxGreen.TabStop = false;
            // 
            // pbxBlue
            // 
            this.pbxBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxBlue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxBlue.Location = new System.Drawing.Point(252, 57);
            this.pbxBlue.Name = "pbxBlue";
            this.pbxBlue.Size = new System.Drawing.Size(24, 20);
            this.pbxBlue.TabIndex = 28;
            this.pbxBlue.TabStop = false;
            // 
            // pbxColor
            // 
            this.pbxColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxColor.Location = new System.Drawing.Point(6, 6);
            this.pbxColor.Name = "pbxColor";
            this.pbxColor.Size = new System.Drawing.Size(57, 136);
            this.pbxColor.TabIndex = 15;
            this.pbxColor.TabStop = false;
            this.pbxColor.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxColor_Paint);
            // 
            // tbxHex
            // 
            this.tbxHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHex.Location = new System.Drawing.Point(306, 126);
            this.tbxHex.Name = "tbxHex";
            this.tbxHex.Size = new System.Drawing.Size(65, 20);
            this.tbxHex.TabIndex = 23;
            this.tbxHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxHex.TextChanged += new System.EventHandler(this.tbxHex_TextChanged);
            // 
            // lblAlpha
            // 
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Location = new System.Drawing.Point(74, 92);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(14, 13);
            this.lblAlpha.TabIndex = 26;
            this.lblAlpha.Text = "A";
            // 
            // trbRed
            // 
            this.trbRed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trbRed.AutoSize = false;
            this.trbRed.Location = new System.Drawing.Point(95, 6);
            this.trbRed.Maximum = 255;
            this.trbRed.Name = "trbRed";
            this.trbRed.Size = new System.Drawing.Size(152, 20);
            this.trbRed.TabIndex = 13;
            this.trbRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbRed.Scroll += new System.EventHandler(this.trbRed_Scroll);
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(74, 60);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(14, 13);
            this.lblBlue.TabIndex = 25;
            this.lblBlue.Text = "B";
            // 
            // trbGreen
            // 
            this.trbGreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trbGreen.AutoSize = false;
            this.trbGreen.Location = new System.Drawing.Point(95, 32);
            this.trbGreen.Maximum = 255;
            this.trbGreen.Name = "trbGreen";
            this.trbGreen.Size = new System.Drawing.Size(152, 20);
            this.trbGreen.TabIndex = 16;
            this.trbGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbGreen.Scroll += new System.EventHandler(this.trbGreen_Scroll);
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(74, 34);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(15, 13);
            this.lblGreen.TabIndex = 27;
            this.lblGreen.Text = "G";
            // 
            // trbAlpha
            // 
            this.trbAlpha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trbAlpha.AutoSize = false;
            this.trbAlpha.Location = new System.Drawing.Point(95, 90);
            this.trbAlpha.Maximum = 255;
            this.trbAlpha.Name = "trbAlpha";
            this.trbAlpha.Size = new System.Drawing.Size(199, 20);
            this.trbAlpha.TabIndex = 20;
            this.trbAlpha.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbAlpha.Scroll += new System.EventHandler(this.trbAlpha_Scroll);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(74, 8);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(15, 13);
            this.lblRed.TabIndex = 24;
            this.lblRed.Text = "R";
            // 
            // trbBlue
            // 
            this.trbBlue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trbBlue.AutoSize = false;
            this.trbBlue.Location = new System.Drawing.Point(94, 57);
            this.trbBlue.Maximum = 255;
            this.trbBlue.Name = "trbBlue";
            this.trbBlue.Size = new System.Drawing.Size(152, 20);
            this.trbBlue.TabIndex = 18;
            this.trbBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbBlue.Scroll += new System.EventHandler(this.trbBlue_Scroll);
            // 
            // tbxRed
            // 
            this.tbxRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRed.Location = new System.Drawing.Point(282, 5);
            this.tbxRed.Name = "tbxRed";
            this.tbxRed.Size = new System.Drawing.Size(42, 20);
            this.tbxRed.TabIndex = 14;
            this.tbxRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxRed.TextChanged += new System.EventHandler(this.tbxRed_TextChanged);
            // 
            // tbxBlue
            // 
            this.tbxBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxBlue.Location = new System.Drawing.Point(282, 57);
            this.tbxBlue.Name = "tbxBlue";
            this.tbxBlue.Size = new System.Drawing.Size(42, 20);
            this.tbxBlue.TabIndex = 19;
            this.tbxBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxBlue.TextChanged += new System.EventHandler(this.tbxBlue_TextChanged);
            // 
            // tbxGreen
            // 
            this.tbxGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxGreen.Location = new System.Drawing.Point(282, 31);
            this.tbxGreen.Name = "tbxGreen";
            this.tbxGreen.Size = new System.Drawing.Size(42, 20);
            this.tbxGreen.TabIndex = 17;
            this.tbxGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxGreen.TextChanged += new System.EventHandler(this.tbxGreen_TextChanged);
            // 
            // tbxAlpha
            // 
            this.tbxAlpha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAlpha.Location = new System.Drawing.Point(306, 90);
            this.tbxAlpha.Name = "tbxAlpha";
            this.tbxAlpha.Size = new System.Drawing.Size(65, 20);
            this.tbxAlpha.TabIndex = 22;
            this.tbxAlpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxAlpha.TextChanged += new System.EventHandler(this.tbxAlpha_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(385, 178);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.pbxColor);
            this.tabPage1.Controls.Add(this.lblHex);
            this.tabPage1.Controls.Add(this.tbxAlpha);
            this.tabPage1.Controls.Add(this.pbxRed);
            this.tabPage1.Controls.Add(this.tbxGreenFloat);
            this.tabPage1.Controls.Add(this.tbxGreen);
            this.tabPage1.Controls.Add(this.pbxGreen);
            this.tabPage1.Controls.Add(this.tbxBlueFloat);
            this.tabPage1.Controls.Add(this.tbxBlue);
            this.tabPage1.Controls.Add(this.pbxBlue);
            this.tabPage1.Controls.Add(this.tbxRedFloat);
            this.tabPage1.Controls.Add(this.tbxRed);
            this.tabPage1.Controls.Add(this.trbBlue);
            this.tabPage1.Controls.Add(this.tbxHex);
            this.tabPage1.Controls.Add(this.lblRed);
            this.tabPage1.Controls.Add(this.lblAlpha);
            this.tabPage1.Controls.Add(this.trbAlpha);
            this.tabPage1.Controls.Add(this.trbRed);
            this.tabPage1.Controls.Add(this.lblGreen);
            this.tabPage1.Controls.Add(this.lblBlue);
            this.tabPage1.Controls.Add(this.trbGreen);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(377, 152);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mixer";
            // 
            // tbxGreenFloat
            // 
            this.tbxGreenFloat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxGreenFloat.Location = new System.Drawing.Point(330, 31);
            this.tbxGreenFloat.Name = "tbxGreenFloat";
            this.tbxGreenFloat.ReadOnly = true;
            this.tbxGreenFloat.Size = new System.Drawing.Size(41, 20);
            this.tbxGreenFloat.TabIndex = 17;
            this.tbxGreenFloat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxGreenFloat.TextChanged += new System.EventHandler(this.tbxGreen_TextChanged);
            // 
            // tbxBlueFloat
            // 
            this.tbxBlueFloat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxBlueFloat.Location = new System.Drawing.Point(330, 57);
            this.tbxBlueFloat.Name = "tbxBlueFloat";
            this.tbxBlueFloat.ReadOnly = true;
            this.tbxBlueFloat.Size = new System.Drawing.Size(41, 20);
            this.tbxBlueFloat.TabIndex = 19;
            this.tbxBlueFloat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxBlueFloat.TextChanged += new System.EventHandler(this.tbxBlue_TextChanged);
            // 
            // tbxRedFloat
            // 
            this.tbxRedFloat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRedFloat.Location = new System.Drawing.Point(330, 5);
            this.tbxRedFloat.Name = "tbxRedFloat";
            this.tbxRedFloat.ReadOnly = true;
            this.tbxRedFloat.Size = new System.Drawing.Size(41, 20);
            this.tbxRedFloat.TabIndex = 14;
            this.tbxRedFloat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxRedFloat.TextChanged += new System.EventHandler(this.tbxRed_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvwPalette);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(377, 152);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Farbpalette";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvwPalette
            // 
            this.lvwPalette.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwPalette.FullRowSelect = true;
            this.lvwPalette.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwPalette.Location = new System.Drawing.Point(3, 3);
            this.lvwPalette.Name = "lvwPalette";
            this.lvwPalette.Size = new System.Drawing.Size(371, 146);
            this.lvwPalette.TabIndex = 1;
            this.lvwPalette.UseCompatibleStateImageBehavior = false;
            this.lvwPalette.View = System.Windows.Forms.View.Details;
            this.lvwPalette.SelectedIndexChanged += new System.EventHandler(this.lvwPalette_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "RGB";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Farbe";
            this.columnHeader2.Width = 220;
            // 
            // FormColorDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(394, 234);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(410, 270);
            this.Name = "FormColorDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Farbe auswählen";
            ((System.ComponentModel.ISupportInitialize)(this.pbxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.PictureBox pbxRed;
        private System.Windows.Forms.PictureBox pbxGreen;
        private System.Windows.Forms.PictureBox pbxBlue;
        private System.Windows.Forms.PictureBox pbxColor;
        private System.Windows.Forms.TextBox tbxHex;
        private System.Windows.Forms.Label lblAlpha;
        private System.Windows.Forms.TrackBar trbRed;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.TrackBar trbGreen;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.TrackBar trbAlpha;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.TrackBar trbBlue;
        private System.Windows.Forms.TextBox tbxRed;
        private System.Windows.Forms.TextBox tbxBlue;
        private System.Windows.Forms.TextBox tbxGreen;
        private System.Windows.Forms.TextBox tbxAlpha;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lvwPalette;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox tbxGreenFloat;
        private System.Windows.Forms.TextBox tbxBlueFloat;
        private System.Windows.Forms.TextBox tbxRedFloat;
    }
}