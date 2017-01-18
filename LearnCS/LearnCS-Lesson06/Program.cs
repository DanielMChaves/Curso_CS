/*
 * Implementación de Expresiones Lógicas
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public class Program
    {

        /*
        * Ejercicio:
        *  Solo con sentencias IF y con DateTime
        *  Que el programa te diga que momento del día es
        */
        static void Exercise()
        {

            var time = DateTime.Now;
            Console.WriteLine(time.Hour);

            if (8 < time.Hour && time.Hour <= 12)
            {
                Console.WriteLine("Good Morning");
                return;
            }
            if (12 < time.Hour && time.Hour <= 16)
            {
                Console.WriteLine("Good Afternoon");
                return;
            }
            if (16 < time.Hour && time.Hour <= 22)
            {
                Console.WriteLine("Good Evening");
                return;
            }
            if (22 < time.Hour && time.Hour <= 8)
            {
                Console.WriteLine("Good Night");
                return;
            }


        }

        public static void Main()
        {
            Console.WriteLine("Lesson 6");

            /*
             * Operadores Lógicos
             */

            // Valores: true y false
            // variables de tipo 'bool'

            // Operadores de Comparación

            /*
                ==  // Igual
                !=  // Distinto
                >   // Mayor que
                <   // Menor que
                >=  // Mayor o igual que
                <=  // Menor o igual que
             */

            // Operadores de Condiciones Lógicas

            /*
                &&  // AND Lógico
                ||  // OR Lógico
                !   // NOT Lógico
                ^   // XOR Lógico
             */

            Console.WriteLine(true && true); // true
            Console.WriteLine(true && false); // false
            Console.WriteLine(false && false); // false

            Console.WriteLine(true || true); // true
            Console.WriteLine(true || false); // true
            Console.WriteLine(false || false); // false

            Console.WriteLine(!true); // false
            Console.WriteLine(!false); // true

            Console.WriteLine(true ^ true); // false
            Console.WriteLine(true ^ false); // true
            Console.WriteLine(false ^ false); // false

            // Ejercicio
            Exercise();

            Console.WriteLine("Final Lesson 6");
            Console.Read();
        }
    }
}
