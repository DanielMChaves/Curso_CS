/*
 * Tipos y Variables 
 */

using System;

namespace Lesson2
{
    public class Program
    {

        /*
         * Ejercicio:
         *  Imprimir diferentes lineas por la consola utilizando variables
         *  Algunas que funciones y otras que produzcan errores
         */
        static void Exercise()
        {

            var msg = "que tengas un buen día!";
            // MAL: No se expande la variable
            Console.WriteLine("Hola, {msg}");
            // BIEN: Se expande la variable correctamente
            Console.WriteLine($"Hola, {msg}");
            Console.WriteLine("Hola" + msg);
        }

        public static void Main()
        {
            Console.WriteLine("Lesson 2");

            var name = "Daniel";

            // Expansión de una variable
            Console.WriteLine($"Hello {name}!");

            // Ejercicio
            Exercise();

            Console.WriteLine("Final Lesson 2");
            Console.Read();
        }
    }
}
