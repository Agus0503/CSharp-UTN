using System;

namespace Ejercicio_05A01
{
    class Conductor
    {
        public string nombre;
        public int[] kilometros;

        public Conductor(string nombre, int[] kilometros)
        {
            this.nombre = nombre;
            this.kilometros = kilometros;
        }

        public void SetKilometros(int[] kilometros)
        {
            for (int i = 0; i < kilometros.Length; i++)
            {
                for (int j = 0; j < this.kilometros.Length; j++)
                {
                    if (i == 3)
                    {
                        i++;
                        continue;
                    }

                    Console.WriteLine($"Ingrese cantidad de kilometros del dia {i + 1}");
                    this.kilometros[j] = kilometros[i];
                }
            }
        }

        public int TotalKilometros()
        {
            int total = 0;
            for (int i = 0; i < kilometros.Length; i++)
            {
                total += kilometros[i];
            }
            return total;
        }
    }
}
