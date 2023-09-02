using System;

/*
    Realizar un programa que sume números enteros hasta que el usuario lo 
    determine por medio de un mensaje "¿Desea continuar? (S/N)".
    Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.
    El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
*/

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumador = 0;

            while (true)
            {
                Console.Write("Ingrese un numero: ");
                string numeroIngresado = Console.ReadLine();

                if (Int32.TryParse(numeroIngresado, out int numero))
                {
                    sumador += numero;
                }

                Console.Write("¿Desea continuar? (S/N): ");
                string respuesta = Console.ReadLine();
                if (!Validador.ValidarRespuesta(respuesta))
                {
                    break;
                }
            }

            Console.WriteLine($"Sumador: {sumador}");
            Console.Read();
        }
    }

    class Validador
    {
        public static bool ValidarRespuesta(string respuesta)
        {
            if (respuesta.ToLower() == "s")
            {
                return true;
            }
            return false;
        }
    }
}
