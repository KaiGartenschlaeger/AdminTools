using AdminTools.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AdminTools.Forms
{
    public partial class FormMain : Form
    {
        #region Constructor

        public FormMain()
        {
            InitializeComponent();

            ntiMain.Icon = Resources.NotifyIcon;

            LoadSettings();
        }

        #endregion

        #region Helper

        private void LoadSettings()
        {
        }

        private void SaveSettings()
        {
        }

        private void OpenToolWindow(Form form)
        {
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(
                Screen.PrimaryScreen.WorkingArea.Width - form.Width - 10,
                Screen.PrimaryScreen.WorkingArea.Height - form.Height - 10);
            form.TopMost = true;
            form.ShowInTaskbar = false;

            form.Show(this);
        }

        #endregion

        #region Menu Events

        private void mniNotifyHashes_Click(object sender, System.EventArgs e)
        {
            OpenToolWindow(new FormHashes());
        }

        private void mniNotifyFileFingerprint_Click(object sender, EventArgs e)
        {
            OpenToolWindow(new FormFileFingerprint());
        }

        private void mniNotifyToStringHelper_Click(object sender, EventArgs e)
        {
            OpenToolWindow(new FormToStringHelper());
        }

        private void mniNotifyHexConverter_Click(object sender, EventArgs e)
        {
            OpenToolWindow(new FormHexConverter());
        }

        private void mniDummyFile_Click(object sender, EventArgs e)
        {
            OpenToolWindow(new FormDummyFile());
        }

        private void mniNotifyBase64_Click(object sender, EventArgs e)
        {
            OpenToolWindow(new FormBase64());
        }

        private void miRegex_Click(object sender, EventArgs e)
        {
            OpenToolWindow(new FormRegexDesigner());
        }

        private void miFlags_Click(object sender, EventArgs e)
        {
            OpenToolWindow(new FormFlags());
        }

        private void mniCompareFiles_Click(object sender, EventArgs e)
        {
            OpenToolWindow(new FormFilecompare());
        }

        private void mniColor_Click(object sender, EventArgs e)
        {
            OpenToolWindow(new FormColorDialog());
        }

        private void mniRandomData_Click(object sender, EventArgs e)
        {
            OpenToolWindow(new FormRandomData());
        }

        private void mniGuid_Click(object sender, EventArgs e)
        {
            OpenToolWindow(new FormGuid());
        }

        private void mniRandomizer_Click(object sender, EventArgs e)
        {
            OpenToolWindow(new FormRandomizer());
        }

        private void mniNofityEnd_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Close();
        }

        private void mniSPSignatureGenerator_Click(object sender, EventArgs e)
        {
            OpenToolWindow(new FormStoredProcedureSignature());
        }

        #endregion

        private void mniEncoding_Click(object sender, EventArgs e)
        {
            OpenToolWindow(new FormEncoding());
        }

        private void mniBinConverter_Click(object sender, EventArgs e)
        {
            OpenToolWindow(new FormBinary());
        }
    }
}