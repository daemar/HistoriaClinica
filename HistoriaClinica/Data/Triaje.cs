using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HistoriaClinica.Model;

namespace HistoriaClinica.Data
{
    internal class Triaje
    {

        public static TriajeModel SearchModel(string id,string fecha, string derivar)
        {
            CConexion cn = new CConexion();
            TriajeModel ds = new TriajeModel();
            using (SqlConnection Conexion = new SqlConnection(cn.strinCon("database")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_BuscaTriajeActual", Conexion))
                    {
                        Conexion.Open();
                        cmd.Parameters.AddWithValue("@idpaciente", id);
                        cmd.Parameters.AddWithValue("@fechaactual", fecha);
                        cmd.Parameters.AddWithValue("@derivar", derivar);
                       

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();

                        using (var dr = cmd.ExecuteReader())
                        {

                            if (dr.Read())
                            {
                                ds.talla = dr["talla"].ToString();
                                ds.temperatura = dr["temperatura"].ToString();
                                ds.peso = dr["peso"].ToString();
                                ds.presionarterial = dr["presion_arterial"].ToString();
                                ds.patologia = dr["patologia"].ToString();
                            }
                           
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!  " + ex.Message);
                }
                {

                }
            }
            return ds;
        }
        public static DataSet Add(string idpaciente, string talla,
           string temperatura, string peso, string parterial, string patologia, string derivar, string factual)
        {
            CConexion cn = new CConexion();
            DataSet ds = new DataSet();
            using (SqlConnection Conexion = new SqlConnection(cn.strinCon("database")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_AgregarTriaje", Conexion))
                    {
                        Conexion.Open();
                        cmd.Parameters.AddWithValue("@idpaciente", idpaciente);
                        cmd.Parameters.AddWithValue("@talla", talla);
                        cmd.Parameters.AddWithValue("@temperatura", temperatura);
                        cmd.Parameters.AddWithValue("@peso", peso);
                        cmd.Parameters.AddWithValue("@presionarterial", parterial);
                        cmd.Parameters.AddWithValue("@patologia", patologia);
                        cmd.Parameters.AddWithValue("@derivar", derivar);
                        cmd.Parameters.AddWithValue("@fechaactual", factual);

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
            return ds;
        }
    }
}
