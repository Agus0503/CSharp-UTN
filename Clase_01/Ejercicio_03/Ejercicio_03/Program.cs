using System;

/*
    Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
    Validar que el dato ingresado por el usuario sea un número.
    Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
    Si ingresa "salir", cerrar la consola.
    Al finalizar, preguntar al usuario si desea volver a operar. 
    Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
*/

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {        
            while (true)
            {
                Console.Write("Ingrese un numero: ");
                string entradaUsuario = Console.ReadLine();

                if (int.TryParse(entradaUsuario, out int tope))
                {
                    // Mostramos los números primos hasta el tope
                    for (int i = 2; i <= tope; i++)
                    {
                        // Verificamos si el número es primo
                        if (EsPrimo(i))
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                else
                {                    
                    Console.WriteLine("El dato ingresado no es válido.");
                }

                Console.Write("¿Desea volver a operar? (s/n)");
                string respuesta = Console.ReadLine();
        
                if (respuesta.ToLower() == "n")
                {
                    Console.WriteLine("Adios...");
                    break;
                }                
            }
        }

        static bool EsPrimo(int numero)
        {            
            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    // El número no es primo
                    return false;
                }
            }            
            return true;
        }
    }
}
