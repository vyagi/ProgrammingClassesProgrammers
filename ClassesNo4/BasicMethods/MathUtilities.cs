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
    }
}
