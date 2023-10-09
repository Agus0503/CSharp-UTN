using Ejercicio_I02;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            Libro libro = new();
            libro[0] = "Página 1";
            libro[1] = "Página 2";
            libro[2] = "Página 3";
            libro[3] = "Página 4";

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Posicion " + i + ": " + libro[i]);
            }
        }
    }

}