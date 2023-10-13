using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01
{
    public enum Color
    {
        Rojo, Blanco, Azul, Gris, Negro
    }

    public class VehiculoTerrestre
    {

        public short cantidadRuedas;
        public short cantidadPuertas;
        public Color color;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Color color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }
    }
}
