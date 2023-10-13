using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01
{
    public class Persona
    {
        private long dni;
        private string nombre;

        public long Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Persona(string nombre)
        {        
            this.nombre = nombre;
        }

        public Persona(long dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {nombre}" +
                          $"Dni: {dni}");

            return sb.ToString();
        }
    }
}
