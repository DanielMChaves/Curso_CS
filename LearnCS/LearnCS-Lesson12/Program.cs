/*
 * Clases y Objetos
 */

using System;
using System.Collections.Generic;

namespace Lesson12
{
    public class Program
    {
        int versionNumber = 123;

        /*
         * Ejercicio:
         */

        static void Ejercicio()
        {
            Address address = new Address();
            address.StreetAddress = "123 Main Street";
            address.City = "Sometown";
            address.State = "OH";
            address.PostalCode = "12345";
            address.Country = "United States";
            
            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Doe";
            john.ShippingAddress = address;
            
            Person jane = new Person();
            jane.FirstName = "Jane";
            jane.LastName = "Doe";
            jane.ShippingAddress = address;
            
            Company acme = new Company();
            acme.Name = "Acme, Inc.";
            acme.ShippingAddress = address;
            
            List<Person> persons = new List<Person>() { john, jane };
            List<Company> companies = new List<Company>() { acme };
           
            foreach (Person person in persons)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
                Console.WriteLine($"{person.ShippingAddress.StreetAddress}");
                Console.WriteLine($"{person.ShippingAddress.City}, {person.ShippingAddress.State}, {person.ShippingAddress.PostalCode}");
                Console.WriteLine($"{person.ShippingAddress.Country}");
                Console.WriteLine();
            }
            
            foreach (Company company in companies)
            {
                Console.WriteLine($"{company.Name}");
                Console.WriteLine($"{company.ShippingAddress.StreetAddress}");
                Console.WriteLine($"{company.ShippingAddress.City}, {company.ShippingAddress.State}, {company.ShippingAddress.PostalCode}");
                Console.WriteLine($"{company.ShippingAddress.Country}");
                Console.WriteLine();
            }

        }

        public class Speedometer
        {
            private int _currentSpeed;
            public int CurrentSpeed
            {
                get
                {
                    return _currentSpeed;
                }
                set
                {
                    if (value < 0) return;
                    if (value > 120) return;

                    // Value es una palabra reservada usada en los setters para representar
                    // el nuevo valor
                    _currentSpeed = value;
                }
            }

        }

        public class Address
        {
            public string StreetAddress { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string PostalCode { get; set; }
            public string Country { get; set; }
        }
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public Address ShippingAddress { get; set; }
        }
        public class Company
        {
            public string Name { get; set; }
            public Address ShippingAddress { get; set; }
        }

        /*
         * Herencia
         */

        public class Shape
        {
            public virtual int Perimeter()
            {
                return 0;
            }
        }
        public class Rectangle : Shape
        {
            public int Height { get; set; }
            public int Width { get; set; }

            public override int Perimeter()
            {
                return (Height + Width) * 2;
            }
        }
        public class Triangle : Shape
        {
            public int Side1 { get; set; }
            public int Side2 { get; set; }
            public int Side3 { get; set; }

            public override int Perimeter()
            {
                return Side1 + Side2 + Side3;
            }
        }

        public static void Main()
        {
            Console.WriteLine("Lesson 12");

            // La siguiente linea no compila, la comentamos
            // Console.WriteLine($"Current version: {versionNumber}");

            // instead, you must create an instance of Program
            var myProgram = new Program();
            Console.WriteLine($"Versión Actual: {myProgram.versionNumber}");

            var myProgram2 = new Program();
            Console.WriteLine(myProgram2.ToString());
            // or
            Console.WriteLine(myProgram2); // WriteLine will automatically call ToString for you internally

            // Ejercicio
            Console.WriteLine();
            Ejercicio();

            Console.WriteLine("Final Lesson 12");
            Console.Read();
        }
    }
}
