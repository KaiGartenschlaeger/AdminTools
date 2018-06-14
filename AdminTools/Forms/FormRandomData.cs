using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AdminTools.Forms
{
    public partial class FormRandomData : Form
    {
        #region Constructor

        public FormRandomData()
        {
            InitializeComponent();

            m_random = new Random(DateTime.Now.Second);
        }

        #endregion

        #region Control events

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //
            // set length of result
            //
            int length;
            if (nudMinLength.Value != nudMaxLength.Value)
            {
                length = (int)nudMinLength.Value;
            }
            else
            {
                length = m_random.Next((int)nudMinLength.Value, (int)nudMaxLength.Value);
            }

            List<CharType> types = new List<CharType>();
            if (chbUpperChars.Checked)
                types.Add(CharType.UpperChar);
            if (chbLowerChars.Checked)
                types.Add(CharType.LowerChar);
            if (chbNumbers.Checked)
                types.Add(CharType.Number);
            if (chbMiscCharacters.Checked && tbxMiscCharacters.Text.Length > 0)
                types.Add(CharType.MiscCharacter);

            //
            // generate result
            //
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < (int)nudResultCount.Value; i++)
            {
                GenerateRandomString(types, result, length);
            }

            tbxOutput.Text = result.ToString();
        }

        private void GenerateRandomString(List<CharType> possibleTypes, StringBuilder sb, int length)
        {
            for (int i = 0; i < length; i++)
            {
                char ch;
                switch (possibleTypes[m_random.Next(0, possibleTypes.Count)])
                {
                    case CharType.UpperChar:
                        ch = CHARACTERS_UPPER[m_random.Next(0, CHARACTERS_UPPER.Length - 1)];
                        break;
                    case CharType.LowerChar:
                        ch = CHARACTERS_LOWER[m_random.Next(0, CHARACTERS_LOWER.Length - 1)];
                        break;
                    case CharType.Number:
                        ch = CHARACTERS_NUMBERS[m_random.Next(0, CHARACTERS_NUMBERS.Length - 1)];
                        break;
                    case CharType.MiscCharacter:
                        ch = tbxMiscCharacters.Text[m_random.Next(0, tbxMiscCharacters.Text.Length - 1)];
                        break;

                    default:
                        throw new Exception("No type defined");
                }

                sb.Append(ch);
            }

            sb.AppendLine();
        }

        #endregion

        #region Properties

        private Random m_random;

        private const string CHARACTERS_UPPER = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string CHARACTERS_LOWER = "abcdefghijklmonpqrstuvwxyz";
        private const string CHARACTERS_NUMBERS = "0123456789";

        private enum CharType
        {
            UpperChar,
            LowerChar,
            Number,
            MiscCharacter
        }

        #endregion
    }
}