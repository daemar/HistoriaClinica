using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoriaClinica.Model
{
    internal class HorarioDoctorModel
    {
        public string  iddoctor { get; set; }
        public int lunes { get; set; }

        public int martes { get; set; }

        public int miercoles { get; set; }

        public int jueves { get; set; }

        public int viernes { get; set; }

        public int sabado { get; set; }

        public string  fechaini { get; set; }

        public string  fechafin { get; set; }
    }
}
