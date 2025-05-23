using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class BBDD
    {
        public static SqlConnection ObtenerConeccion()
        {
            string coneccion = ConfigurationManager.AppSettings["coneccion"];
            SqlConnection conn = new SqlConnection(coneccion);
            conn.Open();
            return conn;
        }
    }
}

