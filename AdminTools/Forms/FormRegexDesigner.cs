using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using Tools.Helper;

namespace AdminTools.Forms
{
    public partial class FormRegexDesigner : Form
    {
        #region Fields

        private string m_path;

        #endregion

        #region Constructor

        public FormRegexDesigner()
        {
            InitializeComponent();
        }

        private void FormRegexDesigner_Load(object sender, EventArgs e)
        {
            InitializeDirectory();
        }

        #endregion

        #region Helper

        private void InitializeDirectory()
        {
            m_path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Regex");
            try
            {
                if (!Directory.Exists(m_path))
                {
                    Directory.CreateDirectory(m_path);
                }
            }
            catch (Exception)
            {
                m_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                MessageBox.Show("Fehler beim erstellen des Verzeichnisses '" + m_path + "'.", "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveHighlighting()
        {
            tbxInput.SelectAll();
            tbxInput.SelectionColor = Color.Black;
            tbxInput.SelectionBackColor = Color.White;
        }

        private void RunMatch()
        {
            try
            {
                Regex regex = null;
                try
                {
                    regex = new Regex(tbxRegex.Text.Trim(), RegexOptions.None);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ungültiger Ausdruck", "Fehler",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                // gui
                RemoveHighlighting();

                // match
                trvResult.BeginUpdate();
                trvResult.Nodes.Clear();

                MatchCollection matches = regex.Matches(tbxInput.Text);
                foreach (Match match in matches)
                {
                    TreeNode nodeMatch = new TreeNode();
                    nodeMatch.Tag = match;
                    nodeMatch.Text = "'" + match.Value + "'";

                    if (match.Groups.Count > 1)
                    {
                        for (int groupIndex = 1; groupIndex < match.Groups.Count; groupIndex++)
                        {
                            TreeNode nodeGroup = new TreeNode();
                            nodeGroup.Tag = match.Groups[groupIndex];
                            nodeGroup.Text = groupIndex + ": '" + match.Groups[groupIndex].Value + "'";

                            nodeMatch.Nodes.Add(nodeGroup);
                        }
                    }

                    nodeMatch.Expand();

                    trvResult.Nodes.Add(nodeMatch);
                }

                trvResult.ExpandAll();
                trvResult.EndUpdate();
                
                // replace
                tbxReplaceResult.Text = regex.Replace(tbxInput.Text, tbxRegexReplace.Text);

                // preselect tree view node
                if (trvResult.Nodes.Count > 0)
                {
                    trvResult.SelectedNode = trvResult.Nodes[0];
                }

                trvResult.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehlgeschlagen",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Control Events

        private void miMainSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Speichern";
                dialog.Filter = "Regulärer Ausdruck|*.regex";
                dialog.FilterIndex = 0;
                dialog.InitialDirectory = m_path;

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.Indent = true;

                    using (XmlWriter writer = XmlWriter.Create(dialog.FileName, settings))
                    {
                        writer.WriteStartDocument();

                        writer.WriteStartElement("Regex");
                        writer.WriteAttributeString("Version", "1");

                        writer.WriteElementString("Search", tbxRegex.Text.Trim());
                        writer.WriteElementString("Replace", tbxRegexReplace.Text.Trim());

                        writer.WriteElementString("Input", EncodingHelper.EncodeBase64(tbxInput.Text, string.Empty));

                        writer.WriteEndElement();

                        writer.WriteEndDocument();
                    }
                }
            }
        }

        private void miMainLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Öffnen";
                dialog.Filter = "Regulärer Ausdruck|*.regex";
                dialog.FilterIndex = 0;
                dialog.InitialDirectory = m_path;

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(dialog.FileName);

                    XmlNode nodeRegex = doc["Regex"];
                    if (nodeRegex == null)
                    {
                        MessageBox.Show("Regex-Element konnte nicht gefunden werden.", "Ungültige Datei");
                        return;
                    }

                    XmlNode nodeSearch = nodeRegex["Search"];
                    XmlNode nodeReplace = nodeRegex["Replace"];

                    if (nodeSearch == null || nodeReplace == null)
                    {
                        MessageBox.Show("Die Datei enthält kein Search oder Replace Element.", "Ungültige Datei");
                        return;
                    }

                    tbxRegex.Text = nodeSearch.InnerText;
                    tbxRegexReplace.Text = nodeReplace.InnerText;

                    XmlNode nodeInput = nodeRegex["Input"];
                    if (nodeInput != null && !string.IsNullOrEmpty(nodeInput.InnerText))
                    {
                        tbxInput.Text = EncodingHelper.DecodeBase64(nodeInput.InnerText, string.Empty);
                    }


                    tbxRegex.Select(0, 0);
                    tbxRegex.Focus();
                }
            }
        }

        private void trvResult_AfterSelect(object sender, TreeViewEventArgs e)
        {
            RemoveHighlighting();

            Match match = e.Node.Tag as Match;
            if (match != null)
            {
                tbxInput.Select(match.Index, match.Length);

                tbxInput.SelectionColor = Color.White;
                tbxInput.SelectionBackColor = Color.Black;
            }
            else
            {
                Group group = e.Node.Tag as Group;
                if (group != null)
                {
                    tbxInput.Select(group.Index, group.Length);

                    tbxInput.SelectionColor = Color.White;
                    tbxInput.SelectionBackColor = Color.Black;
                }
            }
        }

        private void miMainEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void miMainReset_Click(object sender, EventArgs e)
        {
            tbxInput.Clear();
            tbxRegex.Clear();
            tbxRegexReplace.Clear();
            trvResult.Nodes.Clear();
            tbxReplaceResult.Clear();
        }

        private void tbxRegex_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                RunMatch();
            }
        }

        private void tbxRegexReplace_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                RunMatch();
            }
        }

        private void tbxInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                RunMatch();
            }
        }

        private void miMainMatch_Click(object sender, EventArgs e)
        {
            RunMatch();
        }

        #endregion
    }
}