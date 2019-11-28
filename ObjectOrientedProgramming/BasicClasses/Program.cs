using System;

namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.firstName = "Roman";
            p1.lastName = "Kowalski";
            p1.age = 20;

            Console.WriteLine($"{p1.firstName} {p1.lastName} is {p1.age}");
        }
    }
    class Person
    {
        public string firstName;
        public string lastName;
        public int age;
    }
}
