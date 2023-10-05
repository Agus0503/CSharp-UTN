namespace Grados
{
    public class Celcius
    {
        //Para convertir de ºC a ºF use la fórmula: ºF = ºC x 1.8 + 32. 
        //Para convertir de ºC a K use la fórmula: K = ºC + 273.15. 
        public double ConvertirAFahrenheit(double gCelcius)
        {
            double gFahrenheit = gCelcius * 1.8 + 32;
            return gFahrenheit;
        }

        public double ConvertirAKelvin(double gCelsius)
        {
            double gKelvin = gCelsius + 273.15;
            return gKelvin;
        }
    }
}
