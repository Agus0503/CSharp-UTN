using Biblioteca;
using Ejercicio_C01;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectorTecnico dt = new("Scaloni", new DateTime(1980, 08, 26));
            Jugador j1 = new(123, "j1", 8, 11);
            Jugador j2 = new(456, "j2", 10, 15);
            Jugador j3 = new(789, "j3", 7, 3);
            Jugador j4 = new(101, "j4", 9, 5);

            Equipo utn = new(4, "UTNFRA FC");

            if (utn + j1)
                Console.WriteLine(j1.MostrarDatos());

            if (utn + j2)
                Console.WriteLine(j2.MostrarDatos());

            if (utn + j3)
                Console.WriteLine(j3.MostrarDatos());
            else
                Console.WriteLine("NO SE AGREGO " + j3.MostrarDatos());

            if (utn + j4)
                Console.WriteLine(j4.MostrarDatos());

            else
                Console.WriteLine("NO SE AGREGO " + j4.MostrarDatos());

            Console.WriteLine(dt.MostrarDatos()); 
        }
    }
}