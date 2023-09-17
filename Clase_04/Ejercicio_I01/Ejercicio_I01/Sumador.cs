namespace Ejercicio_I01
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas) => this.cantidadSumas = cantidadSumas;
        public Sumador() : this(0) { }

        public long Sumar(long valorUno, long valorDos)
        {
            cantidadSumas++;
            return valorUno + valorDos; 
        }

        public string Sumar(string a, string b)
        {
            cantidadSumas++;
            if (string.IsNullOrEmpty(a) && string.IsNullOrEmpty(b))
            {
                return string.Empty;
            }

            if (string.IsNullOrEmpty(a))
            {
                return b;
            }
            
            if (string.IsNullOrEmpty(b))
            {
                return a;
            }

            return a + b;
        }

        public int GetCantidadDeSumas() => cantidadSumas;

        public static implicit operator int(Sumador sumador) => sumador.cantidadSumas;
        public static Sumador operator +(Sumador sumador1, Sumador sumador2)
        {
            return new Sumador(sumador1.cantidadSumas + sumador2.cantidadSumas);
        }
        public static bool operator |(Sumador sumador1, Sumador sumador2)
        {
            return sumador1.cantidadSumas == sumador2.cantidadSumas;
        }
    }
}
