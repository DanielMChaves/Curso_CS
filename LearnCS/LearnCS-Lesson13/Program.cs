/*
 * Alcance y Modificadores de Accesibilidad
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    class Program
    {
        /*
        * Ejercicio: 
        *   Crear un curso y listar a todos los alumnos de dicho curso
        *   por el RosterName
        */
        static void Ejercicio()
        {

        }

        /*
        * Alcance de los Métodos
        */
        public static void DoesCompile()
        {
            int width = 10;
            int length = 4;
            int area = width * length;
            Console.WriteLine($"{nameof(area)}:{area}");
        }

        /*
        public static void DoesNotCompile()
        {
            // width y length no existen todavia
            int area = width * length;
            int width = 10;
            int length = 4;
            Console.WriteLine($"{nameof(area)}:{area}");
        }
        public static void AlsoDoesNotCompile()
        {
            // width y length no están definidos para este método
            int area = width * length;
            Console.WriteLine($"{nameof(area)}:{area}");
        }
        */

        /*
        * Alcance de las Clases
        */
        public class Circle
        {
            public Circle(decimal radius)
            {
                // Usamos 'Radius' antes de que este declarada
                Radius = radius;
            }

            public decimal Radius { get; private set; }

            public decimal Perimeter()
            {
                // Usamos '_pi' antes de que este declarada
                return 2 * _pi * this.Radius;
            }

            private const decimal _pi = 3.14159m;
        }

        /*
         * Modificadores de Acceso
         */

        /*
         * public: El código puede ser usado por cualquier usuario
         * private: El código solo puede ser usado por otro código de la misma clase
         * protected: Solo una clase hija y la misma clase puede usarlo
         */
        public class Person
        {
            public Person(string firstName, string lastName, DateTime dateOfBirth)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.DateOfBirth = dateOfBirth;
            }

            protected string FirstName { get; private set; }
            protected string LastName { get; private set; }
            public DateTime DateOfBirth { get; private set; }

            public string FullName { get { return $"{this.FirstName} {this.LastName}"; } }

            public bool IsAnAdult()
            {
                var eighteenYearsAgo = DateTime.Today.AddYears(-18);
                return this.DateOfBirth < eighteenYearsAgo;
            }
        }

        public class Student : Person
        {
            public Student(string firstName, string lastName, DateTime dateOfBirth)
                : base(firstName, lastName, dateOfBirth)
            { }
            public string SchoolName { get; set; }

            public string RosterName { get { return $"{this.LastName}, {this.FirstName}"; } }
        }

        public class Course
        {
            public Course() { }

            public string course { get; set; }

            public List<Student> students { get; set; }

            public void getRosterName()
            {
                Console.WriteLine($"Curso: {this.course}");
                Console.WriteLine();

                foreach (Student student in this.students)
                {
                    Console.WriteLine(student.RosterName);
                }    
                
            }


        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Lesson 13");

            /*
             * Alcance de las Variables
             */

            // Bloqueo del Alcance
            // Las variables i son 'locales' al bucle que las declara
            for (int i = 0; i < 10; i++)
            {
                string message = $"Iteración número {i} del bucle.";
                Console.WriteLine(message);
            }
            for (int i = 0; i < 10; i++)
            {
                string message = $"Iteración número {i} del bucle.";
                Console.WriteLine(message);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            // La siguiente linea no compila porque la variable i
            // solo existe dentro del bucle for
            //Console.WriteLine(i);

            // Ejercicio

            Student irene = new Student("Irene", "Del Rincón Bello", new DateTime(1995, 3, 7));
            Student daniel = new Student("Daniel","Melero Chaves", new DateTime(1995,1,7));

            List<Student> students = new List<Student>() { daniel, irene };

            Course course = new Course();
            course.course = "Procesadores de Lenguajes";
            course.students = students;
            course.getRosterName();

            Console.WriteLine();
            Ejercicio();

            Console.WriteLine("Final Lesson 13");
            Console.Read();

        }
    }
}
