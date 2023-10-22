using Ejercicio_I02;
using System.Text;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>
            {
                new Circulo(2),
                new Cuadrado(3),
                new Rectangulo(4, 8)
            };

            StringBuilder sb = new();

            foreach (Figura figura in figuras)
            {
                sb.AppendLine();
                sb.AppendFormat("=============== FIGURA {0:0#} ==================\n", figuras.IndexOf(figura) + 1);
                sb.AppendFormat(" Tipo: {0}\n", figura.GetType());
                sb.AppendFormat(" {0}\n", figura.Dibujar());
                sb.AppendFormat(" Área: {0:0.00}\n", figura.CalcularSuperficie());
                sb.AppendFormat(" Perímetro: {0:0.00}\n", figura.CalcularPerimetro());
                sb.AppendLine("============================================");
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}