using System;
using System.Text;
using System.Windows.Forms;

namespace AdminTools.Forms
{
    public partial class FormEncoding : Form
    {
        public FormEncoding()
        {
            InitializeComponent();
            cbxEncoding.SelectedIndex = 1;
        }

        private Encoding GetEncoding()
        {
            switch (cbxEncoding.SelectedIndex)
            {
                case 0:
                default:
                    //return Encoding.ASCII;
                    return Encoding.GetEncoding(437); // extended ascii

                case 1:
                    return Encoding.UTF8;

                case 2:
                    return Encoding.Unicode;
                case 3:
                    return Encoding.UTF32;
            }
        }

        private void Encode()
        {
            string bin = string.Empty;
            string hex = string.Empty;
            string dec = string.Empty;

            foreach (byte ch in GetEncoding().GetBytes(tbxInput.Text))
            {
                int asciiCode = Convert.ToInt32(ch);

                bin += Convert.ToString(asciiCode, 2).PadLeft(8, '0') + " ";
                hex += asciiCode.ToString("x") + " ";
                dec += asciiCode.ToString() + " ";
            }

            lblBin.Text = bin;
            lblHex.Text = hex;
            lblDec.Text = dec;
        }

        private void tbxInput_TextChanged(object sender, EventArgs e)
        {
            Encode();
        }

        private void cbxEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            Encode();
        }
    }
}