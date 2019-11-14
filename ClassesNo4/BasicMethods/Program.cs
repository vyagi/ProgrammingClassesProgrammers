using System;
using Maths;
namespace BasicMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(MathUtilities.AreCoprime(8,9));
            //Console.WriteLine(MathUtilities.AreCoprime(8,10));

            var solutions = MathUtilities.SolveQuadratic(1, 0, 1);
            foreach (var solution in solutions)
            {
                Console.WriteLine(solution);
            }

        }
    }
}
