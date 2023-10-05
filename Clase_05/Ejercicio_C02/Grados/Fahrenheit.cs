namespace Grados
{
    public class Fahrenheit
    {
        /*
         * Para convertir de ºF a ºC use la fórmula: ºC = (ºF-32) ÷ 1.8. 
         * Para convertir de ºF a K use la fórmula: K = 5/9 (ºF – 32) + 273.15
         */
        public double ConvertirACelcius(double gFahrenheit)
        {
            double gCelcius = (gFahrenheit - 32) / 1.8;
            return gCelcius;
        }

        public double ConvertirAKelvin(double gFahrenheit)
        {
            double gKelvin = ((gFahrenheit - 32) * 5/9) + 273.15;
            return gKelvin;
        }
    }
}