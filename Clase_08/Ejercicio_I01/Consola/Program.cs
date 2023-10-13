using Ejercicio_I01;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Camion scania = new(8, 2, Color.Azul, 8, 5000);
            Console.WriteLine("Camion scania" +
                              $"\nCantidad Ruedas: {scania.cantidadRuedas}" +
                              $"\nCantidad Puertas: {scania.cantidadPuertas}" +
                              $"\nColor: {scania.color}" +
                              $"\nCantidad Marchas: {scania.cantidadMarchas}" +
                              $"\nPeso Carga: {scania.pesoCarga}");
            
            Console.WriteLine("-----------");
            
            Automovil miAuto = new(4, 5, 5, 3, Color.Blanco);
            Console.WriteLine("Automovil miAuto" +
                              $"\nCantidad Ruedas: {miAuto.cantidadRuedas}" +
                              $"\nCantidad Puertas: {miAuto.cantidadPuertas}" +
                              $"\nColor: {miAuto.color}" +
                              $"\nCantidad Marchas: {miAuto.cantidadMarchas}" +
                              $"\nCantidad Pasajeros: {miAuto.cantidadPasajeros}");
            
            Console.WriteLine("-----------");
            
            Moto motomel = new(2, 0, Color.Rojo, 1000);
            Console.WriteLine("Moto motomel" +
                              $"\nCantidad Ruedas: {motomel.cantidadRuedas}" +
                              $"\nCantidad Puertas: {motomel.cantidadPuertas}" +
                              $"\nColor: {motomel.color}" +
                              $"\nCilindrada: {motomel.cilindrada}");
        }
    }
}

