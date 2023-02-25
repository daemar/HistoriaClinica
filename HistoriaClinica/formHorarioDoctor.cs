using HistoriaClinica.Data;
using HistoriaClinica.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HistoriaClinica
{
    public partial class formHorarioDoctor : Form
    {
        public formHorarioDoctor()
        {
            InitializeComponent();
        }

        private void radioButton1_Enter(object sender, EventArgs e)
        {
            Fechaini.Enabled= false;
            Fechafinal.Enabled = false;
            checkdias.Enabled = true;
            lfechafin.Enabled = false;  
            lfechaini.Enabled = false;
            Fechaini.Text= DateTime.Today.ToString("d");
            Fechafinal.Text = DateTime.Today.ToString("d");

        }

        private void radioButton2_Enter(object sender, EventArgs e)
        {
            
            Fechaini.Enabled = true;
            Fechafinal.Enabled = true;
            checkdias.Enabled = false;
            lfechafin.Enabled = true;
            lfechaini.Enabled = true;
            for (int i = 0; i < checkdias.Items.Count; i++)
            {
                checkdias.SetItemChecked(i, false);
            }


        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
        private void btnguarda_Click(object sender, EventArgs e)
        {
            int lunes= 1, martes = 1, miercoles = 1, jueves = 1, viernes = 1, sabado = 1;
            string fini = Fechaini.Value.ToString("d");
            string ffin = Fechafinal.Value.ToString("d");
            string today = DateTime.Today.ToString("d");
            bool opcdias = false, opcfechas = false;
            if (checkdias.CheckedItems.Count > 0)
            {
               
                foreach (string element in checkdias.CheckedItems)
                {
                    if (element == "Lunes")
                    {
                        lunes = 0;

                    }
                   
                    if (element == "Martes")
                    {
                        martes = 0;
                    }
                   
                    if (element == "Miércoles")
                    {
                        miercoles = 0;
                    }

                    if (element == "Jueves")
                    {
                        jueves = 0;
                    }
                  
                    if (element == "Viernes")
                    {
                        viernes = 0;
                    }
                   
                    if (element == "Sábado")
                    {
                        sabado = 0;
                    }
                   
                }
                opcdias= true;
            }
            else
            {
                if(fini!=ffin)
                {
                    opcfechas= true;
                }
            }
            
                if (HorarioDoctor.Search(formLogin.iddoctor).iddoctor == null)
                {
                    HorarioDoctor.Add(formLogin.iddoctor, lunes, martes, miercoles, jueves, viernes, sabado, fini, ffin);
                }
                else
                {

                    HorarioDoctor.Update(formLogin.iddoctor, lunes, martes, miercoles, jueves, viernes, sabado, fini, ffin);

                }

          

        }

        private void formHorarioDoctor_Load(object sender, EventArgs e)
        {
           HorarioDoctorModel horarioDoctorModel= HorarioDoctor.Search(formLogin.iddoctor);
           if (horarioDoctorModel.lunes == 0)
            {
                checkdias.SetItemChecked(0, true);
            }

            if (horarioDoctorModel.martes == 0)
            {
                checkdias.SetItemChecked(1, true);
            }
            if (horarioDoctorModel.miercoles == 0)
            {
                checkdias.SetItemChecked(2, true);
            }
            if (horarioDoctorModel.jueves ==0)
            {
                checkdias.SetItemChecked(3, true);
            }
            if (horarioDoctorModel.viernes == 0)
            {
                checkdias.SetItemChecked(4, true);
            }
            if (horarioDoctorModel.sabado == 0)
            {
                checkdias.SetItemChecked(5, true);
            }
            if (horarioDoctorModel.fechaini != horarioDoctorModel.fechafin)
            {
                radioButton2.Select();
                Fechaini.Enabled = true;
                Fechafinal.Enabled = true;
                checkdias.Enabled = false;
                lfechafin.Enabled = true;
                lfechaini.Enabled = true;
                for (int i = 0; i < checkdias.Items.Count; i++)
                {
                    checkdias.SetItemChecked(i, false);
                }
                Fechaini.Text = horarioDoctorModel.fechaini;
                Fechafinal.Text = horarioDoctorModel.fechafin;
            }
        }

    }
}
