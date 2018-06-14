namespace AdminTools.Forms
{
    partial class FormRegexDesigner
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
            this.tbxInput = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxRegexReplace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxRegex = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.trvResult = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbxReplaceResult = new System.Windows.Forms.TextBox();
            this.ausdruckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miMainReset = new System.Windows.Forms.ToolStripMenuItem();
            this.miMainMatch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miMainSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miMainLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.miMainEnd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxInput
            // 
            this.tbxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxInput.Location = new System.Drawing.Point(8, 24);
            this.tbxInput.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(608, 112);
            this.tbxInput.TabIndex = 6;
            this.tbxInput.Text = "";
            this.tbxInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxInput_KeyUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbxRegexReplace, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbxRegex, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbxInput, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(624, 254);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 8, 0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Regulärer Ausdruck (Suche)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 8, 0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Regulärer Ausdruck (Ersetzen)";
            // 
            // tbxRegexReplace
            // 
            this.tbxRegexReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRegexReplace.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRegexReplace.Location = new System.Drawing.Point(8, 219);
            this.tbxRegexReplace.Margin = new System.Windows.Forms.Padding(8, 0, 8, 5);
            this.tbxRegexReplace.Name = "tbxRegexReplace";
            this.tbxRegexReplace.Size = new System.Drawing.Size(608, 30);
            this.tbxRegexReplace.TabIndex = 5;
            this.tbxRegexReplace.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxRegexReplace_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 0, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Eingabe";
            // 
            // tbxRegex
            // 
            this.tbxRegex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRegex.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRegex.Location = new System.Drawing.Point(8, 160);
            this.tbxRegex.Margin = new System.Windows.Forms.Padding(8, 0, 8, 5);
            this.tbxRegex.Name = "tbxRegex";
            this.tbxRegex.Size = new System.Drawing.Size(608, 30);
            this.tbxRegex.TabIndex = 3;
            this.tbxRegex.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxRegex_KeyUp);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1MinSize = 250;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.splitContainer1.Panel2MinSize = 150;
            this.splitContainer1.Size = new System.Drawing.Size(624, 421);
            this.splitContainer1.SplitterDistance = 254;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(8, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(608, 151);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.trvResult);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(600, 125);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ergebnisse";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // trvResult
            // 
            this.trvResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvResult.Location = new System.Drawing.Point(3, 3);
            this.trvResult.Name = "trvResult";
            this.trvResult.Size = new System.Drawing.Size(594, 119);
            this.trvResult.TabIndex = 0;
            this.trvResult.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvResult_AfterSelect);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbxReplaceResult);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(600, 125);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ergebnis (Ersetzen)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbxReplaceResult
            // 
            this.tbxReplaceResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxReplaceResult.Location = new System.Drawing.Point(3, 3);
            this.tbxReplaceResult.Multiline = true;
            this.tbxReplaceResult.Name = "tbxReplaceResult";
            this.tbxReplaceResult.ReadOnly = true;
            this.tbxReplaceResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxReplaceResult.Size = new System.Drawing.Size(594, 119);
            this.tbxReplaceResult.TabIndex = 5;
            // 
            // ausdruckToolStripMenuItem
            // 
            this.ausdruckToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMainReset,
            this.miMainMatch,
            this.toolStripMenuItem1,
            this.miMainSave,
            this.miMainLoad,
            this.toolStripMenuItem2,
            this.miMainEnd});
            this.ausdruckToolStripMenuItem.Name = "ausdruckToolStripMenuItem";
            this.ausdruckToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.ausdruckToolStripMenuItem.Text = "&Ausdruck";
            // 
            // miMainReset
            // 
            this.miMainReset.Name = "miMainReset";
            this.miMainReset.Size = new System.Drawing.Size(151, 22);
            this.miMainReset.Text = "&Zurücksetzen";
            this.miMainReset.Click += new System.EventHandler(this.miMainReset_Click);
            // 
            // miMainMatch
            // 
            this.miMainMatch.Name = "miMainMatch";
            this.miMainMatch.ShortcutKeyDisplayString = "F5";
            this.miMainMatch.Size = new System.Drawing.Size(151, 22);
            this.miMainMatch.Text = "&Ausführen";
            this.miMainMatch.Click += new System.EventHandler(this.miMainMatch_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 6);
            // 
            // miMainSave
            // 
            this.miMainSave.Name = "miMainSave";
            this.miMainSave.Size = new System.Drawing.Size(151, 22);
            this.miMainSave.Text = "&Speichern";
            this.miMainSave.Click += new System.EventHandler(this.miMainSave_Click);
            // 
            // miMainLoad
            // 
            this.miMainLoad.Name = "miMainLoad";
            this.miMainLoad.Size = new System.Drawing.Size(151, 22);
            this.miMainLoad.Text = "&Laden";
            this.miMainLoad.Click += new System.EventHandler(this.miMainLoad_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(148, 6);
            // 
            // miMainEnd
            // 
            this.miMainEnd.Name = "miMainEnd";
            this.miMainEnd.Size = new System.Drawing.Size(151, 22);
            this.miMainEnd.Text = "&Beenden";
            this.miMainEnd.Click += new System.EventHandler(this.miMainEnd_Click);
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ausdruckToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuMain.Size = new System.Drawing.Size(624, 24);
            this.menuMain.TabIndex = 13;
            this.menuMain.Text = "menuStrip1";
            // 
            // FormRegexDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 445);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FormRegexDesigner";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Reguläre Ausdrücke";
            this.Load += new System.EventHandler(this.FormRegexDesigner_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbxInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxRegexReplace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxRegex;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView trvResult;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbxReplaceResult;
        private System.Windows.Forms.ToolStripMenuItem ausdruckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miMainReset;
        private System.Windows.Forms.ToolStripMenuItem miMainMatch;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miMainSave;
        private System.Windows.Forms.ToolStripMenuItem miMainLoad;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem miMainEnd;
        private System.Windows.Forms.MenuStrip menuMain;
    }
}