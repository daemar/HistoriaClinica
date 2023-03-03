using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoriaClinica.Data
{
    internal class ConsultaMedica
    {

        public static DataTable Lista(string id)
        {
            CConexion cn = new CConexion();
            DataTable ds = new DataTable();
            using (SqlConnection Conexion = new SqlConnection(cn.strinCon("database")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ListarConsultaPaciente", Conexion))
                    {
                        Conexion.Open();
                        cmd.Parameters.AddWithValue("@idpaciente", id);
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter sqlSda = new SqlDataAdapter(cmd);
                        sqlSda.Fill(ds);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                {

                }
            }
            return ds;

        }
        public static void Add(string id, string doctor, string fecha,
            string diagnostico, string medicacion)
        {

            CConexion cn = new CConexion();
            DataSet ds = new DataSet();
            using (SqlConnection Conexion = new SqlConnection(cn.strinCon("database")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_AgregarConsulta", Conexion))
                    {
                        Conexion.Open();
                        cmd.Parameters.AddWithValue("@idpaciente", id);
                        cmd.Parameters.AddWithValue("@doctor", doctor);
                        cmd.Parameters.AddWithValue("@fecha", fecha);
                        cmd.Parameters.AddWithValue("@diagnostico", diagnostico);
                        cmd.Parameters.AddWithValue("@medicacion", medicacion);

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Datos ingresados de manera éxitosa", "Correcto");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                {

                }
            }

        }
    }
}
