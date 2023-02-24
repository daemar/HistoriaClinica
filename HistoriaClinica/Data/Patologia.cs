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
    internal class Patologia
    {
        public static List<string> Lista()
        {
            CConexion cn = new CConexion();
            List<string> _lista = new List<string>();
            using (SqlConnection Conexion = new SqlConnection(cn.strinCon("database")))
            {
                Conexion.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ListaPatologia", Conexion))
                    {
                        
                        cmd.CommandType = CommandType.StoredProcedure;
                       
                        using (var dr = cmd.ExecuteReader())
                        {

                            while (dr.Read())
                            {
                                _lista.Add(                             
                                    dr["descripcion"].ToString()
                                );
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return _lista;

        }
    }
}
