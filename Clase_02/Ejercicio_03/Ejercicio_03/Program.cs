using System;
using System.Text;

/*
    Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):
    El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.    
    El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.    
*/

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string binario = Conversor.ConvertirDecimalABinario(9);

            Console.WriteLine(binario);

            int numero = Conversor.ConvertirBinarioADecimal(10011010);

            Console.WriteLine(numero);
            Console.Read();
        }
    }

    class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            StringBuilder resto = new StringBuilder();
            StringBuilder binario = new StringBuilder();

            if (numeroEntero > 0)
            {
                do
                {
                    resto.Append(numeroEntero % 2);
                    numeroEntero = numeroEntero / 2;
                } while (numeroEntero > 0);

                for (int i = resto.Length - 1; i >= 0; i--)
                {
                    binario.Append(resto[i]);
                }
            }
            return binario.ToString();
        }
        

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            int numero = 0;
            int potencia = 0;

            string binario = numeroEntero.ToString();

            for (int i = binario.Length - 1; i >= 0; i--)
            {
                if (binario[i] == '1')
                {
                    numero += (int)Math.Pow(2, potencia);
                }
                potencia++;
            }

            return numero;
        }                
    }
}
