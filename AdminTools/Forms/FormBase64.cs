using System;
using System.Windows.Forms;
using Tools.Helper;

namespace AdminTools.Forms
{
    public partial class FormBase64 : Form
    {
        #region Constructor

        public FormBase64()
        {
            InitializeComponent();
        }

        #endregion

        #region Control Events

        private void btnEncode_Click(object sender, EventArgs e)
        {
            tbxResult.Text = EncodingHelper.EncodeBase64(tbxInput.Text, "");
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            tbxResult.Text = EncodingHelper.DecodeBase64(tbxInput.Text, "");
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxResult.Text))
            {
                Clipboard.SetText(tbxResult.Text);
            }
        }

        #endregion
    }
}