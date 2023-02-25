using HistoriaClinica.Model;
using HistoriaClinica.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoriaClinica
{
    
    public partial class formLogin : Form
    {
        public static string iddoctor, valorGlobal = string.Empty;
        private formPrincipal p_frm;
        public formLogin(formPrincipal frm)
        {
            InitializeComponent();
            p_frm = frm;
        }
        
        private void btncancela_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }


        private void btningresa_Click(object sender, EventArgs e)
        {
            UsuarioModel loginModel = Login.Acceso(textuser.Text, textpwd.Text);
           if (loginModel.nombreusuario!=null)
            {
                p_frm.menuStrip1.Visible = true;
               p_frm.usr.Text = "Usuario: "+ loginModel.nombre;
                valorGlobal= loginModel.nombre + " - "+ loginModel.especialidad;
                if ((loginModel.rol == "Doctor")) {
                    p_frm.AtenciónToolStripMenuItem.Visible = true;
                    p_frm.toolStripMenuItem5.Visible = true;
                }
                else
                {
                    p_frm.AtenciónToolStripMenuItem.Visible = false;
                    p_frm.toolStripMenuItem5.Visible = false;
                }
                iddoctor = loginModel.id;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña inválido","Acceso");
            }
        }



        private void textpwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                UsuarioModel loginModel = Login.Acceso(textuser.Text, textpwd.Text);
                if (loginModel.nombreusuario != null)
                {
                    p_frm.menuStrip1.Visible = true;
                    p_frm.usr.Text = "Usuario: " + loginModel.nombre;
                    valorGlobal = loginModel.nombre + " - " + loginModel.especialidad;
                    if ((loginModel.rol == "Doctor"))
                    {
                        p_frm.AtenciónToolStripMenuItem.Visible = true;
                        p_frm.toolStripMenuItem5.Visible = true;
                    }
                    else
                    {
                        p_frm.AtenciónToolStripMenuItem.Visible = false;
                        p_frm.toolStripMenuItem5.Visible = false;
                    }
                    iddoctor = loginModel.id;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña inválido", "Acceso");
                }
            }
        }

       
    }
}
