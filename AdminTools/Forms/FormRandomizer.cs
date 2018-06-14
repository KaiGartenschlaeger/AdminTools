using System;
using System.Linq;
using System.Windows.Forms;

namespace AdminTools.Forms
{
    public partial class FormRandomizer : Form
    {
        Random m_random;

        public FormRandomizer()
        {
            InitializeComponent();

            m_random = new Random();
        }

        private string Randomize(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            string rand = new string(value.ToCharArray().
                OrderBy(s => (m_random.Next(2) % 2) == 0).ToArray());

            return rand;
        }

        private void btnMix_Click(object sender, EventArgs e)
        {
            lblResult.Text = Randomize(tbxCharacters.Text);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblResult.Text))
            {
                Clipboard.SetText(lblResult.Text);
            }
        }
    }
}