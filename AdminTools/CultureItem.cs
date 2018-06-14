using System.Globalization;

namespace AdminTools
{
    internal class CultureItem
    {
        private CultureInfo m_info;

        public CultureItem(CultureInfo info)
        {
            m_info = info;
        }

        public CultureInfo Info
        {
            get { return m_info; }
        }

        public override string ToString()
        {
            return m_info.DisplayName;
        }
    }
}