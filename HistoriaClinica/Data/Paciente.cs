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
    internal class Paciente
    {


        public static PacienteModel SearchModel(string id)
        {
        
            CConexion cn = new CConexion();
            PacienteModel ds = new PacienteModel();
            using (SqlConnection Conexion = new SqlConnection(cn.strinCon("database")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_BuscaPaciente", Conexion))
                    {
                        Conexion.Open();
                        cmd.Parameters.AddWithValue("@id", id);


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();

                        using (var dr = cmd.ExecuteReader())
                        {

                            if (dr.Read())
                            {
                                ds.id = dr["id"].ToString();
                                ds.nombre= dr["nombre"].ToString();
                                ds.fechanacimiento= dr["fecha_nacimiento"].ToString();
                                ds.sexo= dr["sexo"].ToString();
                              
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




        public static bool Search(string id)
        {
            bool enc=false;
            CConexion cn = new CConexion();
            DataSet ds = new DataSet();
            using (SqlConnection Conexion = new SqlConnection(cn.strinCon("database")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_BuscaPaciente", Conexion))
                    {
                        Conexion.Open();
                        cmd.Parameters.AddWithValue("@id", id);
                        

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();

                        using (var dr = cmd.ExecuteReader())
                        {

                            if (dr.Read())
                            {
                                
                                enc = true;
                            }
                            else
                            {
                                enc = false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!  "+ex.Message);
                }
                {

                }
            }
            return enc;
        }
        public static void Add(string id, string nombre, string sexo,
            string fnacimiento, string tlf, string domicilio, string correo, string lnacimiento)
        {
            if (Search(id) == false)
            {
                CConexion cn = new CConexion();
                DataSet ds = new DataSet();
                using (SqlConnection Conexion = new SqlConnection(cn.strinCon("database")))
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_AgregarPaciente", Conexion))
                        {
                            Conexion.Open();
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@nombre", nombre);
                            cmd.Parameters.AddWithValue("@sexo", sexo);
                            cmd.Parameters.AddWithValue("@fechanacimiento", fnacimiento);
                            cmd.Parameters.AddWithValue("@telefono", tlf);
                            cmd.Parameters.AddWithValue("@domicilio", domicilio);
                            cmd.Parameters.AddWithValue("@correo", correo);
                            cmd.Parameters.AddWithValue("@lugarnacimiento", lnacimiento);

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
            else
            {
                MessageBox.Show("Paciente ya se encuentra registrado", "Error");
            }
        }

        public static DataSet Edit(string id, string nombre, string sexo,
            string fnacimiento, string tlf, string domicilio, string correo, string lnacimiento)
        {
            CConexion cn = new CConexion();
            DataSet ds = new DataSet();
            using (SqlConnection Conexion = new SqlConnection(cn.strinCon("database")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_EditarPaciente", Conexion))
                    {
                        Conexion.Open();
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@sexo", sexo);
                        cmd.Parameters.AddWithValue("@fechanacimiento", fnacimiento);
                        cmd.Parameters.AddWithValue("@telefono", tlf);
                        cmd.Parameters.AddWithValue("@domicilio", domicilio);
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@lugarnacimiento", lnacimiento);

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
