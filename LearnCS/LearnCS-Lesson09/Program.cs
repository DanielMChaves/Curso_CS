/*
 * Arrays y Colecciones
 */

using System;
using System.Collections.Generic;

namespace Lesson9
{
    public class Program
    {

        /*
        * Ejercicio:
        *   Hacer un programa que lea de la consola tres posibles acciones:
        *   "+ item" --> Añadir un elemento a la lista
        *   "- item" --> Eliminar un elemento de la lista
        *   "--" --> Vaciar la lista
        */
        static void Exercise()
        {
            List<string> list = new List<string>();

            while (true)
            {
                Console.WriteLine("Ponga un comando (+ elemento, - elemento, -- para vaciar):");
                var action = Console.ReadLine();

                if (action.Trim().Substring(0, 2).Equals("+ "))
                {
                    var element = action.Trim().Substring(2);
                    Console.WriteLine($"Añadimos a la lista el elemento: {element}");
                    list.Add(element);
                }
                else if (action.Trim().Substring(0, 2).Equals("- "))
                {
                    var element = action.Trim().Substring(2);
                    Console.WriteLine($"Eliminamos de la lista el elemento: {element}");
                    list.Remove(element);
                }
                else if (action.Trim().Substring(0, 2).Equals("--"))
                {
                    Console.WriteLine("Vaciamos la lista");
                    list.Clear();
                }
                else
                {
                    break;
                }

            }

        }

        static void ArraysDeclararion()
        {
            // Array vacia de tamaño 3
            int[] someIntegers = new int[3]; 
            // Array de tamaño 5 inicializada
            int[] moreIntegers = new int[] { 1, 2, 3, 4, 5 };
            // Array declarado de otra manera
            int[] otherIntegers = new[] { 1, 3, 5, 7, 9 };

            // Matriz de 2 x 6
            int[,] eggCarton = new int[2, 6];
            // Matriz inicializada
            int[,] someTable = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Definimos el tamaño
            int[][] jaggedArray = new int[4][];
            // Añadimos valores al primer Array
            jaggedArray[0] = new int[2] { 1, 2 };

        }

        static void ArraysWorking()
        {
            int[] someIntegers = { 1, 2, 3 };

            int x = 1 + someIntegers[0]; // x = 2
            int y = 2 * someIntegers[2]; // y = 6
            someIntegers[2] = y; // someIntegers tiene { 1, 2, 6 }
            // someIntegers[3] = 3; // EXCEPCIÓN: IndexOutOfRangeException

            // Introduce los elementos que están separados por comas
            string input = "red,blue,yellow,green";
            string[] colors = input.Split(',');

            // Imprime los elementos del Array separado por '|'
            string output = String.Join(" | ", colors);
            Console.WriteLine(output);
        }

        static void ListsDeclaration()
        {
            // Lista vacia
            List<int> someInts = new List<int>(); // declares an empty list
            // Añadimos a la lista el elemento 2
            someInts.Add(2);

            // Lista inicializada
            List<int> moreInts = new List<int>() { 2, 3, 4 };

            // Creamos un Array de colores
            string[] colors = "red,blue,yellow,green".Split(',');
            // Inicializamos una lista a partir de un Array
            List<string> colorList = new List<string>(colors);
        }

        static void ListsWorking()
        {
            // Creamos la lista
            List<string> colors = new List<string>() { "black", "white", "gray" };
            // Eliminamos el color negro
            colors.Remove("black");
            // Insertamos el 'orange' en la posición 0
            colors.Insert(0, "orange");
            // Eliminamos todos los elementos que contengan una 't'
            colors.RemoveAll(c => c.Contains("t"));
            // Eliminamos el primer elemento
            colors.RemoveAt(0);
            // Obtenemos el tamaño de la lista
            int numColors = colors.Count;
            // Vaciamos la lista
            colors.Clear();

            var colors2 = new List<string>() { "blue", "green", "yellow" };
            // Similar a ForEach(c => Console.WriteLine(c))
            colors2.ForEach(Console.WriteLine);

            var colors3 = new List<string>() { "blue", "green", "yellow" };
            Console.WriteLine(String.Join(",", colors3));
        }

        public static void Main()
        {
            Console.WriteLine("Lesson 9");

            /*
             * Arrays
             */
            ArraysDeclararion();
            ArraysWorking();

            /*
             * Listas
             */
            ListsDeclaration();
            ListsWorking();

            // Ejercicio
            Exercise();

            Console.WriteLine("Final Lesson 9");
            Console.Read();
        }
    }
}
