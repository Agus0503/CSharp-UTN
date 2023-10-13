using System.Text;

namespace Ejercicio_C01
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        private DirectorTecnico(string nombre) : base(nombre) { }                

        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public new string MostrarDatos()
        {
            StringBuilder sb = new();

            sb.AppendLine($"Nombre: {Nombre}" +                          
                          $"\nFecha de nacimiento: {fechaNacimiento.ToString("dd/MM/yyyy")}");

            return sb.ToString();
        }

        public static bool operator ==(DirectorTecnico d1, DirectorTecnico d2)
        {
            if (d1.Nombre == d2.Nombre && d1.fechaNacimiento == d2.fechaNacimiento)
            {
                return true;
            }
            
            return false;
        }

        public static bool operator !=(DirectorTecnico d1, DirectorTecnico d2)
        {
            if (!(d1.Nombre == d2.Nombre) && !(d1.fechaNacimiento == d2.fechaNacimiento))
            {
                return true;
            }

            return false;
        }
    }
}