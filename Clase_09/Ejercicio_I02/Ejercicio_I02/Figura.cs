namespace Ejercicio_I02
{
    public abstract class Figura 
    {
        public virtual string Dibujar() => "Dibujando forma...";

        public abstract double CalcularSuperficie();

        public abstract double CalcularPerimetro();
    }
}