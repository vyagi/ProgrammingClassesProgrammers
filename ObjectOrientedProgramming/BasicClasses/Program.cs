using System;

namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Janusz", "Wolny", 40);
            Person p2 = new Person("Ann", "Shirley", 20);
            p2.LastName = "Grape";
            
            Console.WriteLine($"{p1.FirstName} {p1.LastName} is {p1.Age}");
            Console.WriteLine($"{p2.FirstName} {p2.LastName} is {p2.Age}");
        }
    }
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Name cannot be null");
                lastName = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
        }
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
    }
}
