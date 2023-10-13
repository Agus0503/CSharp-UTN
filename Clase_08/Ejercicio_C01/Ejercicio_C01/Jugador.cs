using Ejercicio_C01;
using System.Text;

namespace Biblioteca
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public Jugador(int dni, string nombre) : base(dni, nombre)
        {
            PartidosJugados = 0;
            TotalGoles = 0;
        }

        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles) : base(dni, nombre)
        {
            PartidosJugados = partidosJugados;
            TotalGoles = totalGoles;
        }

        public int PartidosJugados { get => partidosJugados; set => partidosJugados = value; }
        public int TotalGoles { get => totalGoles; set => totalGoles = value; }
        public float PromedioGoles { get => (float)TotalGoles / PartidosJugados; }

        public new string MostrarDatos()
        {
            StringBuilder sb = new ();            

            sb.AppendLine($"Dni: {Dni}" +
                          $"\nNombre: {Nombre}" +
                          $"\nPartidos jugados: {PartidosJugados}" +
                          $"\nTotal goles: {TotalGoles}" +
                          $"\nPromedio goles: {PromedioGoles}");

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.Dni == j2.Dni);            
        }
    }
}