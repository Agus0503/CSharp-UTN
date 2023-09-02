using System;

namespace Ejercicio_01
{
    class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            if (valor > min && valor < max)
            {
                return true;
            }
            return false;
        }
    }
}
