using System;

/*
    Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea
    mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
    Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
*/

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int cuadrado;
            int cubo;
            int numero;

            Console.Write("Ingrese un numero: ");
            numero = Int32.Parse(Console.ReadLine());

            while(numero < 1)
            {
                Console.Write("ERROR. ¡Reingresar número!: ");
                numero = Int32.Parse(Console.ReadLine());
            }

            cuadrado = (int)Math.Pow(numero, 2);
            cubo = (int)Math.Pow(numero, 3);

            Console.WriteLine($"El cuadrado del numero es '{cuadrado}' y el cubo es '{cubo}'");
            Console.ReadLine();
        }
    }
}
