using System;
using System.Text;

namespace Ejercicio_02
{
    class Persona
    {
        string nombre;
        DateTime fechaDeNacimiento;
        int dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public string GetNombre() => nombre;
        public string GetFechaDeNacimiento() => fechaDeNacimiento.ToString();
        public int GetDni() => dni;
        public int GetEdad() => CalcularEdad(fechaDeNacimiento);

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetFechaDeNacimiento(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public void SetDni(int dni)
        {
            this.dni = dni;
        }

        private int CalcularEdad(DateTime fechaDeNacimiento)
        {
            DateTime fechaActual = DateTime.Now;

            TimeSpan diferenciaDeFechas = fechaActual - fechaDeNacimiento;
            int edadEnDias = diferenciaDeFechas.Days;
            int edadEnAños = edadEnDias / 365;

            return edadEnAños;
        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Nombre: {nombre}" +
                      $"\nEdad: {CalcularEdad(fechaDeNacimiento)}" +
                      $"\nFecha de nacimiento: {fechaDeNacimiento:yyyy/MM/dd}" +
                      $"\nDni: {dni}");

            return sb.ToString();
        }

        public string EsMayorDeEdad(string fechaDeNacimiento)
        {
            DateTime date = DateTime.Parse(fechaDeNacimiento);

            int edad = CalcularEdad(date);

            if (edad >= 18)
            {
                return "Es mayor de edad";
            }

            return "Es menor";
        }
    }
}
