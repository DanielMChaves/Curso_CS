/*
 * Trabajando con Decisiones
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class Program
    {

        /*
        * Ejercicio:
        *  Generar un número aleatorio y que el usuaio sepa cual es
        */
        static void Exercise()
        {

            int correctNumber = new Random().Next(4);
            Console.WriteLine("Escribe un número entre el 1 y el 3");
            int guessedNumber = int.Parse(Console.ReadLine());

            if (correctNumber.Equals(guessedNumber))
            {
                Console.WriteLine("Correcto!");
                Console.WriteLine("Has acertado el número");
            }
            else
            {
                Console.WriteLine("Incorrecto!");
                Console.WriteLine("Has fallado el número");
            }

        }

        static void Greet(string name)
        {
            if (String.IsNullOrEmpty(name)) return;

            Console.WriteLine($"Hello, {name}!");

        }

        static int Compare(int x, int y)
        {

            if (x < y)
            {
                return -1;
            }
            else
            {
                if (x == y)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }

        }

        static int Compare2(int x, int y)
        {

            if (x < y)
            {
                return -1;
            }
            else if (x == y)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }

        static void Switch(uint guessedNumber)
        {

            switch (guessedNumber)
            {
                case 0:
                    Console.WriteLine("Lo siento, 0 no es un nº válido.");
                    break;
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Elegiste un número inferior.");
                    break;
                case 4:
                    Console.WriteLine("Elegiste el número correcto!");
                    break;
                default:
                    Console.WriteLine("Elegiste un número superior.");
                    break;
            }

        }

        public static void Main()
        {
            Console.WriteLine("Lesson 5");

            /*
             * Sentencia IF y ELSE
             */

            Console.WriteLine("¿Cuál es la capital de Ohio?");
            var answer = Console.ReadLine();
            if (answer.ToLower() == "columbus")
            {
                Console.WriteLine("Correcto!");
            }
            else
            {
                Console.WriteLine("Lo siento, esa no es la respuesta correcta.");
            }

            // Anidamientos

            var resultCompare1 = Compare(1, 2);
            Console.WriteLine($"Resultado de la comparación (1): {resultCompare1}");

            var resultCompare2 = Compare2(2, 1);
            Console.WriteLine($"Resultado de la comparación (2): {resultCompare2}");

            /*
             * Sentencia SWITCH
             */

            // El tipo uint es para numeros enteros positivos
            // Switch(uint guessedNumber)

            uint guessedNumber = 10;
            Switch(guessedNumber);

            /*
             * Anexo
             */

            // Obtener un número randow del 1 al 3
            // int correctNumber = new Random().Next(4);

            // Leer de la linea de comandos un número
            // int guessedNumber = int.Parse(Console.ReadLine());

            // Ejercicio
            Exercise();

            Console.WriteLine("Final Lesson 5");
            Console.Read();
        }
    }
}
