namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Euro()
        {
            cotzRespectoDolar = 1.17;
        }

        public Euro() { }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion): this(cantidad) 
        {           
            cotzRespectoDolar = cotizacion;
        }

        public double GetCantidad() => cantidad;
        public static double GetCotizacion() => cotzRespectoDolar;

        public static explicit operator Peso(Euro e)
        {
            return new Peso(e.GetCantidad() * Peso.GetCotizacion() / Dolar.GetCotizacion());
        }

        public static explicit operator Dolar(Euro euroCurrency)
        {
            Dolar dolarCurrency = new Dolar(euroCurrency.GetCantidad() * GetCotizacion());
            return dolarCurrency;
        }
    }
}
