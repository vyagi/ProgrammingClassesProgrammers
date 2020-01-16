using System;

namespace Generics
{
    public class Pair<T,S>
    {
        public T First { get; set; }
        public S Second { get; set; }
        public Pair(T first, S second)
        {
            First = first;
            Second = second;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var firstPair = new Pair<int, int>(1,8);
            var secondPair = new Pair<string, string>("Marcin", "Jagieła");
            var thirdPair = new Pair<int, DateTime>(1, DateTime.Now);
        }
    }
}
