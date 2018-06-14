using System;
using System.Windows.Forms;
using Tools.Helper;

namespace AdminTools.Forms
{
    public partial class FormHashes : Form
    {
        public FormHashes()
        {
            InitializeComponent();
        }

        private void tbxValue_TextChanged(object sender, EventArgs e)
        {
            lblMD5Value.Text = HashHelper.ToMD5(tbxValue.Text);
            lblSHA1.Text = HashHelper.ToSHA1(tbxValue.Text);
            lblCRC32Value.Text = HashHelper.ToCRC32(tbxValue.Text);
        }

        private void btnCopyMD5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblMD5Value.Text))
            {
                Clipboard.SetText(lblMD5Value.Text);
            }
        }

        private void btnCopySHA1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblSHA1.Text))
            {
                Clipboard.SetText(lblSHA1.Text);
            }
        }

        private void btnCopyCRC32_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblCRC32Value.Text))
            {
                Clipboard.SetText(lblCRC32Value.Text);
            }
        }
    }
}