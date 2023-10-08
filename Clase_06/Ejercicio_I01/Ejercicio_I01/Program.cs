/*
    Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) 
    distintos de cero de forma aleatoria utilizando la clase Random.

    Mostrar el vector tal como fue ingresado.
    Luego mostrar los positivos ordenados en forma decreciente.
    Por último, mostrar los negativos ordenados en forma creciente. 
*/

class Program
{
    public static void Main(string[] args)
    {
        int[] numeros = new int[20];
        List<int> positivos = new();
        List<int> negativos = new();

        Random numeroRand = new();

        for (int i = 0; i < numeros.Length; i++)
        {
            int numero = numeroRand.Next(-100, 100);
            
            if (numero != 0)
            {
                numeros[i] = numero;
                if (numero > 0)
                {
                    positivos.Add(numero);
                }
                else
                {
                    negativos.Add(numero); 
                }
            }
            else
            {
                i--;
            }
        }

        Console.WriteLine("Todos: ");
        MostrarElementos(numeros);

        Console.WriteLine("Positivos: ");
        MostrarElementos(positivos);

        Console.WriteLine("Negativos: ");
        negativos = negativos.OrderBy(numero => numero).ToList();
        MostrarElementos(negativos);

    }

    public static void MostrarElementos(int[] array)
    {        
        foreach (int numero in array)
        {
            Console.WriteLine("{0}", numero);
        }    
    }

    public static void MostrarElementos(List<int> ints)
    {
        foreach (int numero in ints)
        {
            Console.WriteLine("{0}", numero);
        }
    }    
}