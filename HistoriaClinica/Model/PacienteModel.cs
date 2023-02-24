using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoriaClinica.Model
{
    internal class PacienteModel
    {
        public string id { get; set; }

        public string nombre { get; set; }

        public string sexo { get; set;}

        public string fechanacimiento { get; set;}

        public string domicilio { get; set; }

        public string telefono { get; set; }

        public string correo { get; set; }

        public string lugarnacimiento { get; set; } 
    }
}
