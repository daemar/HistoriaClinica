using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoriaClinica.Security
{
    internal class Encrypt
    {
        public static string Encriptar(string pswd)
        {
            string result=string.Empty;
            byte[] encrypted=System.Text.Encoding.Unicode.GetBytes(pswd);
            result=Convert.ToBase64String(encrypted);
            return result;  
        }

        public static string Desencriptar(string pswd)
        {
            string result = string.Empty;
            byte[] decrypted = System.Text.Encoding.Unicode.GetBytes(pswd);
            result = Convert.ToBase64String(decrypted);
            return result;
        }
    }
}
