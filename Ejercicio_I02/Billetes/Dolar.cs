namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        public Dolar() { }

        static Dolar()
        {
            cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public double GetCantidad() => cantidad;
        public static double GetCotizacion() => cotzRespectoDolar;
                
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.GetCantidad() / Euro.GetCotizacion());
        }

        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d.GetCantidad() * Peso.GetCotizacion());
        }

    }
}