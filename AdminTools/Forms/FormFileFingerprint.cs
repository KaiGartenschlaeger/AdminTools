using System;
using System.IO;
using System.Windows.Forms;
using ExtendedControls;
using Tools.Helper;

namespace AdminTools.Forms
{
    public partial class FormFileFingerprint : Form
    {
        #region Constructor

        public FormFileFingerprint()
        {
            InitializeComponent();
        }

        #endregion

        #region Hashes

        private void ptbFile_PathChanged(object sender, PathChangedEventArgs e)
        {
            try
            {
                byte[] data = File.ReadAllBytes(e.Path);

                lblMD5Value.Text = HashHelper.ToMD5(data);
                lblSHA1Value.Text = HashHelper.ToSHA1(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopyMD5_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblMD5Value.Text))
            {
                Clipboard.SetText(lblMD5Value.Text);
            }
        }

        private void btnCopySHA1_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblSHA1Value.Text))
            {
                Clipboard.SetText(lblSHA1Value.Text);
            }
        }

        #endregion
    }
}