using System;
using System.IO;
using System.Windows.Forms;
using Tools.Helper;

namespace AdminTools.Forms
{
    public partial class FormFilecompare : Form
    {
        public FormFilecompare()
        {
            InitializeComponent();
        }

        private string ChooseFile()
        {
            string result = null;

            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Select file to compare";
                dialog.Multiselect = false;

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    result = dialog.FileName;
                }
            }

            return result;
        }

        private void AddLog(string message)
        {
            listBox1.Items.Add(message);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private string GetMD5FromFile(string path)
        {
            string result = null;

            try
            {
                byte[] data = File.ReadAllBytes(path);
                result = HashHelper.ToMD5(data);
            }
            catch (Exception)
            {
                AddLog("Failed to get data from file.");
            }

            return result;
        }

        private void btnChooseFile1_Click(object sender, EventArgs e)
        {
            string path = ChooseFile();
            if (path != null)
            {
                tbxFilepath1.Text = path;
            }
        }

        private void btnChooseFile2_Click(object sender, EventArgs e)
        {
            string path = ChooseFile();
            if (path != null)
            {
                tbxFilepath2.Text = path;
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxFilepath1.Text) && !string.IsNullOrWhiteSpace(tbxFilepath2.Text))
            {
                string md51 = GetMD5FromFile(tbxFilepath1.Text);

                string md52 = null;
                if (md51 != null)
                {
                    md52 = GetMD5FromFile(tbxFilepath2.Text);
                }

                if (md51 != null && md52 != null)
                {
                    AddLog("Succeeded");
                    AddLog("File 1 hash: '" + md51 + "'");
                    AddLog("File 2 hash: '" + md52 + "'");

                    if (md51 == md52)
                    {
                        AddLog("Identical");
                    }
                    else
                    {
                        AddLog("Different");
                    }
                }
                else
                {
                    AddLog("Failed");
                }
            }
            else
            {
                MessageBox.Show("Please select the files to compare.", "Missing input",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}