using System;

/*
    Un número perfecto es un entero positivo, que es igual a la suma 
    de todos los enteros positivos (excluido el mismo) que son divisores del número.
    El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
    Escribir una aplicación que encuentre los 4 primeros números perfectos.
 */

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int number = 1;

            while (count < 4)
            {
                if (IsPerfectNumber(number))
                {
                    Console.WriteLine($"Número perfecto encontrado: {number}");
                    count++;
                }
                number++;
            }

            Console.Read();
        }

        static bool IsPerfectNumber(int n)
        {
            int sum = 1; 

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    if (i == n / i)
                        sum += i;
                    else
                        sum += i + n / i;
                }
            }

            return sum == n;
        }
    }
}
