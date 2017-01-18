/*
 * Trabajando con Fechas y Tiempos
 */

using System;

namespace Lesson4
{
    public class Program
    {

        /*
         * Ejercicio:
         *  Obtener los días que quedan para tu cumpleaños
         */
        static void Exercise()
        {

            var birthday = new DateTime(DateTime.Today.Year + 1, 1, 7);
            TimeSpan duration = birthday - DateTime.Today;
            Console.WriteLine($"Quedan {duration.TotalDays} para mi cumpleaños");

        }

        public static void Main()
        {

            Console.WriteLine("Lesson 4");

            /*
             * Tipo DateTime
             */

            var currentTime = DateTime.Now; // Hora Actual
            var today = DateTime.Today; // Hora Actual - Tiempo medianoche
            var someDate = new DateTime(2016, 7, 1); // 1 July 2016, medianoche
            var someMoment = new DateTime(2016, 7, 1, 8, 0, 0); // 1 July 2016, 08:00.00
            var tomorrow = DateTime.Today.AddDays(1); // Mañana
            var yesterday = DateTime.Today.AddDays(-1); // Ayer
            var someDay = DateTime.Parse("7/1/2016");

            /*
             * Obtener partes de la fecha y tiempo
             */

            // Formato (Año, Mes, Día, Hora, Minutos, Segundos)
            var someTime = new DateTime(2016, 7, 1, 11, 10, 9); // 1 July 2016 11:10:09 AM
            int year = someTime.Year; // 2016
            int month = someTime.Month; // 7
            int day = someTime.Day; // 1
            int hour = someTime.Hour; // 11
            int minute = someTime.Minute; // 10
            int second = someTime.Second; // 9

            /*
             * Calcular duraciones entre tiempos
             */

            DateTime nextYear = new DateTime(DateTime.Today.Year + 1, 1, 1);
            TimeSpan duration = nextYear - DateTime.Today;
            Console.WriteLine($"Quedan {duration.TotalDays} para el final del año");

            // Ejercicio
            Exercise();

            Console.WriteLine("Final Lesson 4");
            Console.Read();
        }
    }
}
