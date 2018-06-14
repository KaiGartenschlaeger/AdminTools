using System;
using System.Windows.Forms;

namespace AdminTools.Forms
{
    public partial class FormBinary : Form
    {
        public FormBinary()
        {
            InitializeComponent();
        }

        private int calculateFillCharacters(int length)
        {
            if (length == 0 || length % 8 == 0)
                return 0;

            int i = 8;
            while (length > i)
                i += 8;

            return i - length;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            long number;
            if (long.TryParse(textBox1.Text.Trim(), out number))
            {
                // convert to bin
                string binString = Convert.ToString(number, 2);

                // fill padding left with '0' characters
                binString = binString.PadLeft(binString.Length + calculateFillCharacters(binString.Length), '0');

                // insert whitespaces
                for (int i = binString.Length - 1; i >= 0; i--)
                {
                    if (i > 0 && i != binString.Length && i % 8 == 0)
                        binString = binString.Insert(i, " ");
                }


                lblBin.Text = binString;
            }
            else
            {
                lblBin.Text = "Invalid number";
            }
        }
    }
}