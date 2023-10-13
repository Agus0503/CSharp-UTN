namespace Ejercicio_I01
{
    public class Automovil : VehiculoTerrestre
    {        
        public short cantidadMarchas;
        public int cantidadPasajeros;

        public Automovil(short cantidadMarchas, int cantidadPasajeros, short cantidadPuertas, short cantidadRuedas, Color color): base(cantidadPuertas, cantidadRuedas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }
    }
}