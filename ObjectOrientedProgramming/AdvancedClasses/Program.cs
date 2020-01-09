using System;

namespace AdvancedClasses
{

    class Program
    {
        static void Main(string[] args)
        {
            Shape[] ourShapes =
            {
                new Triangle(3,4,5),
                new Square(8),
                new Circle(10),
                new Circle(5),
            };
            foreach (var shape in ourShapes)
            {
                Console.WriteLine(shape.ToString());
            }
        }
    }
}
