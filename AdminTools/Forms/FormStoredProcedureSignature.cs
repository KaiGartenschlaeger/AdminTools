using Microsoft.Data.ConnectionUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace AdminTools.Forms
{
    public partial class FormStoredProcedureSignature : Form
    {
        #region Fields

        private string m_connectionString;
        private DataSource m_dataSource;

        #endregion

        #region Models

        class StoredProcedure
        {
            public string Schema { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return Schema + "." + Name;
            }
        }

        class StoredProcedureParameter
        {
            public string Name { get; set; }
            public string DataType { get; set; }
            public int? Length { get; set; }
            public string UserDefinedTypeName { get; set; }
        }

        #endregion

        public FormStoredProcedureSignature()
        {
            InitializeComponent();
        }

        #region Helper

        private IEnumerable<StoredProcedure> GetStoredProcedures()
        {
            using (SqlConnection connection = new SqlConnection(m_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT SPECIFIC_SCHEMA, SPECIFIC_NAME FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE = 'PROCEDURE' ORDER BY SPECIFIC_SCHEMA, SPECIFIC_NAME"; // SPECIFIC_CATALOG = 'Kaisnet'
                    command.CommandType = CommandType.Text;

                    using (IDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            StoredProcedure sp = new StoredProcedure();
                            sp.Schema = reader.GetString(0);
                            sp.Name = reader.GetString(1);

                            yield return sp;
                        }
                    }
                }
            }
        }

        private List<StoredProcedureParameter> GetStoredProcedure(StoredProcedure sp)
        {
            List<StoredProcedureParameter> result = null;

            using (SqlConnection connection = new SqlConnection(m_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select PARAMETER_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, USER_DEFINED_TYPE_SCHEMA, USER_DEFINED_TYPE_NAME from INFORMATION_SCHEMA.PARAMETERS where SPECIFIC_SCHEMA = @SpecificSchema and SPECIFIC_NAME = @SpecificName order by ORDINAL_POSITION";
                    command.CommandType = CommandType.Text;

                    command.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@SpecificSchema",
                        DbType = DbType.String,
                        Value = sp.Schema
                    });
                    command.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@SpecificName",
                        DbType = DbType.String,
                        Value = sp.Name
                    });

                    using (IDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            if (result == null)
                            {
                                result = new List<StoredProcedureParameter>();
                            }

                            StoredProcedureParameter spp = new StoredProcedureParameter();
                            spp.Name = reader.GetString(0);
                            spp.DataType = reader.GetString(1);
                            if (!reader.IsDBNull(2))
                            {
                                spp.Length = reader.GetInt32(2);
                            }
                            if (!reader.IsDBNull(3) && !reader.IsDBNull(4))
                            {
                                spp.UserDefinedTypeName = reader.GetString(3) + "." + reader.GetString(4);
                            }

                            result.Add(spp);
                        }
                    }
                }
            }

            return result;
        }

        private void RefreshStoredProceduresList()
        {
            if (string.IsNullOrEmpty(m_connectionString))
            {
                return;
            }

            lbxStoredProcedures.BeginUpdate();
            lbxStoredProcedures.Items.Clear();

            foreach (StoredProcedure sp in GetStoredProcedures())
            {
                lbxStoredProcedures.Items.Add(sp);
            }

            lbxStoredProcedures.EndUpdate();
        }

        #endregion

        #region Control events

        private void btnConnect_Click(object sender, EventArgs e)
        {
            using (var dialog = new DataConnectionDialog())
            {
                // DataSource.AddStandardDataSources(dialog);
                dialog.DataSources.Add(DataSource.SqlDataSource);
                //dialog.DataSources.Add(DataSource.SqlFileDataSource);

                DialogResult userChoice = DataConnectionDialog.Show(dialog);

                m_connectionString = string.Empty;
                if (userChoice == DialogResult.OK)
                {
                    m_connectionString = dialog.ConnectionString;
                    m_dataSource = dialog.SelectedDataSource;

                    RefreshStoredProceduresList();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshStoredProceduresList();
        }

        private string ConvertDataType(string typeName)
        {
            switch (typeName.ToLower())
            {
                case "bit":
                    return "DbType.Boolean";
                case "int":
                    return "DbType.Int32";
                case "text":
                case "varchar":
                    return "DbType.String";

                default:
                    throw new NotImplementedException();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(m_connectionString))
            {
                return;
            }

            StoredProcedure selectedSP = lbxStoredProcedures.SelectedItem as StoredProcedure;
            if (selectedSP != null)
            {
                var selectedSPParamter = GetStoredProcedure(selectedSP);

                StringBuilder result = new StringBuilder();

                if (chbEnterpriseLibrary.Checked)
                {

                }
                else
                {
                    result.AppendLine("using (SqlCommand command = new SqlCommand())");
                    result.AppendLine("{");
                    result.AppendLine("    command.Connection = <connection>;");
                    result.AppendLine("    command.CommandType = CommandType.StoredProcedure;");
                    result.AppendLine("    command.CommandText = \"" + selectedSP.Schema + "." + selectedSP.Name + "\";");
                    result.AppendLine();

                    foreach (var parameter in selectedSPParamter)
                    {
                        result.AppendLine("    command.Parameters.Add(new SqlParameter()");
                        result.AppendLine("    {");
                        result.AppendLine("        ParameterName = \"" + parameter.Name + "\",");
                        result.AppendLine("        DbType = " + ConvertDataType(parameter.DataType) + ",");
                        result.AppendLine("        Value = <value>");
                        result.AppendLine("    });");
                        result.AppendLine();
                    }
                    
                    result.AppendLine("    // todo: Implement read Logic");
                    result.AppendLine("}");
                }

                using (FormTextDialog dialog = new FormTextDialog(result.ToString()))
                {
                    dialog.ShowDialog(this);
                }
            }
        }

        #endregion
    }
}
