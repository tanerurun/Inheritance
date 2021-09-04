using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[3]
            {
                new Customer{name="Taner" },
                new Student{name="Poyraz"},
                new Person{name="Haşim"}
            };
            foreach(var item in person)
            {
                Console.WriteLine(item.name);
            }
            Console.ReadLine();
        }
    }
    class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }

    }
    class Customer:Person
    {
        public string city { get; set; }
    }
    class Student:Person
    {
        public string department { get; set; }
    }
}
