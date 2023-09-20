using System.Text;

namespace Biblioteca
{
    public class Ingresante
    {
        string[]? cursos;
        string? direccion;
        int? edad;
        string? genero;
        string? nombre;
        string? pais;               

        public Ingresante(string[] cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }
                
        public string Mostrar()
        {
            StringBuilder sb = new();

            sb.AppendLine($"Nombre: {nombre}\n" +
                          $"Edad: {edad}\n" +
                          $"Genero: {genero}\n" +
                          $"Direccion: {direccion}\n" +
                          $"Pais: {pais}\n" +
                          $"Cursos:");            

            if (cursos != null)
            {
                foreach (string curso in cursos)
                {
                    sb.AppendLine($"{curso}");
                }
            }            

            return sb.ToString();
        }

    }
}