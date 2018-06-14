using System;
using System.Windows.Forms;

namespace AdminTools.Forms
{
    public partial class FormGuid : Form
    {
        #region Constructor

        public FormGuid()
        {
            InitializeComponent();

            GenerateGuid();
        }

        #endregion

        #region Helper

        private void GenerateGuid()
        {
            string value = Guid.NewGuid().ToString();

            if (chbUpperCharacters.Checked)
            {
                value = value.ToUpper();
            }
            else
            {
                value = value.ToLower();
            }

            if (chbCurlyBraces.Checked)
            {
                value = "{" + value + "}";
            }

            if (chbRemoveMinus.Checked)
            {
                value = value.Replace("-", string.Empty);
            }

            lblGuid.Text = value;
        }

        #endregion

        #region Control events

        private void btnCreate_Click(object sender, EventArgs e)
        {
            GenerateGuid();
        }

        private void chbCurlyBraces_CheckedChanged(object sender, EventArgs e)
        {
            GenerateGuid();
        }

        private void chbUpperCharacters_CheckedChanged(object sender, EventArgs e)
        {
            GenerateGuid();
        }

        private void chbRemoveMinus_CheckedChanged(object sender, EventArgs e)
        {
            GenerateGuid();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblGuid.Text))
            {
                Clipboard.SetText(lblGuid.Text);
            }
        }

        #endregion
    }
}