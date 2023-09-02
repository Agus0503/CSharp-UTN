using System;

/*
    Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

    Deberá tener los atributos:

    nombre
    fechaDeNacimiento
    dni
    Deberá tener un constructor que inicialice todos los atributos.

    Construir los siguientes métodos para la clase:

    -Setter y getter para cada uno de los atributos.
    -CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
    -Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
    -EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
    
    Instanciar 3 objetos de tipo Persona en el método Main.
    Mostrar quiénes son mayores de edad y quiénes no. 
*/

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona personaUno = new Persona("Agustin", new DateTime(2003, 05, 24), 99999999);
            Persona personaDos = new Persona("Alan", new DateTime(2012, 02, 23), 99999999);
            Persona personaTres = new Persona("Victor", new DateTime(1998, 09, 19), 99999999);

            string datePersonaUno = personaUno.EsMayorDeEdad(personaUno.GetFechaDeNacimiento());
            string datePersonaDos = personaDos.EsMayorDeEdad(personaDos.GetFechaDeNacimiento());
            string datePersonaTres = personaTres.EsMayorDeEdad(personaTres.GetFechaDeNacimiento());

            Console.WriteLine($"{personaUno.GetNombre()}: {datePersonaUno}" +
                              $"\n{personaDos.GetNombre()}: {datePersonaDos}" +
                              $"\n{personaTres.GetNombre()}: {datePersonaTres}");

            Console.ReadKey();
        }
    }
}
