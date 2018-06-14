using System.Windows.Forms;

namespace AdminTools.Forms
{
    public partial class FormTextDialog : Form
    {
        #region Constructor

        public FormTextDialog(string text)
        {
            InitializeComponent();
            tbxResult.Text = text ?? string.Empty;
        }

        #endregion
    }
}