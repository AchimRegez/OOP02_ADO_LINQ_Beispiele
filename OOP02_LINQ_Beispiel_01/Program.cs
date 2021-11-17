using System;
using System.Linq;

namespace OOP02_LINQ_Beispiel_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create array from persons
            Person[] persons =
            {
                new Person { Name = "Hans Nötig", Age = 32 },
                new Person { Name = "Sabrina Schmidt", Age = 25 },
                new Person { Name = "Harald Fischer", Age = 69 },
                new Person { Name = "Alina Meier", Age = 55 }
            };

            //Query syntax /// Abfragesyntax
            var query = from person in persons
                        where person.Age >= 50
                        select person;
            Console.WriteLine("Query Syntax:");
            Console.WriteLine("Personen mit Alter >= 50:");
            foreach(var item in query)
                Console.WriteLine($"Name: {item.Name, -8} Alter: {item.Age}");


            //Same example with the extension method /// Erweiterungsmethode
            var queryExtensionMethod = persons
                .Where(p => p.Age >= 50)
                .Select(p => p);
            Console.WriteLine();
            Console.WriteLine("Extension Method:");
            Console.WriteLine("Personen mit Alter >= 50:");
            foreach (var item in queryExtensionMethod)
                Console.WriteLine($"Name: {item.Name,-8} Alter: {item.Age}");

            Console.ReadLine();
        }
    }
}
