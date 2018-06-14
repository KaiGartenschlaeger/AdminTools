using System;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace AdminTools.Forms
{
    public partial class FormHexConverter : Form
    {
        public FormHexConverter()
        {
            InitializeComponent();
        }

        private string GetHexString(byte[] data)
        {
            string result = string.Empty;

            result = BitConverter.ToString(data);

            if (chbRemoveWhitespaces.Checked)
            {
                result = result.Replace("-", "");
            }
            else
            {
                result = result.Replace("-", " ");
            }

            if (chbAddPrefix.Checked)
            {
                result = "0x" + result;
            }

            return result;
        }

        private void ConvertToHex()
        {
            if (rbnStringToHex.Checked)
            {
                byte[] data = Encoding.UTF8.GetBytes(tbxValue.Text);

                tbxHexValue.Text = GetHexString(data);
            }
            else if (rbnHexToString.Checked)
            {
                try
                {
                    string[] parts = tbxValue.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < parts.Length; i++)
                    {
                        int asciiCode = int.Parse(parts[i].Trim(), NumberStyles.HexNumber);

                        sb.Append((char)asciiCode);
                    }

                    tbxHexValue.Text = sb.ToString();
                }
                catch (Exception)
                {
                    tbxHexValue.Text = "Failed";
                }
            }
            else if (rbnNumberToHex.Checked)
            {
                long number;
                if (long.TryParse(tbxValue.Text, out number))
                {
                    string hexString = number.ToString("X").ToUpper();

                    if (hexString.Length % 2 != 0)
                    {
                        hexString = "0" + hexString;
                    }

                    StringBuilder sb = new StringBuilder();

                    if (chbAddPrefix.Checked)
                    {
                        sb.Append("0x");
                    }
                    
                    for (int i = 0; i < hexString.Length; i += 2)
                    {
                        sb.Append(hexString.Substring(i, 2));
                        if (!chbRemoveWhitespaces.Checked)
                        {
                            sb.Append(" ");
                        }
                    }
                    
                    tbxHexValue.Text = sb.ToString().Trim();
                }
                else
                {
                    tbxHexValue.Text = "Invalid Number";
                }
            }
            else if (rbnHexToNumber.Checked)
            {
                try
                {
                    int value = int.Parse(tbxValue.Text.Replace(" ", "").Trim(), NumberStyles.HexNumber);

                    tbxHexValue.Text = value.ToString("n0");
                }
                catch (Exception)
                {
                    tbxHexValue.Text = "Invalid String";
                }
            }
        }

        private void tbxValue_TextChanged(object sender, EventArgs e)
        {
            ConvertToHex();
        }

        private void rbnString_CheckedChanged(object sender, EventArgs e)
        {
            ConvertToHex();
        }

        private void rbnNumber_CheckedChanged(object sender, EventArgs e)
        {
            ConvertToHex();
        }

        private void chbRemoveWhitespaces_CheckedChanged(object sender, EventArgs e)
        {
            ConvertToHex();
        }

        private void chbAddPrefix_CheckedChanged(object sender, EventArgs e)
        {
            ConvertToHex();
        }
    }
}