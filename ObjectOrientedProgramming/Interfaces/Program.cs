using System;

namespace Interfaces
{
    public interface IDrawable
    {
        void Draw();
    }
    public class Vehicle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Imagine a picture of a vehicle");
        }
    }
    public class Square : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("_____");
            Console.WriteLine("_   _");
            Console.WriteLine("_   _");
            Console.WriteLine("_____");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IDrawable[] thingsToDraw =
            {
                new Square(),
                new Vehicle()
            };

            foreach (var item in thingsToDraw)
            {
                item.Draw();
            }
        }
    }
}
