using System;
using System.Collections;
using System.Windows.Forms;

namespace AdminTools.Forms
{
    public partial class FormFlags : Form
    {
        public FormFlags()
        {
            InitializeComponent();
        }

        private void chb_CheckedChanged(object sender, EventArgs e)
        {
            BitArray bits = new BitArray(32);

            // byte 1
            bits.Set(0, chb1_1.Checked);
            bits.Set(1, chb1_2.Checked);
            bits.Set(2, chb1_3.Checked);
            bits.Set(3, chb1_4.Checked);
            bits.Set(4, chb1_5.Checked);
            bits.Set(5, chb1_6.Checked);
            bits.Set(6, chb1_7.Checked);
            bits.Set(7, chb1_8.Checked);
            // byte 2
            bits.Set(8, chb2_1.Checked);
            bits.Set(9, chb2_2.Checked);
            bits.Set(10, chb2_3.Checked);
            bits.Set(11, chb2_4.Checked);
            bits.Set(12, chb2_5.Checked);
            bits.Set(13, chb2_6.Checked);
            bits.Set(14, chb2_7.Checked);
            bits.Set(15, chb2_8.Checked);
            // byte 3
            bits.Set(16, chb3_1.Checked);
            bits.Set(17, chb3_2.Checked);
            bits.Set(18, chb3_3.Checked);
            bits.Set(19, chb3_4.Checked);
            bits.Set(20, chb3_5.Checked);
            bits.Set(21, chb3_6.Checked);
            bits.Set(22, chb3_7.Checked);
            bits.Set(23, chb3_8.Checked);
            // byte 4
            bits.Set(24, chb4_1.Checked);
            bits.Set(25, chb4_2.Checked);
            bits.Set(26, chb4_3.Checked);
            bits.Set(27, chb4_4.Checked);
            bits.Set(28, chb4_5.Checked);
            bits.Set(29, chb4_6.Checked);
            bits.Set(30, chb4_7.Checked);
            bits.Set(31, chb4_8.Checked);

            // output
            byte[] value = new byte[32];
            bits.CopyTo(value, 0);

            uint dec = BitConverter.ToUInt32(value, 0);

            int byteLen = 8;
            if (dec > 255)
            {
                byteLen = 16;
            }
            if (dec > 65535)
            {
                byteLen = 24;
            }
            if (dec > 16777215)
            {
                byteLen = 32;
            }

            lblDecimal.Text = dec.ToString("n0");
            lblBinary.Text = Convert.ToString(dec, 2).PadLeft(byteLen, '0');
            lblHexa.Text = BitConverter.ToString(value, 0, 4).Replace('-', ' ');
        }
    }
}