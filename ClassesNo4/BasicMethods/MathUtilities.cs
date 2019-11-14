using System;
using System.Collections.Generic;
using System.Text;

namespace Maths
{
    public static class MathUtilities
    {
        public static bool IsPrime(int number)
        {
            if (number < 2)
                return false;
            
            for (int i = 2; i < number; i++)
                if (number % i == 0)
                    return false;

            return true;
        }

        public static int Gcd(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }
        public static bool AreCoprime(int a, int b)
        {
            return Gcd(a, b) == 1;
        }

        public static double[] SolveQuadratic(int a, int b, int c)
        {
            if (a == 0)
                throw new ArgumentException("a cannot be zero");

            int delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                //double[] result = new double[2];
                //result[0] = x1;
                //result[1] = x2;
                //return result;
                return new[] { x1, x2 };
            }
            if (delta == 0)
            {
                double x1 = -b / (2 * a);
                return new[] { x1 };
            }
            return new double[0];
        }
    }
}
