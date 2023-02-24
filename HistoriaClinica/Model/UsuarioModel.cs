using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoriaClinica.Model
{
    internal class UsuarioModel
    {
        public string id { get; set; } 

        public string nombre { get; set; }

        public string fechanacimiento { get; set; }

        public string cargo { get; set; }

        public string telefono { get; set; }

        public string correo { get; set; }

        public string rol { get; set; }

        public string especialidad { get; set; }

        public string nombreusuario { get; set; }

        public string password { get; set; }
    }
}