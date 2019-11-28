using System;

namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Janusz", "Wolny", -40);
            
            
            Console.WriteLine($"{p1.GetFirstName()} {p1.GetLastName()} is {p1.GetAge()}");
        }
    }
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        public Person(string firstName, string lastName, int age)
        {
            if (firstName == null || lastName == null)
                throw new ArgumentNullException("Names cannot be null");
            this.firstName = firstName;
            this.lastName = lastName;
            if (age <= 0)
                throw new ArgumentOutOfRangeException("Age must be postive");
            this.age = age;
        }
        public string GetFirstName()
        {
            return this.firstName;
        }
        public string GetLastName()
        {
            return this.lastName;
        }
        public int GetAge()
        {
            return this.age;
        }
    }
}
