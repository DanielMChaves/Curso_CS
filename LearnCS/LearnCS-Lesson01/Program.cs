/*
 * Programa Hola Mundo 
 */

using System;

namespace Lesson1
{
    public class Program
    {

        /*
         * Ejercicio:
         *  Imprimir diferentes lineas por la consola
         *  Algunas que funciones y otras que produzcan errores
         */
        static void Exercise()
        {
            // MAL: String no cerrado
            // Console.WriteLine("Hola);
            // BIEN: String cerrado
            Console.WriteLine("Hola");
        }

        public static void Main()
        {
            Console.WriteLine("Lesson 1");
            // Salida por la "consola" de Debug
            // System.Diagnostics.Debug.WriteLine("Hello World!");

            // Salida por la consola (cmd)
            Console.WriteLine("Hello World!");

            // Ejercicio
            Exercise();

            Console.WriteLine("Final Lesson 1");
            Console.Read();
        }
    }
}
