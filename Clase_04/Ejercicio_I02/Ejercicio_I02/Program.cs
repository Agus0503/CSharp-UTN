using System;
using Billetes;

/*
    Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar entre sí 
    con total normalidad como si fueran tipos numéricos, teniendo presente que 1 Euro equivale a 1,17 Dólares 
    y 1 Dólar equivale a 102,65 Pesos.

    El atributo cotizRespectoDolar y el método GetCotizacion son estáticos.

    Los constructores estáticos le darán a las clases una cotización por defecto respecto del dólar.   

    Reutilizar el código. Sólo realizar las conversiones dentro de los operadores para dicho uso.

    Crear un proyecto de consola y colocar dentro del método Main el código necesario para probar todas las funcionalidades.
*/

namespace Ejercicio_I02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dolar miDolar = new Dolar(100);
            Euro miEuro = new Euro(100, 0.89);
            Peso miPeso = new Peso(100, 0.023);

            // Convierte Dólares a Euros
            miEuro = (Euro)miDolar;
            Console.WriteLine($"Dólares: ${miDolar.GetCantidad()} - Euros: ${miEuro.GetCantidad()}");

            // Convierte Dólares a Pesos
            miPeso = (Peso)miDolar;
            Console.WriteLine($"Dólares: ${miDolar.GetCantidad()} - Pesos: ${miPeso.GetCantidad()}\n");

            // Convierte Pesos a Dólares
            miDolar = (Dolar)miPeso;
            Console.WriteLine($"Pesos: ${miPeso.GetCantidad()} - Dólares: ${miDolar.GetCantidad()}");

            // Convierte Pesos a Euros
            miEuro = (Euro)miPeso;
            Console.WriteLine($"Pesos: ${miPeso.GetCantidad()} - Euros: ${miEuro.GetCantidad()}\n");

            // Convierte Euros a Pesos
            miPeso = (Peso)miEuro;
            Console.WriteLine($"Euros: ${miEuro.GetCantidad()} - Pesos: ${miPeso.GetCantidad()}");

            // Convierte Euros a Dólares
            miDolar = (Dolar)miEuro;
            Console.WriteLine($"Euros: ${miEuro.GetCantidad()} - Dólares: ${miDolar.GetCantidad()}\n");
        }
    }
}