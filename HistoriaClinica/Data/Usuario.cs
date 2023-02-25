using HistoriaClinica.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HistoriaClinica.Data
{
    internal class Usuario
    {
        public Usuario() { }

        public static UsuarioModel Search(string id)
        {

            CConexion cn = new CConexion();
            UsuarioModel ds = new UsuarioModel();
            using (SqlConnection Conexion = new SqlConnection(cn.strinCon("database")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_UsuarioId", Conexion))
                    {
                        Conexion.Open();
                        cmd.Parameters.AddWithValue("@idusuario", id);


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();

                        using (var dr = cmd.ExecuteReader())
                        {

                            if (dr.Read())
                            {
                                ds.id = dr["id"].ToString();
                                ds.nombre = dr["nombre"].ToString();
                                ds.fechanacimiento = dr["fecha_nacimiento"].ToString();
                                ds.cargo = dr["cargo"].ToString();
                                ds.telefono = dr["telefono"].ToString();
                                ds.correo = dr["correo"].ToString();
                                ds.rol = dr["rol"].ToString();
                                ds.especialidad = dr["especialidad"].ToString();
                                ds.cargo = dr["cargo"].ToString();


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
        public static List<string> ListaDoctor()
        {
            CConexion cn = new CConexion();
            List<string> _lista = new List<string>();
            using (SqlConnection Conexion = new SqlConnection(cn.strinCon("database")))
            {
                try
                {
                    Conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_ListaUsuario", Conexion))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        using (var dr = cmd.ExecuteReader())
                        {

                            while (dr.Read())
                            {
                                if (dr["rol"].ToString()=="Doctor")
                                _lista.Add(
                                    dr["nombre"].ToString()+ " - "+dr["especialidad"].ToString()
                                );
                            }
                        }
                    }
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                {

                }
            }
            return _lista;

        }
        public static DataTable Lista()
        {
            CConexion cn = new CConexion();
            DataTable ds = new DataTable();
            using (SqlConnection Conexion = new SqlConnection(cn.strinCon("database")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ListaUsuario", Conexion))
                    {
                        Conexion.Open();
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

        public static DataSet Add(string id, string nombre, string fnacimiento, 
            string cargo, string tlf, string correo, string rol, string especialidad, string user, string pwd)
        {
            CConexion cn = new CConexion();
            DataSet ds = new DataSet();
            using (SqlConnection Conexion = new SqlConnection(cn.strinCon("database")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_AgregarUsuario", Conexion))
                    {
                        Conexion.Open();
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@fechanacimiento", fnacimiento);
                        cmd.Parameters.AddWithValue("@cargo", cargo);
                        cmd.Parameters.AddWithValue("@telefono", tlf);
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@rol", rol);
                        cmd.Parameters.AddWithValue("@especialidad", especialidad);
                        cmd.Parameters.AddWithValue("@nombusuario", user);
                        cmd.Parameters.AddWithValue("@password", pwd);

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

        public static DataSet Edit(string id, string nombre, string fnacimiento,
           string cargo, string tlf, string correo, string rol, string especialidad, string user, string pwd)
        {
            CConexion cn = new CConexion();
            DataSet ds = new DataSet();
            using (SqlConnection Conexion = new SqlConnection(cn.strinCon("database")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_EditarUsuario", Conexion))
                    {
                        Conexion.Open();
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@fechanacimiento", fnacimiento);
                        cmd.Parameters.AddWithValue("@cargo", cargo);
                        cmd.Parameters.AddWithValue("@telefono", tlf);
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@rol", rol);
                        cmd.Parameters.AddWithValue("@especilidad", especialidad);
                        cmd.Parameters.AddWithValue("@nombusuario", user);
                        cmd.Parameters.AddWithValue("@password", pwd);

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Datos modificados de manera éxitosa", "Correcto");
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
