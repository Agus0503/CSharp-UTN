using System;

/*
    Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).
    Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
    Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando 
    y la operación matemática. El método devolverá el resultado de la operación.
    Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe 
    utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true si el operando es distinto de cero.
    Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).
    El usuario decidirá cuándo finalizar el programa.
*/

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Que operacion desea realizar?" +
                                  "\n1. Sumar" +
                                  "\n2. Restar" +
                                  "\n3. Multiplicar" +
                                  "\n4. Dividir");

                Console.Write("Ingrese su opcion: ");
                int opcion = Int32.Parse(Console.ReadLine());

                Console.Write("Ingrese el 1º numero: ");
                double primerOperando = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el 2º numero: ");
                double segundoOperando = double.Parse(Console.ReadLine());

                double resultado = Calculadora.Calcular(primerOperando, segundoOperando, opcion);
                Console.WriteLine($"El resultado es: {resultado}");

                Console.Write("Desea realizar otra operacion? (s/n): ");
                string respuesta = Console.ReadLine();

                if (respuesta.ToLower() == "n")
                {
                    break;
                }
            }                       
        }
    }

    class Calculadora
    {
        public static double Calcular(double primerOperando, double segundoOperando, int operacion)
        {
            double resultado = 0;

            switch (operacion)
            {
                case 1:
                    resultado = primerOperando + segundoOperando;
                    break;

                case 2:
                    resultado = primerOperando - segundoOperando;
                    break;

                case 3:
                    resultado = primerOperando * segundoOperando;
                    break;

                case 4:
                    if (Validar(segundoOperando))
                    {
                        resultado = primerOperando / segundoOperando;
                    }
                    else
                    {
                        Console.WriteLine("ERROR, no es posible dividir por 0!");
                        resultado = Double.NaN;
                    }
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;
            }

            return resultado;
        }

        private static bool Validar(double operando)
        {
            if (operando != 0)
            {
                return true;
            }

            return false;
        }
    }
}
