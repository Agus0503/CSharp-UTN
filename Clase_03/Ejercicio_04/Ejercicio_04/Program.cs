﻿using System;

/*
    La cantidad máxima de tinta para todos los bolígrafos será de 100. Generar una constante 
     cantidadTintaMaxima en Boligrafo donde se guardará dicho valor.
    Generar los métodos getter GetColor y GetTinta para los correspondientes atributos (sólo retornarán el valor de los mismos).
    Generar un método setter privado SetTinta que valide el nivel de tinta y, si es válido, modifique el valor del atributo tinta.
     El argumento tinta contedrá la cantidad de tinta a agregar o quitar. Podrá ser positivo (cargar tinta) o negativo (gastar tinta).
     Se deberá validar que el nivel de tinta resultante sea mayor o igual a cero y menor o igual a cantidadTintaMaxima. 
     Si no es válido, no se deberá modificar el atributo ni realizar ninguna acción.
    El método Recargar colocará la tinta en su nivel máximo. Reutilizar código.
    El método Pintar restará la tinta gastada (reutilizar código). El parámetro gasto representará la cantidad de unidades 
     de tinta a utilizar y utilizará tanta tinta como tenga disponible sin quedar en negativo.
     Utilizando el parámetro dibujo informará el resultado retornando tantos * como unidades de tinta haya gastado, por ejemplo:
        Si no había nada de tinta retornará una cadena de texto vacía.
        Si el nivel de tinta era 10 y la cantidad a gastar 2, entonces retonará **.
        Si el nivel de tinta era 3 y la cantidad a gastar 10, entonces retornará ***.
    
    Agregar un proyecto de consola.
    En el método Main, crear un bolígrafo de tinta azul (ConsoleColor.Blue) y una cantidad inicial de tinta 
     de 100 y otro de tinta roja (ConsoleColor.Red) y 50 de tinta.
    Utilizar todos los métodos y mostrar los resultados por consola.
    Al utilizar el método Pintar, si corresponde, se deberá dibujar por pantalla con el color de dicho bolígrafo.
*/

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);

            Console.WriteLine("Bolígrafo azul:");
            Console.WriteLine("Color: {0}", boligrafoAzul.GetColor());
            Console.WriteLine("Tinta: {0}", boligrafoAzul.GetTinta());

            boligrafoAzul.Recargar();

            Console.WriteLine("Bolígrafo azul recargado:");
            Console.WriteLine("Color: {0}", boligrafoAzul.GetColor());
            Console.WriteLine("Tinta: {0}", boligrafoAzul.GetTinta());

            string dibujo;
            Console.WriteLine("Cantidad de * que se pueden pintar con el bolígrafo azul:");
            Console.WriteLine(boligrafoAzul.Pintar(50, out dibujo));

            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);

            Console.WriteLine("Bolígrafo rojo:");
            Console.WriteLine("Color: {0}", boligrafoRojo.GetColor());
            Console.WriteLine("Tinta: {0}", boligrafoRojo.GetTinta());

            Console.WriteLine("Cantidad de * que se pueden pintar con el bolígrafo rojo:");
            Console.WriteLine(boligrafoRojo.Pintar(100, out dibujo));

            Console.ReadKey();
        }
    }

    class Boligrafo
    {
        private const short CantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color = color;
            SetTinta(tinta);
        }

        public ConsoleColor GetColor() => color;
        public short GetTinta() => tinta;

        private void SetTinta(short nuevaTinta)
        {
            if (nuevaTinta >= 0 && nuevaTinta <= CantidadTintaMaxima)
            {
                tinta = nuevaTinta;
            }
        }

        public void Recargar()
        {
            SetTinta(CantidadTintaMaxima);
        }

        public string Pintar(short gasto, out string dibujo)
        {
            dibujo = "";

            if (tinta >= gasto)
            {
                tinta -= gasto;
                dibujo = new string('*', gasto);
            }

            return dibujo;
        }
    }
}
