/*
 * Trabajando con Strings 
 */

using System;

namespace Lesson3
{
    public class Program
    {

        /*
         * Ejercicio:
         *  Imprimir un saludo con diferentes variables
         *  y con diferentes salidas de consola
         */
        static void Exercise()
        {

            string hello = "Hola";
            string name = Console.ReadLine();

            Console.WriteLine($"{hello} {name}!");
            Console.WriteLine(hello + " " + name + "!");

        }

        public static void Main()
        {
            Console.WriteLine("Lesson 3");

            /*
             * Vacio o nulo
             */

            string string1; // Valor actual: null
            string1 = "Hola";

            string string2 = "Hola";

            Console.WriteLine(string1);
            Console.WriteLine(string2);

            string emptyString = String.Empty;
            string nullString = null;

            Console.WriteLine(emptyString); // No imprime nada
            Console.WriteLine(nullString); // No imprime nada

            // Al ser un string vacio, imprime 0
            Console.WriteLine($"El tamaño del primer string es: {emptyString.Length}");

            // Esta linea produce una excepción a realizar un método sobre un elemento null
            // Console.WriteLine($"El tamaño del segundo string es: {nullString.Length}");

            /*
             * Operaciones con Strings
             */

            // Combinación
            string one = "abc";
            string two = "123";
            string combined = one + two; // "abc123"

            // Mayusculas y minusculas
            string original = "Test string";
            string capital = original.ToUpper(); // TEST STRING
            string lower = original.ToLower(); // test string

            // Manipulación
            string input = " Steve "; // Tiene un espacio al principio y al final
            string clean1 = input.TrimStart(); // "Steve "
            string clean2 = input.TrimEnd(); // " Steve"
            string clean3 = input.Trim(); // "Steve"
            string shortversion = input.Trim().Substring(0, 3); // "Ste"

            /*
             * Reemplazar partes de los Strings
             */

            string name = "Steve";
            // Similar a BASH
            string greet1 = $"Hello {name}!"; // Hello Steve!
            // Similar a Java
            string greet2 = "Hello " + name + "!"; // Hello Steve!
            // Similar a C
            string greet3 = String.Format("Hello {0}!", name); // Hello Steve!
            // How knows
            string greetTemplate = "Hello **NAME**!";
            string greet4 = greetTemplate.Replace("**NAME**", name); // Hello Steve!

            // Ejercicio
            Exercise();

            Console.WriteLine("Final Lesson 3");
            Console.Read();
        }
    }
}
