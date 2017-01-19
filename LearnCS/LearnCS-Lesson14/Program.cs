/*
 * Encapsulación y Diseño Orientado a Objetos
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    class Program
    {
        /*
         * Ejercicio:
         */
        static void Ejercicio()
        {

        }

        public class Customer
        {
            public string Name { get; set; }
            public List<Order> Orders { get; set; } = new List<Order>();
        }

        public class Order
        {
            public Order(string orderNumber)
            {
                OrderNumber = orderNumber;
            }
            public string OrderNumber { get; set; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 14");

            var customer1 = new Customer() { Name = "Steve" };
            customer1.Orders.Add(new Order("123"));
            customer1.Orders.Add(new Order("234"));
            customer1.Orders.Add(new Order("345"));

            var customer2 = new Customer() { Name = "Eric" };
            customer2.Orders.Add(new Order("100"));
            customer2.Orders.Add(new Order("200"));
            customer2.Orders.Add(new Order("300"));

            var customers = new List<Customer>() { customer1, customer2 };

            // Imprimimos los clientes
            var orders = new List<Order>();
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
                Console.WriteLine("Cliente:");
                orders = customer.Orders;
                while (orders.Count > 0)
                {
                    Console.WriteLine(orders[0].OrderNumber);
                    orders.RemoveAt(0); // No escribir código así
                }
            }
            Console.WriteLine($"{customer1.Name}, Número de Ordenes: {customer1.Orders.Count}");
            Console.WriteLine($"{customer2.Name}, Número de Ordenes: {customer2.Orders.Count}");
        
            // Ejercicio
            Ejercicio();

            Console.WriteLine("Final Lesson 14");
            Console.Read();

        }
    }
}
