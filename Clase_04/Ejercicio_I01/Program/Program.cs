using System;
using Ejercicio_I01;

/*
    Crear dos constructores:

    Sumador(int) inicializa cantidadSumas en el valor recibido por parámetro.
    Sumador() inicializa cantidadSumas en cero. Reutilizará al primer constructor.
    El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la siguiente lógica:

    En el caso de Sumar(long, long) sumará los valores numéricos
    En el de Sumar(string, string) concatenará las cadenas de texto.
    Crear un proyecto de consola y agregar un objeto del tipo Sumador en el método Main y probar el código.

    Seguido:

    Generar una conversión explícita que retorne cantidadSumas.

    Sobrecargar el operador + (suma) con dos operadores de tipo Sumador. 
    El resultado será un long correspondiente al resultado de la suma del atributo cantidadSumas de cada argumento.

    Sobrecargar el operador | (pipe) con dos operadores de tipo Sumador. 
    Deberá retornar true si ambos sumadores tienen igual valor en el atributo cantidadSumas.

    Agregar un segundo objeto del tipo Sumador en el método Main y probar el código. 

*/


namespace Principal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Sumador sumador1 = new Sumador(3);
            Sumador sumador2 = new Sumador();

            Console.WriteLine($"Sumador 1: {sumador1.GetCantidadDeSumas()}");
            Console.WriteLine($"Sumador 2: {sumador2.GetCantidadDeSumas()}");

            // Sumar dos sumadores
            Sumador sumador3 = sumador1 + sumador2;
            Console.WriteLine($"Sumador 3: {sumador3.GetCantidadDeSumas()}");

            // Comparar dos sumadores
            bool sonIguales = sumador1 | sumador2;
            Console.WriteLine("Los sumadores son iguales: {0}", sonIguales);

        }
    }
}