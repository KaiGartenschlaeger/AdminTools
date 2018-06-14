using System;
using System.IO;
using System.Windows.Forms;

namespace AdminTools.Forms
{
    public partial class FormDummyFile : Form
    {
        public FormDummyFile()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pathFilepath.SelectedPath))
            {
                return;
            }

            try
            {
                long sizeBytes = 0;
                if (rbnKilobyte.Checked)
                {
                    sizeBytes = (long)nudSize.Value * 1024;
                }
                else if (rbnMegabyte.Checked)
                {
                    sizeBytes = (long)nudSize.Value * 1024 * 1024;
                }
                else if (rbnGigabyte.Checked)
                {
                    sizeBytes = (long)nudSize.Value * 1024 * 1024 * 1024;
                }
                else
                {
                    sizeBytes = (long)nudSize.Value;
                }

                using (FileStream stream = File.Create(pathFilepath.SelectedPath))
                {
                    byte[] buffer = new byte[1024 * 1024];
                    
                    while (stream.Length < sizeBytes)
                    {
                        long leftSize = sizeBytes - stream.Length;
                        if (leftSize >= buffer.Length)
                        {
                            stream.Write(buffer, 0, buffer.Length);
                        }
                        else
                        {
                            stream.Write(buffer, 0, (int)leftSize);
                        }
                    }
                }

                if (File.Exists(pathFilepath.SelectedPath))
                {
                    MessageBox.Show("Datei wurde erfolgreich erstellt.", "Datei erstellt",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unbekannter Fehler beim erstellen der Datei.", "Fehler",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datei konnte nicht erstellt werden.\n\n" + ex.Message, "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}