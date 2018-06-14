using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

namespace AdminTools.Forms
{
    public partial class FormColorDialog : Form
    {
        #region Fields

        private Color color;
        private string hexColor;
        private SolidBrush firstRasterBrush;
        private SolidBrush secondRasterBrush;
        private byte rasterSize;

        private bool alphaVisible = true;
        private byte oldAlpha;

        private bool handleTrackBarEvents = true;
        private bool handleTextBoxEvents = true;
        private bool handleHexTextBoxEvent = true;

        #endregion

        #region Constructor

        public FormColorDialog()
        {
            InitializeComponent();

            color = Color.White;
            rasterSize = 8;
            firstRasterBrush = new SolidBrush(Color.DarkGray);
            secondRasterBrush = new SolidBrush(Color.LightGray);
            oldAlpha = color.A;

            lblAlpha.Visible = alphaVisible;
            trbAlpha.Visible = alphaVisible;
            tbxAlpha.Visible = alphaVisible;

            refreshColor(true, true, true);

            refreshPalette();
        }

        private void refreshColor(bool refreshTrackBars, bool refreshTextBoxes, bool refreshHex)
        {
            if (refreshTrackBars)
            {
                handleTrackBarEvents = false;

                trbRed.Value = this.color.R;
                trbGreen.Value = this.color.G;
                trbBlue.Value = this.color.B;
                trbAlpha.Value = this.color.A;

                handleTrackBarEvents = true;
            }

            if (refreshTextBoxes)
            {
                handleTextBoxEvents = false;

                tbxRed.Text = this.color.R.ToString();
                tbxGreen.Text = this.color.G.ToString();
                tbxBlue.Text = this.color.B.ToString();
                tbxAlpha.Text = this.color.A.ToString();

                tbxRedFloat.Text = ((float)color.R / 255).ToString("f2");
                tbxGreenFloat.Text = ((float)color.G / 255).ToString("f2");
                tbxBlueFloat.Text = ((float)color.B / 255).ToString("f2");

                handleTextBoxEvents = true;
            }

            if (refreshHex)
            {
                handleHexTextBoxEvent = false;

                if (alphaVisible)
                    this.hexColor = string.Format("{0:X2}{1:X2}{2:X2}{3:X2}", color.A, color.R, color.G, color.B);
                else
                    this.hexColor = string.Format("{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B);

                tbxHex.Text = hexColor;

                handleHexTextBoxEvent = true;
            }

            pbxColor.Invalidate();

            pbxRed.BackColor = Color.FromArgb(255, trbRed.Value, 0, 0);
            pbxGreen.BackColor = Color.FromArgb(255, 0, trbGreen.Value, 0);
            pbxBlue.BackColor = Color.FromArgb(255, 0, 0, trbBlue.Value);
        }

        #endregion

        #region Helper

        private void addColorToPalette(Color color)
        {
            ListViewItem lvi = new ListViewItem();

            lvi.UseItemStyleForSubItems = false;

            lvi.Text = string.Format("R:{0:000} G:{1:000} B:{2:000}",
                color.R, color.G, color.B);

            lvi.SubItems.Add(color.Name);
            lvi.SubItems[1].BackColor = color;

            lvwPalette.Items.Add(lvi);
        }

        private void refreshPalette()
        {
            lvwPalette.BeginUpdate();
            lvwPalette.Items.Clear();

            foreach (PropertyInfo pi in typeof(Color).GetProperties(BindingFlags.Static | BindingFlags.Public))
            {
                Color color = (Color)pi.GetValue(null, null);
                addColorToPalette(color);
            }

            lvwPalette.EndUpdate();

            lvwPalette.Columns[0].Width = -2;
            lvwPalette.Columns[1].Width = -2;
        }

        #endregion

        #region Control events

        private void trbRed_Scroll(object sender, EventArgs e)
        {
            if (!handleTrackBarEvents)
                return;

            this.color = Color.FromArgb(this.color.A, trbRed.Value, this.color.G, this.color.B);
            refreshColor(false, true, true);
        }

        private void trbGreen_Scroll(object sender, EventArgs e)
        {
            if (!handleTrackBarEvents)
                return;

            this.color = Color.FromArgb(this.color.A, this.color.R, trbGreen.Value, this.color.B);
            refreshColor(false, true, true);
        }

        private void trbBlue_Scroll(object sender, EventArgs e)
        {
            if (!handleTrackBarEvents)
                return;

            this.color = Color.FromArgb(this.color.A, this.color.R, this.color.G, trbBlue.Value);
            refreshColor(false, true, true);
        }

        private void trbAlpha_Scroll(object sender, EventArgs e)
        {
            if (!handleTrackBarEvents)
                return;

            this.color = Color.FromArgb(trbAlpha.Value, this.color.R, this.color.G, this.color.B);
            tbxAlpha.Text = this.color.A.ToString();

            refreshColor(false, true, true);
        }

        private void trbBright_Scroll(object sender, EventArgs e)
        {
        }

        private void pbxColor_Paint(object sender, PaintEventArgs e)
        {
            bool firstLine = false;
            bool first = true;

            for (int y = 0; y < pbxColor.ClientRectangle.Height; y += rasterSize)
            {
                for (int x = 0; x < pbxColor.ClientRectangle.Width; x += rasterSize)
                {
                    if (first)
                        e.Graphics.FillRectangle(firstRasterBrush, x, y, rasterSize, rasterSize);
                    else
                        e.Graphics.FillRectangle(secondRasterBrush, x, y, rasterSize, rasterSize);

                    first = !first;
                }

                first = firstLine;
                firstLine = !firstLine;
            }

            e.Graphics.FillRectangle(new SolidBrush(color), pbxColor.ClientRectangle);
        }

        private void tbxRed_TextChanged(object sender, EventArgs e)
        {
            if (!handleTextBoxEvents)
                return;

            int red;
            if (int.TryParse(tbxRed.Text, out red))
            {
                if (red < 0)
                    red = 0;
                else if (red > 255)
                    red = 255;

                trbRed.Value = red;
                color = Color.FromArgb(color.A, red, color.G, color.B);

                refreshColor(true, false, true);
            }
        }

        private void tbxGreen_TextChanged(object sender, EventArgs e)
        {
            if (!handleTextBoxEvents)
                return;

            int green;
            if (int.TryParse(tbxGreen.Text, out green))
            {
                if (green < 0)
                    green = 0;
                else if (green > 255)
                    green = 255;

                trbRed.Value = green;
                color = Color.FromArgb(color.A, color.R, green, color.B);

                refreshColor(true, false, true);
            }
        }

        private void tbxBlue_TextChanged(object sender, EventArgs e)
        {
            if (!handleTextBoxEvents)
                return;

            int blue;
            if (int.TryParse(tbxBlue.Text, out blue))
            {
                if (blue < 0)
                    blue = 0;
                else if (blue > 255)
                    blue = 255;

                trbRed.Value = blue;
                color = Color.FromArgb(color.A, color.R, color.G, blue);

                refreshColor(true, false, true);
            }
        }

        private void tbxAlpha_TextChanged(object sender, EventArgs e)
        {
            if (!handleTextBoxEvents)
                return;

            int alpha;
            if (int.TryParse(tbxAlpha.Text, out alpha))
            {
                if (alpha < 0)
                    alpha = 0;
                else if (alpha > 255)
                    alpha = 255;

                trbRed.Value = alpha;
                color = Color.FromArgb(alpha, color.R, color.G, color.B);

                refreshColor(true, false, true);
            }
        }

        private void tbxHex_TextChanged(object sender, EventArgs e)
        {
            if (!handleHexTextBoxEvent)
                return;

            try
            {
                int argb = Int32.Parse(tbxHex.Text, NumberStyles.HexNumber);
                color = Color.FromArgb(argb);

                refreshColor(true, true, false);
            }
            catch (ArgumentNullException)
            { }
            catch (ArgumentException)
            { }
            catch (FormatException)
            { }
            catch (OverflowException)
            { }
        }

        private void lvwPalette_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwPalette.SelectedItems.Count == 0)
                return;

            Color selColor = lvwPalette.SelectedItems[0].SubItems[1].BackColor;

            this.color = Color.FromArgb(this.color.A, selColor.R, selColor.G, selColor.B);
            refreshColor(true, true, true);

            tabControl1.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        #endregion

        #region Properties

        [Browsable(true), Category("Layout"), Description("Legt die gewählte Farbe im ColorControl fest.")]
        public Color SelectedColor
        {
            get { return color; }
            set
            {
                this.color = value;
                refreshColor(true, true, true);
            }
        }

        private bool m_enableAlphaChannel = true;

        public bool EnableAlphaChannel
        {
            get { return m_enableAlphaChannel; }
            set
            {
                m_enableAlphaChannel = value;

                lblAlpha.Visible = value;
                trbAlpha.Visible = value;
                tbxAlpha.Visible = value;

                trbAlpha.Value = trbAlpha.Maximum;

                refreshColor(false, false, false);
            }
        }

        #endregion
    }
}