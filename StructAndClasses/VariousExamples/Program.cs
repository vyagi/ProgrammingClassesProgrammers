using System;

namespace VariousExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //OutParameters();
            Console.WriteLine(Average());
        }
        private static double Average(params int[] array)
        {
            if (array.Length == 0) return 0;

            double sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            return sum / array.Length;
        }
        private static void OutParameters()
        {
            int a = 5;
            int b = 9;
            Swap(ref a, ref b);
            Console.WriteLine($"a is {a}");
            Console.WriteLine($"b is {b}");

            if (int.TryParse("dieci", out int c))
            {
                Console.WriteLine("The number is " + c);
            }
            else
            {
                Console.WriteLine("This is something I cannot parse");
            }
        }

        private static void MethodWithOut(out int a)
        {
            a = 10;
        }
        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
