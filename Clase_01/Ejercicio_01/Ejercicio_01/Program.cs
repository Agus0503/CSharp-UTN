using System;

/*
    Ingresar 5 números por consola, guardándolos en una variable escalar.Luego calcular y mostrar: el
    valor máximo, el valor mínimo y el promedio.
*/

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int max = 0;
            int min = 0;
            int total = 0;
            float promedio;
            int i;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numeroIngresado = Int32.Parse(Console.ReadLine());

                if (i == 0 || numeroIngresado > max)
                {
                    max = numeroIngresado;
                }

                if (i == 0 || numeroIngresado < min)
                {
                    min = numeroIngresado;
                }

                total = total + numeroIngresado;
            }

            promedio = total / i;

            Console.WriteLine($"Promedio de los numeros ingresados: {promedio}");
            Console.WriteLine($"Menor numero ingresado: {min}");
            Console.WriteLine($"Mayor numero ingresado: {max}");
        }
    }
}
