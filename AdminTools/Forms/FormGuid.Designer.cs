namespace AdminTools.Forms
{
    partial class FormGuid
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
            this.btnCopy = new System.Windows.Forms.Button();
            this.lblGuid = new System.Windows.Forms.Label();
            this.chbUpperCharacters = new System.Windows.Forms.CheckBox();
            this.chbRemoveMinus = new System.Windows.Forms.CheckBox();
            this.chbCurlyBraces = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(283, 98);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(80, 28);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "&Erzeugen";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(197, 98);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(80, 28);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "&Kopieren";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblGuid
            // 
            this.lblGuid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGuid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGuid.Location = new System.Drawing.Point(12, 9);
            this.lblGuid.Name = "lblGuid";
            this.lblGuid.Padding = new System.Windows.Forms.Padding(2);
            this.lblGuid.Size = new System.Drawing.Size(351, 22);
            this.lblGuid.TabIndex = 1;
            this.lblGuid.Text = "label1";
            this.lblGuid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chbUpperCharacters
            // 
            this.chbUpperCharacters.AutoSize = true;
            this.chbUpperCharacters.Location = new System.Drawing.Point(12, 39);
            this.chbUpperCharacters.Name = "chbUpperCharacters";
            this.chbUpperCharacters.Size = new System.Drawing.Size(105, 17);
            this.chbUpperCharacters.TabIndex = 2;
            this.chbUpperCharacters.Text = "Großbuchstaben";
            this.chbUpperCharacters.UseVisualStyleBackColor = true;
            this.chbUpperCharacters.CheckedChanged += new System.EventHandler(this.chbUpperCharacters_CheckedChanged);
            // 
            // chbRemoveMinus
            // 
            this.chbRemoveMinus.AutoSize = true;
            this.chbRemoveMinus.Checked = true;
            this.chbRemoveMinus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbRemoveMinus.Location = new System.Drawing.Point(12, 61);
            this.chbRemoveMinus.Name = "chbRemoveMinus";
            this.chbRemoveMinus.Size = new System.Drawing.Size(144, 17);
            this.chbRemoveMinus.TabIndex = 3;
            this.chbRemoveMinus.Text = "Minus-Zeichen entfernen";
            this.chbRemoveMinus.UseVisualStyleBackColor = true;
            this.chbRemoveMinus.CheckedChanged += new System.EventHandler(this.chbRemoveMinus_CheckedChanged);
            // 
            // chbCurlyBraces
            // 
            this.chbCurlyBraces.AutoSize = true;
            this.chbCurlyBraces.Location = new System.Drawing.Point(193, 39);
            this.chbCurlyBraces.Name = "chbCurlyBraces";
            this.chbCurlyBraces.Size = new System.Drawing.Size(134, 17);
            this.chbCurlyBraces.TabIndex = 4;
            this.chbCurlyBraces.Text = "Geschweifte Klammern";
            this.chbCurlyBraces.UseVisualStyleBackColor = true;
            this.chbCurlyBraces.CheckedChanged += new System.EventHandler(this.chbCurlyBraces_CheckedChanged);
            // 
            // FormGuid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 138);
            this.Controls.Add(this.chbCurlyBraces);
            this.Controls.Add(this.chbRemoveMinus);
            this.Controls.Add(this.chbUpperCharacters);
            this.Controls.Add(this.lblGuid);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormGuid";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Guid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lblGuid;
        private System.Windows.Forms.CheckBox chbUpperCharacters;
        private System.Windows.Forms.CheckBox chbRemoveMinus;
        private System.Windows.Forms.CheckBox chbCurlyBraces;
    }
}