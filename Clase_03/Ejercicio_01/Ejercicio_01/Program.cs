using System;

/*
    Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.

    Deberá tener los atributos:

    -titular que contendrá la razón social del titular de la cuenta.
    -cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.
    
    Construir los siguientes métodos para la clase:

    Un constructor que permita inicializar todos los atributos.
    Un método getter para cada atributo.
    -mostrar retornará una cadena de texto con todos los datos de la cuenta.
    -ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
    -retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
    En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.

*/

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            double saldo;

            Cuenta miCuenta = new Cuenta("Agustin", 180000);

            Console.WriteLine($"Hola {miCuenta.getTitular()}");

            do
            {
                Console.WriteLine("1. Mostrar datos de cuenta\n" +
                                   "2. Ingresar saldo a la cuenta\n" +
                                   "3. Retirar saldo de la cuenta\n" +
                                   "4. Salir");

                Console.Write("Ingresa una opcion: ");
                
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("El valor ingresado no es un número entero válido.");
                    return;
                }

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.Write(miCuenta.mostrar());
                        break;

                    case 2:
                        Console.Write("Ingrese saldo a guardar: ");
                        saldo = double.Parse(Console.ReadLine());
                        miCuenta.ingresar(saldo);
                        break;

                    case 3:
                        Console.Write("Ingrese saldo a retirar: ");
                        saldo = double.Parse(Console.ReadLine());
                        miCuenta.retirar(saldo);
                        break;

                    case 4:
                        break;

                    default:
                        Console.Write("ERROR");
                        break;
                }

                Console.ReadKey();

            } while (opcion != 4);
        }
    }
}
