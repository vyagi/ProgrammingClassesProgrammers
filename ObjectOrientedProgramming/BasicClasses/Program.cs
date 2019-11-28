using System;

namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Janusz", "Wolny", 40);
            Person p2 = new Person("Ann", "Shirley", 20);
            p2.SetLastName("Grape");
            
            Console.WriteLine($"{p1.GetFirstName()} {p1.GetLastName()} is {p1.GetAge()}");
            Console.WriteLine($"{p2.GetFirstName()} {p2.GetLastName()} is {p2.GetAge()}");
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
        public void SetLastName(string newLastName)
        {
            if(newLastName == null)
                throw new ArgumentNullException("Name cannot be null");
            this.lastName = newLastName;
        }
    }
}
