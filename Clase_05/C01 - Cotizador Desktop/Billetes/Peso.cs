namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Peso()
        {
            cotzRespectoDolar = 102.65;
        }

        public Peso() { }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion):this(cantidad) 
        {            
            cotzRespectoDolar = cotizacion;
        }

        public double GetCantidad() => cantidad;
        public static double GetCotizacion() => cotzRespectoDolar;

        public static explicit operator Euro(Peso peso)
        {
            return (Euro)(Dolar)peso;
        }

        public static explicit operator Dolar(Peso peso)
        {
            return new Dolar(peso.cantidad / cotzRespectoDolar);
        }
    }
}
