using System;

namespace ExtensionMethods
{
    public static class StringUtilities
    {
        public static bool IsLongerThan(this string input, int howLong) => 
            input.Length > howLong;
        public static bool IsFemaleName(this string input) =>
            input.ToLower().EndsWith("a") && input.ToLower() != "kuba";
    }
    public static class IntUtilities
    {
        public static bool IsEven(this int number) =>
            number % 2 == 0;
        public static bool IsOdd(this int number) =>
            !number.IsEven();
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Marcin";
            Console.WriteLine(name.IsLongerThan(5));
            Console.WriteLine(name.IsFemaleName());
            Console.WriteLine(2.IsEven());
        }
    }
}
