using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class MascotaDAL
    {

        public static int AgregarMascota(Mascota mascota)
        {
            int retorno = 0;

            using (SqlConnection connection = BBDD.ObtenerConeccion())
            {
                string query = "INSERT INTO mascotas (nombre, tipo, color, edad) VALUES ('"+mascota.nombre+"','"+mascota.tipo+"', '"+mascota.color+"', "+mascota.edad+")";
                SqlCommand comando = new SqlCommand(query, connection);
                retorno = comando.ExecuteNonQuery();
            }   
            return retorno;
        }

        public static List<Mascota> MostrarMascotas()
        {

            using (SqlConnection connection = BBDD.ObtenerConeccion())
            {
                List<Mascota> Lista = new List<Mascota>();
                string query = "SELECT * FROM mascotas";
                SqlCommand comando = new SqlCommand(query, connection);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Mascota mascota = new Mascota();
                    mascota.id = reader.GetInt32(0);
                    mascota.nombre = reader.GetString(1);
                    mascota.tipo = reader.GetString(2);
                    mascota.color = reader.GetString(3);
                    mascota.edad = reader.GetInt32(4);

                    Lista.Add(mascota);
                }
                connection.Close();
                return  Lista;
            }
        }
    }
}
