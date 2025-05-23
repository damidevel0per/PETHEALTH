using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Mascota
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public string tipo { get; set; }
        public string color { get; set; }
        public int id { get; set; }
        public Mascota()
        { } 
        public Mascota(string nombre, int edad, string tipo, string color)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.tipo = tipo;
            this.color = color;
        }
    }
}
