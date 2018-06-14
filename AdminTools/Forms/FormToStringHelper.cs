using System;
using System.Globalization;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace AdminTools.Forms
{
    public partial class FormToStringHelper : Form
    {
        #region Constructor

        public FormToStringHelper()
        {
            InitializeComponent();

            cbxDataType.Text = "System.Int32";

            CultureItem selectedItem = null;
            foreach (CultureInfo culture in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                CultureItem item = new CultureItem(culture);

                cbxCulture.Items.Add(item);

                if (Thread.CurrentThread.CurrentCulture.Name == culture.Name)
                {
                    selectedItem = item;
                }
            }

            if (selectedItem != null)
            {
                cbxCulture.SelectedItem = selectedItem;
            }
        }

        #endregion

        #region Helper

        private object CreateObjectAndParseString(string typeName, string parseArg)
        {
            Type type = Type.GetType(typeName);

            if (type == typeof(string))
            {
                return parseArg;
            }

            Type[] typeArray = new Type[] { typeof(string) };
            MethodInfo method = type.GetMethod("Parse", typeArray);

            object[] objArray = new object[] { parseArg };

            return method.Invoke(null, objArray);
        }

        private void FormatOutput()
        {
            CultureInfo culture = null;
            if (cbxCulture.SelectedIndex != -1)
            {
                culture = ((CultureItem)cbxCulture.SelectedItem).Info;
            }

            try
            {
                object obj = CreateObjectAndParseString(cbxDataType.Text, tbxInput.Text);

                lblOutput.Text = string.Format(culture,
                    string.Concat("{0:", tbxFormat.Text.Trim(), "}"), obj);
            }
            catch (Exception ex)
            {
                lblOutput.Text = "Fehler";

                ToolTip tooltip = new ToolTip();
                tooltip.SetToolTip(lblOutput, ex.Message.ToString());
            }
        }

        #endregion

        #region Control Events

        private void tbxInput_TextChanged(object sender, EventArgs e)
        {
            FormatOutput();
        }

        private void tbxFormat_TextChanged(object sender, EventArgs e)
        {
            FormatOutput();
        }

        private void SetDefaultValue()
        {
            Type type = Type.GetType(cbxDataType.Text);

            object defaultValue = type.IsValueType ? Activator.CreateInstance(type) : null;
            if (defaultValue != null)
            {
                tbxInput.Text = defaultValue.ToString();
            }
        }

        private void cbxDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDefaultValue();
            FormatOutput();
        }

        private void cbxCulture_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatOutput();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbxFormat.Text.Trim());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}