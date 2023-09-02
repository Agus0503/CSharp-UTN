using System;

/*
    Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:
    bool Validar(int valor, int min, int max)
    
    valor: dato a validar.
    min: mínimo valor incluido.
    max: máximo valor incluido.
    Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado 
    anteriormente que estén dentro del rango -100 y 100.

    Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
*/

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadIngresos = 10;
            int numero;
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            int suma = 0;

            for (int i = 0; i < cantidadIngresos; i++)
            {
                Console.Write($"Ingrese el {i + 1}º numero: ");

                numero = int.Parse(Console.ReadLine());

                if (Validador.Validar(numero, -100, 100))
                {
                    if (numero < minimo)
                        minimo = numero;

                    if (numero > maximo)
                        maximo = numero;

                    suma += numero;
                }
                else
                {
                    Console.WriteLine("Número fuera del rango -100 a 100. Ingrese otro número.");
                    i--;
                }
            }

            double promedio = (double)suma / cantidadIngresos;

            Console.WriteLine($"Valor mínimo ingresado: {minimo}");
            Console.WriteLine($"Valor máximo ingresado: {maximo}");
            Console.WriteLine($"Promedio: {promedio}");

            Console.Read();
        }
    }
}
