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

            Car c1 = new Car("Toyota", 70,5);
            c1.Tank(20);
            c1.Drive(300);
            Console.WriteLine($"{c1.CurrentFuelLevel} liters of fuel left. {c1.KilometerCounter} kilometers done.");
            c1.Drive(300);
            Console.WriteLine($"{c1.CurrentFuelLevel} liters of fuel left. {c1.KilometerCounter} kilometers done.");

        }
    }
}
