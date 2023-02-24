using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HistoriaClinica
{
    internal class CConexion
    {
        private string conn;
        public string strinCon(string nomBD) { 
            conn= ConfigurationManager.ConnectionStrings[nomBD].ConnectionString;
            return conn;
        }
    }
}
