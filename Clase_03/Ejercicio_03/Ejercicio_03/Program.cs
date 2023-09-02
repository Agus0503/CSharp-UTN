using System;
using System.Text;

/*
    La clase Estudiante:

    Tendrá un constructor estático que inicializará el atributo estático random.
    Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
    El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
    El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
    El método privado CalcularPromedio retornará el promedio de las dos notas.
    El método CalcularNotaFinal deberá retornar la nota del final con un numero aleatorio entre 6 y 10 incluidos 
     siempre y cuando las notas del primer y segundo parcial sean mayores o iguales a 4, caso contrario la
     inicializará con el valor -1.
    El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
    Nombre, apellido y legajo.
    Nota del primer y segundo parcial.
    Promedio.
    Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".

    1.Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
    2.Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
    3.Mostrar los datos de todos los alumnos
*/

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudianteUno = new Estudiante("Martin", "Velazquez", "ZHCYJK");
            Estudiante estudianteDos = new Estudiante("Alan", "Rodriguez", "KYUZHT");
            Estudiante estudianteTres = new Estudiante("Pablo", "Fernandez", "POQALX");

            estudianteUno.SetNotaPrimerParcial(4);
            estudianteUno.SetNotaSegundoParcial(6);

            estudianteDos.SetNotaPrimerParcial(2);
            estudianteDos.SetNotaSegundoParcial(6);

            estudianteTres.SetNotaPrimerParcial(6);
            estudianteTres.SetNotaSegundoParcial(8);

            Console.WriteLine(estudianteUno.Mostrar());
            Console.WriteLine(estudianteDos.Mostrar());
            Console.WriteLine(estudianteTres.Mostrar());

            Console.ReadKey();
        }
    }

    class Estudiante
    {
        private string nombre;
        private string apellido;
        private string legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            notaSegundoParcial = nota;
        }

        private float CalcularPromedio() => (notaPrimerParcial + notaSegundoParcial) / 2;

        public double CalcularNotaFinal()
        {
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4) 
            {
                return random.Next(6, 10);
            }

            return -1;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            string notaFinal;

            if (CalcularNotaFinal() == -1)
            {
                notaFinal = "Alumno desaprobado";
            }
            else
            {
                notaFinal = CalcularNotaFinal().ToString();
            }

            sb.Append($"Nombre: {nombre}\n" +
                      $"Apellido: {apellido}\n" +
                      $"Legajo: {legajo}\n" +
                      $"Nota primer parcial: {notaPrimerParcial}\n" +
                      $"Nota segundo parcial: {notaSegundoParcial}\n" +
                      $"Promedio: {CalcularPromedio()}\n" +
                      $"Nota final: {notaFinal}\n");

            return sb.ToString();
        }
        
    }
}
