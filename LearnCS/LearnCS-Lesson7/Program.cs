/*
 * Expresiones Lógicas y Bucles
 */

using System;

namespace Lesson7
{
    public class Program
    {

        /*
        * Ejercicio:
        */
        static void Exercise()
        {

            Console.WriteLine("Escribe un número:");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Factor: ");

            if (number > 1) // convert this to while
            {
                int candidateFactor = 2;

                if (candidateFactor <= number) // convert this to while
                {
                    if (number % candidateFactor == 0) // found a factor
                    {
                        Console.Write(candidateFactor);
                        // divide number by the factor you found and assign this back to number
                        // print a comma if number is still greater than 1
                    }
                    // don't forget to increment factor!
                }
            }
            Console.WriteLine();

        }

        static void BubleBasico()
        {
            // Generamos un número del 1 al 100
            int numberToGuess1 = new Random().Next(1, 101);
            // Empezamos con un número incorrecto
            int currentGuess1 = 0;

            while (currentGuess1 != numberToGuess1)
            {
                Console.WriteLine("Escribe un número (1 al 100): ");
                currentGuess1 = int.Parse(Console.ReadLine());
                if (currentGuess1 < numberToGuess1)
                {
                    Console.WriteLine("El número es muy bajo! Prueba otra vez!");
                }
                if (currentGuess1 > numberToGuess1)
                {
                    Console.WriteLine("El número es muy alto! Prueba otra vez!");
                }
            }
            Console.WriteLine("Correcto!");
        }

        static void BucleInfinito()
        {
            // Generamos un número del 1 al 100
            int numberToGuess2 = new Random().Next(1, 101);

            // Al ser la condición 'true' siempre se ejecuta el bucle
            while (true)
            {
                Console.WriteLine("Escribe un número (1 al 100): ");
                int currentGuess2 = int.Parse(Console.ReadLine());

                if (currentGuess2 == numberToGuess2) break;
                if (currentGuess2 < numberToGuess2)
                {
                    Console.WriteLine("El número es muy bajo! Prueba otra vez!");
                }
                if (currentGuess2 > numberToGuess2)
                {
                    Console.WriteLine("El número es muy alto! Prueba otra vez!");
                }
            }
            Console.WriteLine("Correcto!");
        }

        public static void Main()
        {
            Console.WriteLine("Lesson 7");

            /*
             * Expresiones para Bucles
             */

            // Bucle Básico
            //BubleBasico();

            // Bucle Infinito
            //BucleInfinito();

            // Ejercicio
            Exercise();

            Console.WriteLine("Final Lesson 7");
            Console.Read();
        }
    }
}
