using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoriaClinica.Model
{
    internal class TriajeModel
    {
        public string idpaciente { get; set; }

        public string talla { get; set;}

        public string temperatura { get; set;}

        public string peso { get; set;}

        public string presionarterial { get; set;}  

        public string patologia { get; set;}

        public UsuarioModel refusuario { get; set;} 

        public string fechaactual { get; set;}
    }
}
