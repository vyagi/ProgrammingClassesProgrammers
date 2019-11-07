using System;
using Math;
namespace BasicMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"-10 {MathUtilities.IsPrime(-10)}");
            Console.WriteLine($"0 {MathUtilities.IsPrime(0)}");
            Console.WriteLine($"1 {MathUtilities.IsPrime(1)}");
            Console.WriteLine($"2 {MathUtilities.IsPrime(2)}");
            Console.WriteLine($"4 {MathUtilities.IsPrime(4)}");
            Console.WriteLine($"7 {MathUtilities.IsPrime(7)}");
            Console.WriteLine($"23 {MathUtilities.IsPrime(23)}");

        }
    }
}
