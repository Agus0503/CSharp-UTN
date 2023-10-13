using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ejercicio_I01.VehiculoTerrestre;

namespace Ejercicio_I01
{
    public class Camion : VehiculoTerrestre
    {                
        public short cantidadMarchas;
        public int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, Color color, short cantidadMarchas, int pesoCarga):base(cantidadRuedas, cantidadPuertas, color)
        {            
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }

    }
}
