using System;
using System.Collections.Generic;
using System.Text;

namespace Math
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
    }
}
