/*
 * Namespaces
 */

using System;
using Lesson15.Model;

namespace Lesson15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 15");

            var brendan = new Person { Name = "Brendan" };
            Console.WriteLine($"Hola {brendan.Name}!");

            Console.WriteLine("Final Lesson 15");
            Console.Read();

        }
    }
}
