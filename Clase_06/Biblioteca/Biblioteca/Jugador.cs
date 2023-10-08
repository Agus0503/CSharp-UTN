using System.Text;

namespace Biblioteca
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;

        private Jugador()
        { 
            partidosJugados = 0;
            totalGoles = 0;
        }

        public Jugador(int dni, string nombre):this()
        {
            this.dni = dni;
            this.nombre = nombre;            
        }

        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }

        public float GetPromedioGoles()
        {
            return (float) totalGoles / partidosJugados;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new ();            

            sb.AppendLine($"Dni: {dni}" +
                          $"\nNombre: {nombre}" +
                          $"\nPartidos jugados: {partidosJugados}" +
                          $"\nTotal goles: {totalGoles}" +
                          $"\nPromedio goles: {GetPromedioGoles()}");

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.dni == j2.dni);            
        }
    }
}