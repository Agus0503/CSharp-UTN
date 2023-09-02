using System;

namespace Ejercicio_05A01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Conductor conductor1 = new Conductor("Juan Pérez", new int[] { 200, 599, 899, 0, 256, 0, 0 });
            Conductor conductor2 = new Conductor("Pedro López", new int[] { 100, 200, 300, 0, 400, 0, 0 });
            Conductor conductor3 = new Conductor("José García", new int[] { 300, 600, 900, 0, 500, 0, 0 });

            Empresa empresa = new Empresa(new Conductor[] { conductor1, conductor2, conductor3 });
                        
            Console.WriteLine($"El conductor que hizo más km en esa semana es: {empresa.ConductorConMasKilometros().nombre}");                    
            Console.WriteLine($"El conductor que hizo más km el día 3 es: {empresa.ConductorConMasKilometrosDia(3).nombre}");                        
            Console.WriteLine($"El conductor que hizo más km el día 5 es: {empresa.ConductorConMasKilometrosDia(5).nombre}");

            Console.ReadKey();
        }
    }
}
