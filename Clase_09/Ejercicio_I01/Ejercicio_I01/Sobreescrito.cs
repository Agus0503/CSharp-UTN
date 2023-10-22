using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01
{
    public class Sobreescrito
    {
        public Sobreescrito() { }

        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }

        public override bool Equals(object? obj)
        {            
            return obj is Sobreescrito;
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }
    }
}
