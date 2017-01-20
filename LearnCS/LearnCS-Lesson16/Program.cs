/*
 * LINQ: Language-Integrated Query
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Occupation { get; set; }
        public int Age { get; set; }
    }
    public class FullName
    {
        public string First { get; set; }
        public string Last { get; set; }
    }

    class Program
    {
        /*
         * Ejercicio:
         *  Crear un programa que filtre la lista de usuarios por edad
         *  leyendo la edad por consola
         */
        static void Ejercicio()
        {
            var peoples = GenerarListaDePersonas();
            Console.WriteLine("Introducir edad por la que filtrar: ");
            int age = Int32.Parse(Console.ReadLine());

            List<Person> peoplesFilter = peoples.Where(x => x.Age > age).ToList();

            Console.WriteLine();
            Console.WriteLine($"Todas las personas mayores de {age} :");
            foreach (Person people in peoplesFilter)
            {
                Console.WriteLine($"    {people.FirstName} {people.LastName} {people.Occupation} {people.Age}");
            }
            Console.WriteLine();

        }

        public static List<Person> GenerarListaDePersonas()
        {
            var people = new List<Person>();

            people.Add(new Person { FirstName = "Eric", LastName = "Fleming", Occupation = "Dev", Age = 24 });
            people.Add(new Person { FirstName = "Steve", LastName = "Smith", Occupation = "Manager", Age = 40 });
            people.Add(new Person { FirstName = "Brendan", LastName = "Enrick", Occupation = "Dev", Age = 30 });
            people.Add(new Person { FirstName = "Jane", LastName = "Doe", Occupation = "Dev", Age = 35 });
            people.Add(new Person { FirstName = "Samantha", LastName = "Jones", Occupation = "Dev", Age = 24 });

            return people;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 16");
            Console.WriteLine();

            var peoples = GenerarListaDePersonas();

            Console.WriteLine("Todas las personas:");
            foreach (Person people in peoples)
            {
                Console.WriteLine($"    {people.FirstName} {people.LastName} {people.Occupation} {people.Age}");
            }
            Console.WriteLine();

            /*
             * Buscar Elementos en Colecciones
             */

            // Where
            // Hay 2 personas que cumplan esta condición: Steve y Jane
            var peopleOverTheAgeOf30 = peoples.Where(x => x.Age > 30);

            Console.WriteLine("Personas mayores de 30:");
            foreach (Person people in peopleOverTheAgeOf30)
            {
                Console.WriteLine($"    {people.FirstName} {people.LastName} {people.Occupation} {people.Age}");
            }
            Console.WriteLine();

            // Skip
            // Ignorar los X primeros elemetos, en este caso las dos primeras
            IEnumerable<Person> afterTwo = peoples.Skip(2);

            Console.WriteLine("Personas menos los 2 primeros:");
            foreach (Person people in afterTwo)
            {
                Console.WriteLine($"    {people.FirstName} {people.LastName} {people.Occupation} {people.Age}");
            }
            Console.WriteLine();

            // Take
            // Cogemos los X primeros elementos, en este caso las dos primeras
            IEnumerable<Person> takeTwo = peoples.Take(2);

            Console.WriteLine("Las 2 primeras personas:");
            foreach (Person people in takeTwo)
            {
                Console.WriteLine($"    {people.FirstName} {people.LastName} {people.Occupation} {people.Age}");
            }
            Console.WriteLine();

            /*
             * Cambiar Elementos en Colecciones
             */

            // Select
            // Obtener una lista de atributos de varios objetos
            IEnumerable<string> allFirstNames = peoples.Select(x => x.FirstName);

            Console.WriteLine("Nombres de todas las personas:");
            foreach (string name in allFirstNames)
            {
                Console.WriteLine($"    {name}");
            }
            Console.WriteLine();

            IEnumerable<FullName> allFullNames = peoples.Select(x => new FullName { First = x.FirstName, Last = x.LastName });

            Console.WriteLine("Nombres completos de todas las personas:");
            foreach (FullName fullName in allFullNames)
            {
                Console.WriteLine($"    {fullName.First} {fullName.Last}");
            }
            Console.WriteLine();

            /*
             * Obtener un Elemento de una Colección
             */

            // FirstOrDefault
            // Obtenemos el primer elemento o null, en este caso es Eric
            Person firstOrDefault = peoples.FirstOrDefault();
            Console.WriteLine("Primera persona:");
            Console.WriteLine($"    {firstOrDefault.FirstName}");
            Console.WriteLine();

            // Obtenemos el primer elemento que cumpla una condición, en este caso es Brendan
            Console.WriteLine("Primera persona con 30 años:");
            var firstThirtyYearOld1 = peoples.FirstOrDefault(x => x.Age == 30);
            var firstThirtyYearOld2 = peoples.Where(x => x.Age == 30).FirstOrDefault();
            Console.WriteLine($"    Con 'FirstOrDefault': {firstThirtyYearOld1.FirstName}");
            Console.WriteLine($"    Con 'Where' y 'FirstOrDefault': {firstThirtyYearOld1.FirstName}");
            Console.WriteLine();

            // Valor por omisión: null
            Console.WriteLine("Elementos 'null':");
            List<Person> emptyList = new List<Person>();
            // Colección vacia, primer elemento 'null'
            Person willBeNull = emptyList.FirstOrDefault();
            
            // No esta John en la lista, elemento 'null' 
            Person willAlsoBeNull = peoples.FirstOrDefault(x => x.FirstName == "John");

            Console.WriteLine($"    Lista vacia: {willBeNull == null}");
            Console.WriteLine($"    John?: {willAlsoBeNull == null}");
            Console.WriteLine();

            // LastOrDefault
            // Trabaja similar a 'FirstOrDefault'
            // Pero para la última posición de la colección
            Console.WriteLine("Últimos elemetos de la lista:");
            Person lastOrDefault = peoples.LastOrDefault();
            Console.WriteLine($"    Última persona: {lastOrDefault.FirstName}");
            Person lastThirtyYearOld = peoples.LastOrDefault(x => x.Age == 30);
            Console.WriteLine($"    Última persona con 30 años: {lastThirtyYearOld.FirstName}");
            Console.WriteLine();

            // SingleOrDefault
            // Obtenemos la primero ocurrencia del elemento pedido
            Console.WriteLine("Personas en concreto:");
            Person single = peoples.SingleOrDefault(x => x.FirstName == "Eric");
            Console.WriteLine($"    Buscando a Eric: {single.FirstName}");
            // La siguiente linea tira 'System.InvalidOperationException'
            // debido a que no hay una única persona con la ocupación 'Dev'
            // Person singleDev = peoples.SingleOrDefault(x => x.Occupation == "Dev");
            Console.WriteLine();

            /*
             * Busqueda de Datos en Colecciones
             */

            // Count
            // Obtenemos el tamaño de la colección
            Console.Write("Número de personas: ");
            int numberOfPeopleInList = peoples.Count();
            Console.WriteLine(numberOfPeopleInList);
            Console.WriteLine();

            Console.Write("Número de personas con más de 25 años: ");
            int peopleOverTwentyFive = peoples.Count(x => x.Age > 25);
            Console.WriteLine(peopleOverTwentyFive);
            Console.WriteLine();

            // Any
            // Obtenemos si la lista esta vacia o no
            Console.WriteLine("Lista vacia?: ");
            bool thereArePeople = peoples.Any();
            Console.WriteLine($"    Lista 'peoples': {thereArePeople}");
            bool thereAreNoPeople = emptyList.Any();
            Console.WriteLine($"    Lista 'emptyList': {thereAreNoPeople}");
            Console.WriteLine();

            // All
            // Obtenemos true o false si todos los elementos
            // cumplen la condición
            bool allDevs = peoples.All(x => x.Occupation == "Dev");
            Console.WriteLine($"Todas las personas son 'Dev': {allDevs}");
            bool everyoneAtLeastTwentyFour = peoples.All(x => x.Age >= 24);
            Console.WriteLine($"Todas las personas son mayores de 24 años: {everyoneAtLeastTwentyFour}");
            Console.WriteLine();

            /*
             * Convertir los Resultados a Collecciones
             */

            // ToList
            // Transforma los resultados a una lista
            List<Person> listOfDevs = peoples.Where(x => x.Occupation == "Dev").ToList();

            // ToArray
            // Transforma los resultados 
            Person[] arrayOfDevs = peoples.Where(x => x.Occupation == "Dev").ToArray();

            // Ejercicio
            Ejercicio();

            Console.WriteLine("Final Lesson 16");
            Console.Read();

        }
    }
}
