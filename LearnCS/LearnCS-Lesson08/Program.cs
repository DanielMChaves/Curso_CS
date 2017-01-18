/*
 * Número de iteraciones en los bucles
 */

using System;

namespace Lesson8
{
    public class Program
    {

        /*
        * Ejercicio:
        *   Realizar 4 bucles con las siguientes salidas:
        *       - 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24 
        *       - 0,2,4,6,8,10,12,14,16,18,20,22,24 
        *       - 0,3,6,9,12,15,18,21,24 
        *       - 0,4,8,12,16,20,24
        */
        static void Exercise()
        {

            Console.WriteLine("Bucle 1");
            for (int i = 0; i < 25; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            Console.WriteLine("Bucle 2");
            for (int i = 0; i < 25; i += 2)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            Console.WriteLine("Bucle 3");
            for (int i = 0; i < 25; i += 3)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            Console.WriteLine("Bucle 4");
            for (int i = 0; i < 25; i += 4)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

        }

        static void BuclesFor()
        {
            Console.WriteLine("Bucle de 0 a 9");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Bucle de 1 a 9");
            for (int j = 1; j < 10; j++)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine("Bucle de startingNumber a endingNumber");
            int startingNumber = 5; // Número de Inicio
            int endingNumber = 25; // Número de Fin

            for (int i = startingNumber; i <= endingNumber; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Bucle de 1 a 49 con incremento 2");
            for (int i = 1; i < 50; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Bucle de 10 a 1 con decremento 1");
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Tabla de Multiplicar:");
            Console.WriteLine("     1  2  3  4  5  6  7  8  9");
            for (int i = 1; i < 10; i++)
            {
                Console.Write($" {i} ");
                for (int j = 1; j < 10; j++)
                {
                    string product = (i * j).ToString();
                    Console.Write(product.PadLeft(3));
                }
                Console.WriteLine();
            }

        }
        
        public static void Main()
        {
            Console.WriteLine("Lesson 8");

            /*
             * Bucle FOR
             */
            BuclesFor();

            // Ejercicio
            Exercise();

            Console.WriteLine("Final Lesson 8");
            Console.Read();
        }
    }
}
