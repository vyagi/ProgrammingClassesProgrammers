using Geometry;
using System;
//using Jagiela;
using Vector3D;
namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point
            {
                X = 1,
                Y = 3
            };
            Reflect(p1);
            Console.WriteLine($"{p1.X} {p1.Y}");
            //LordOfTheRings lotr = new LordOfTheRings();
            //lotr.ShowYourself();
            Vector v1 = new Vector(1, 1, 0);
            Vector v2 = new Vector(-1, 1, 0);
            var angle = Vector.AngleBetween(v1, v2);

            Console.WriteLine(angle);
        }
        static void Reflect(Point p)
        {
            p.X = -p.X;
            p.Y = -p.Y;
        }
    }
}
