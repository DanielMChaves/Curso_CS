/*
 * Recorrer elementos de una Colección
 */

using System;
using System.Collections.Generic;

namespace Lesson10
{
    public class Program
    {

        /*
        * Ejercicio:
        *   Usando un bucle, crea una lista inicializada y que se 
        *   imprima el siguiente contenido:
        *       Numbers: 2 4 6
        *       Sum: 12
        */
        static void Exercise()
        {

            var numbers = new List<int>() { 2, 4, 6 };
            var total = 0;

            Console.Write("Números:");
            foreach(var number in numbers)
            {
                Console.Write($" {number}");
                total += number;
            }
            Console.WriteLine();

            Console.WriteLine($"Sumatorio: {total}");
        }

        static void BucleForeach()
        {
            var myList = new List<string>() { "one", "two", "three" };
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }

        static void OtrasTecnicas()
        {
            // List<T>
            var myList = new List<int>() { 43, 55, 100 };
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            // Array
            int[] numbers = new[] { 2, 3, 5, 7 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // Bucle While con Indice
            var myListWhile = new List<int>() { 10, 20, 30 };
            int index = 0;
            while (index < myListWhile.Count)
            {
                Console.WriteLine(myListWhile[index]);
                index++;
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Lesson 10");

            /*
             * Bucle FOREACH
             */
            BucleForeach();

            // Lectura de los parámetros del programa
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }

            /*
             * Otras Técnicas
             */
            OtrasTecnicas();

            // Ejercicio
            Exercise();

            Console.WriteLine("Final Lesson 10");
            Console.Read();
        }
    }
}
