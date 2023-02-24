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
    internal class Cita
    {
        public static void Add(string id, string fecha, string doctor)
        {
            
                CConexion cn = new CConexion();
                DataSet ds = new DataSet();
                using (SqlConnection Conexion = new SqlConnection(cn.strinCon("database")))
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_AgregarCita", Conexion))
                        {
                            Conexion.Open();
                            cmd.Parameters.AddWithValue("@idpaciente", id);
                            cmd.Parameters.AddWithValue("@fecha", fecha);
                            cmd.Parameters.AddWithValue("@doctor", doctor);
                            

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Cita agendada de manera éxitosa", "Correcto");
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
