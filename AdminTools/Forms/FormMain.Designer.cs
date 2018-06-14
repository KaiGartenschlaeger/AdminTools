namespace AdminTools.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ntiMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zeichenkettenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miHashgenerator = new System.Windows.Forms.ToolStripMenuItem();
            this.miHexgenerator = new System.Windows.Forms.ToolStripMenuItem();
            this.mniBinConverter = new System.Windows.Forms.ToolStripMenuItem();
            this.miBase64 = new System.Windows.Forms.ToolStripMenuItem();
            this.miToString = new System.Windows.Forms.ToolStripMenuItem();
            this.miRegex = new System.Windows.Forms.ToolStripMenuItem();
            this.miFlags = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRandomData = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRandomizer = new System.Windows.Forms.ToolStripMenuItem();
            this.mniGuid = new System.Windows.Forms.ToolStripMenuItem();
            this.mniEncoding = new System.Windows.Forms.ToolStripMenuItem();
            this.dateienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miFilehash = new System.Windows.Forms.ToolStripMenuItem();
            this.miDummyfileGenerator = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCompareFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.farbenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniColor = new System.Windows.Forms.ToolStripMenuItem();
            this.datenbankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSPSignatureGenerator = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mniNofityEnd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // ntiMain
            // 
            this.ntiMain.ContextMenuStrip = this.menuNotifyIcon;
            this.ntiMain.Text = "Admintools";
            this.ntiMain.Visible = true;
            // 
            // menuNotifyIcon
            // 
            this.menuNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zeichenkettenToolStripMenuItem,
            this.dateienToolStripMenuItem,
            this.farbenToolStripMenuItem,
            this.datenbankToolStripMenuItem,
            this.toolStripMenuItem1,
            this.mniNofityEnd});
            this.menuNotifyIcon.Name = "menuNotifyIcon";
            this.menuNotifyIcon.Size = new System.Drawing.Size(153, 142);
            // 
            // zeichenkettenToolStripMenuItem
            // 
            this.zeichenkettenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHashgenerator,
            this.miHexgenerator,
            this.mniBinConverter,
            this.miBase64,
            this.miToString,
            this.miRegex,
            this.miFlags,
            this.mniRandomData,
            this.mniRandomizer,
            this.mniGuid,
            this.mniEncoding});
            this.zeichenkettenToolStripMenuItem.Name = "zeichenkettenToolStripMenuItem";
            this.zeichenkettenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zeichenkettenToolStripMenuItem.Text = "Zeichenketten";
            // 
            // miHashgenerator
            // 
            this.miHashgenerator.Name = "miHashgenerator";
            this.miHashgenerator.Size = new System.Drawing.Size(179, 22);
            this.miHashgenerator.Text = "Hashgenerator";
            this.miHashgenerator.Click += new System.EventHandler(this.mniNotifyHashes_Click);
            // 
            // miHexgenerator
            // 
            this.miHexgenerator.Name = "miHexgenerator";
            this.miHexgenerator.Size = new System.Drawing.Size(179, 22);
            this.miHexgenerator.Text = "Hex converter";
            this.miHexgenerator.Click += new System.EventHandler(this.mniNotifyHexConverter_Click);
            // 
            // mniBinConverter
            // 
            this.mniBinConverter.Name = "mniBinConverter";
            this.mniBinConverter.Size = new System.Drawing.Size(179, 22);
            this.mniBinConverter.Text = "Binary converter";
            this.mniBinConverter.Click += new System.EventHandler(this.mniBinConverter_Click);
            // 
            // miBase64
            // 
            this.miBase64.Name = "miBase64";
            this.miBase64.Size = new System.Drawing.Size(179, 22);
            this.miBase64.Text = "Base64";
            this.miBase64.Click += new System.EventHandler(this.mniNotifyBase64_Click);
            // 
            // miToString
            // 
            this.miToString.Name = "miToString";
            this.miToString.Size = new System.Drawing.Size(179, 22);
            this.miToString.Text = "ToString";
            this.miToString.Click += new System.EventHandler(this.mniNotifyToStringHelper_Click);
            // 
            // miRegex
            // 
            this.miRegex.Name = "miRegex";
            this.miRegex.Size = new System.Drawing.Size(179, 22);
            this.miRegex.Text = "Reguläre Ausdrücke";
            this.miRegex.Click += new System.EventHandler(this.miRegex_Click);
            // 
            // miFlags
            // 
            this.miFlags.Name = "miFlags";
            this.miFlags.Size = new System.Drawing.Size(179, 22);
            this.miFlags.Text = "Flags";
            this.miFlags.Click += new System.EventHandler(this.miFlags_Click);
            // 
            // mniRandomData
            // 
            this.mniRandomData.Name = "mniRandomData";
            this.mniRandomData.Size = new System.Drawing.Size(179, 22);
            this.mniRandomData.Text = "Zufallsdaten";
            this.mniRandomData.Click += new System.EventHandler(this.mniRandomData_Click);
            // 
            // mniRandomizer
            // 
            this.mniRandomizer.Name = "mniRandomizer";
            this.mniRandomizer.Size = new System.Drawing.Size(179, 22);
            this.mniRandomizer.Text = "Mischen";
            this.mniRandomizer.Click += new System.EventHandler(this.mniRandomizer_Click);
            // 
            // mniGuid
            // 
            this.mniGuid.Name = "mniGuid";
            this.mniGuid.Size = new System.Drawing.Size(179, 22);
            this.mniGuid.Text = "Guid";
            this.mniGuid.Click += new System.EventHandler(this.mniGuid_Click);
            // 
            // mniEncoding
            // 
            this.mniEncoding.Name = "mniEncoding";
            this.mniEncoding.Size = new System.Drawing.Size(179, 22);
            this.mniEncoding.Text = "Encoding";
            this.mniEncoding.Click += new System.EventHandler(this.mniEncoding_Click);
            // 
            // dateienToolStripMenuItem
            // 
            this.dateienToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFilehash,
            this.miDummyfileGenerator,
            this.mniCompareFiles});
            this.dateienToolStripMenuItem.Name = "dateienToolStripMenuItem";
            this.dateienToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dateienToolStripMenuItem.Text = "Dateien";
            // 
            // miFilehash
            // 
            this.miFilehash.Name = "miFilehash";
            this.miFilehash.Size = new System.Drawing.Size(198, 22);
            this.miFilehash.Text = "Dateihash Generator";
            this.miFilehash.Click += new System.EventHandler(this.mniNotifyFileFingerprint_Click);
            // 
            // miDummyfileGenerator
            // 
            this.miDummyfileGenerator.Name = "miDummyfileGenerator";
            this.miDummyfileGenerator.Size = new System.Drawing.Size(198, 22);
            this.miDummyfileGenerator.Text = "Dummydatei Generator";
            this.miDummyfileGenerator.Click += new System.EventHandler(this.mniDummyFile_Click);
            // 
            // mniCompareFiles
            // 
            this.mniCompareFiles.Name = "mniCompareFiles";
            this.mniCompareFiles.Size = new System.Drawing.Size(198, 22);
            this.mniCompareFiles.Text = "Compare files";
            this.mniCompareFiles.Click += new System.EventHandler(this.mniCompareFiles_Click);
            // 
            // farbenToolStripMenuItem
            // 
            this.farbenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniColor});
            this.farbenToolStripMenuItem.Name = "farbenToolStripMenuItem";
            this.farbenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.farbenToolStripMenuItem.Text = "Farben";
            // 
            // mniColor
            // 
            this.mniColor.Name = "mniColor";
            this.mniColor.Size = new System.Drawing.Size(144, 22);
            this.mniColor.Text = "Farbe suchen";
            this.mniColor.Click += new System.EventHandler(this.mniColor_Click);
            // 
            // datenbankToolStripMenuItem
            // 
            this.datenbankToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSPSignatureGenerator});
            this.datenbankToolStripMenuItem.Name = "datenbankToolStripMenuItem";
            this.datenbankToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.datenbankToolStripMenuItem.Text = "Datenbank";
            // 
            // mniSPSignatureGenerator
            // 
            this.mniSPSignatureGenerator.Name = "mniSPSignatureGenerator";
            this.mniSPSignatureGenerator.Size = new System.Drawing.Size(270, 22);
            this.mniSPSignatureGenerator.Text = "StoredProcedure Signature Generator";
            this.mniSPSignatureGenerator.Click += new System.EventHandler(this.mniSPSignatureGenerator_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // mniNofityEnd
            // 
            this.mniNofityEnd.Name = "mniNofityEnd";
            this.mniNofityEnd.Size = new System.Drawing.Size(152, 22);
            this.mniNofityEnd.Text = "&Beenden";
            this.mniNofityEnd.Click += new System.EventHandler(this.mniNofityEnd_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 79);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.menuNotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon ntiMain;
        private System.Windows.Forms.ContextMenuStrip menuNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem mniNofityEnd;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zeichenkettenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miHashgenerator;
        private System.Windows.Forms.ToolStripMenuItem miHexgenerator;
        private System.Windows.Forms.ToolStripMenuItem miBase64;
        private System.Windows.Forms.ToolStripMenuItem miToString;
        private System.Windows.Forms.ToolStripMenuItem miRegex;
        private System.Windows.Forms.ToolStripMenuItem dateienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miFilehash;
        private System.Windows.Forms.ToolStripMenuItem miDummyfileGenerator;
        private System.Windows.Forms.ToolStripMenuItem miFlags;
        private System.Windows.Forms.ToolStripMenuItem mniCompareFiles;
        private System.Windows.Forms.ToolStripMenuItem farbenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniColor;
        private System.Windows.Forms.ToolStripMenuItem mniRandomData;
        private System.Windows.Forms.ToolStripMenuItem mniGuid;
        private System.Windows.Forms.ToolStripMenuItem mniRandomizer;
        private System.Windows.Forms.ToolStripMenuItem datenbankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniSPSignatureGenerator;
        private System.Windows.Forms.ToolStripMenuItem mniEncoding;
        private System.Windows.Forms.ToolStripMenuItem mniBinConverter;
    }
}

