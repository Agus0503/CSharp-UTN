using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Equipo
    {
        private short cantidadJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo() 
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidadJugadores, string nombre):this()
        {
            this.cantidadJugadores = cantidadJugadores;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            if (!e.jugadores.Contains(j) && e.jugadores.Count < e.cantidadJugadores)
            {
                e.jugadores.Add(j);
                return true; 
            }

            return false;
        }
    }
}
