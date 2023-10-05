namespace Grados
{
    public class Kelvin
    {
        //Para convertir de K a ºF use la fórmula: ºF = 1.8(K – 273.15) + 32.
        //Para convertir de K a ºC use la fórmula = ºC = ºK - 273
        public double ConvertirAFahrenheit(double gKelvin)
        {
            double gFahrenheit = 1.8 * (gKelvin - 273.15) + 32;
            return gFahrenheit;
        }

        public double ConvertirACelcius(double gKelvin)
        {
            double gCelcius = gKelvin - 273;
            return gCelcius;
        }
    }
}
