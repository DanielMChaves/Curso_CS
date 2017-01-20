/*
 * Cuando y Como usar Excepciones
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17
{

    class Program
    {
        
        public static int SumNumberStrings(List<string> numbers)
        {
            int total = 0;
            foreach (string numberString in numbers)
            {
                total += int.Parse(numberString);
            }
            return total;
        }

        /*
         * Crear tus propias Excepciones
         */
        public class MemberNameNotFoundException : Exception
        {
            public MemberNameNotFoundException(string memberName)
                : base($"No se puede encontrar el miembro: {memberName}.")
            { }
        }

        /*
        public int GetMemberIdByName(string memberName)
        {
            Member member = _memberList.SingleOrDefault(m => m.Name == memberName);
            if (member != null)
            {
                return member.Id;
            }
            throw new MemberNameNotFoundException(memberName);
        }
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 17");
            Console.WriteLine();

            /*
             * Conceptos Básicos de Excepciones
             */

            try
            {
                int sum = SumNumberStrings(new List<string> { "5", "4" });
                Console.WriteLine($"El sumatorio es: {sum}");
            }
            catch (System.FormatException)
            {
                // Cuando a la función 'SumNumberStrings' no se le pasan números
                // se produce una Excepción en la llamada int.Parse, por tanto la
                // Excepción es tratada y se imprime por pantalla la siguiente linea
                Console.WriteLine("La lista de números contiene elementos erroneos.");
            }
            Console.WriteLine();

            // Coger (catching) Excepciones 

            try
            {
                Console.WriteLine("Introduce un número: ");
                int x = int.Parse(Console.ReadLine());
            }
            catch (System.FormatException ex)
            {
                // Realizar operaciones aquí para tratar la excepción
  
                // Poniendo solo 'throw' la excepción para la ejecución
                throw;
                
            }

            // Lanzar Excepciones
            Console.WriteLine("Introduce una edad: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 18 || age > 150)
            {
                throw new ArgumentOutOfRangeException("La edad tiene que estar entre 18 y 150.", nameof(age));
            }

            // Bloque 'Finally'
            try
            {
            }
            catch (System.Exception ex)
            {
            }
            finally
            {
                // El código que hay aquí siempre se ejecuta, 
                // incluso si salta la excepción
            }
            // El código que hay aquí se ejecutará si y solo si,
            // la excepción no ha saltado

            /*
             * Coger Excepciones Específicas
             */
            try
            {
            }
            catch (System.FormatException)
            {
                // Cogemos y tratamos las excepciones de tipo 'FormatException'
            }
            catch (System.Exception)
            {
                // Cogemos y tratamos las excepciones de tipo 'Exception'
            }

            Console.WriteLine("Final Lesson 17");
            Console.Read();

        }
    }
}
