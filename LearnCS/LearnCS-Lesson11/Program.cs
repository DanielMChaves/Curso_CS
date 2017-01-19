/*
 * Definición y Llamadas a Métodos
 */

using System;

namespace Lesson11
{
    // Para realizar métodos de extensión
    // La clase debe ser estática
    public static class Program
    {

        static string FirstName;
        static string LastName;

        /*
         * Declaración de Métodos
         */

        static int Add(int operand1, int operand2)
        {
            // only works with its own parameters; works well as static method
            return operand1 + operand2;
        }
        static string FullName()
        {
            // FirstName and LastName are Properties of this class - shouldn't be static
            return $"{FirstName} {LastName}";
        }

        /*
         * Nombrado de Métodos
         */

        static void DisplayHeader()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("**** Mi super programa*******************");
            Console.WriteLine("-----------------------------------------");
        }

        static void DisplayMenu()
        {
            Console.WriteLine("¿Qué quieres hacer?");
            Console.WriteLine("1 - Ver el menú");
            Console.WriteLine("2 - Salir del programa");
        }

        /*
         * Returns
         */

        static string CreateGreeting(string name)
        {
            return $"Hi {name}!";
        }

        static void DisplayGreeting()
        {
            Console.WriteLine(CreateGreeting("Steve"));
        }

        /*
         * Parámetros
         */
        static string GetValue(string fileName)
        {
            return fileName;
        }
        /*
        int GetValue(string versionNumber)
        {
            return Int16.Parse(versionNumber);
        }
        */
        static string CreateGreeting2(string name = "You")
        {
            return $"Hi {name}!";
        }

        /*
         * Sobrecargas
         */
        static string CreateGreeting()
        {
            return CreateGreeting3("You");
        }
        static string CreateGreeting3(string name)
        {
            return $"Hi {name}!";
        }

        static int SecondsRemaining(DateTime endTime)
        {
            return SecondsRemaining(endTime - DateTime.Now);
        }

        static int SecondsRemaining(string endTime)
        {
            return SecondsRemaining(DateTime.Parse(endTime));
        }

        static int SecondsRemaining(TimeSpan duration)
        {
            return (int)duration.TotalSeconds;
        }

        /*
         * Métodos de Extensión
         */
        public static int PlusFive(this int input)
        {
            return input + 5;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Lesson 11");

            /*
            * Expresiones Lambda
            */
            const int four = 4;
            Func<int, int> addOne = x => x + 1;
            Func<int, int, int> calcArea = (x, y) => x * y; // 2 Parámetros
            Func<int> twentyFive = () => calcArea(addOne(four), addOne(four)); // Sin Parámetros
            Console.WriteLine(twentyFive());

            /*
             * Métodos de Extensión
             */
            int luckyNumber = 10;
            Console.WriteLine(luckyNumber); // Will output 10
            int result = luckyNumber.PlusFive();
            Console.WriteLine(result); // Will output 15

            Console.WriteLine("Final Lesson 11");
            Console.Read();
        }
    }
}
