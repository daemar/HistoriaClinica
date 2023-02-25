using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HistoriaClinica.Model;

namespace HistoriaClinica.Security
{
    internal class Login
    {
        public static UsuarioModel Acceso(string user, string pwd)
        {
           
            CConexion cn = new CConexion();
            UsuarioModel ds = new UsuarioModel();
           
            using (SqlConnection Conexion = new SqlConnection(cn.strinCon("database")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Login", Conexion))
                    {
                        Conexion.Open();
                        pwd = Encrypt.Encriptar(pwd);
                        cmd.Parameters.AddWithValue("@usr", user);
                        cmd.Parameters.AddWithValue("@pwd", pwd);

                        cmd.CommandType = CommandType.StoredProcedure;

                        using (var dr = cmd.ExecuteReader())
                        {

                            if (dr.Read())
                            {
                                ds.id = dr["id"].ToString();
                                ds.nombre = dr["nombre"].ToString();
                                ds.especialidad = dr["especialidad"].ToString();
                                ds.rol = dr["rol"].ToString();
                                ds.nombreusuario = dr["usr"].ToString() ;
                           
                            }
                     
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return ds;
        }
    }
}
