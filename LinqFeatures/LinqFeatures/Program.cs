using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqFeatures
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Vector() { }
        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString() => $"[{X},{Y}]";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(3,4);
            Console.WriteLine(v1);
        }

        private static void ListOfStrings()
        {
            var names = new List<string>
                { "Tony", "Jon", "Ekateryna", "Natasza", "Wang", "Akzhol", "Eve",
                    "Marcin", "Alex" };


            var orderByAlphabetically = names.OrderBy(x => x);
            var fromTheLongest = names.OrderByDescending(x => x.Length);
            var funnySort = names.OrderBy(x => x.Last());

            var groupedWithLength = names
                .GroupBy(x => x.Length)
                .OrderByDescending(x => x.Key);

            foreach (var group in groupedWithLength)
            {
                Console.WriteLine(group.Key);
                Console.WriteLine("---------------");
                foreach (var name in group)
                {
                    Console.WriteLine(name);
                }
            }
        }

        private static void ArrayOfInts()
        {
            double[] grades = { 5, 3.5, 4.5, 4, 2, 4.5, 3.5, 3, 4, 2, 5 };
            var max = grades.Max();
            var min = grades.Min();
            var avg = grades.Average();
            var sum = grades.Sum();

            var positiveGrades = grades
                .Where(x => x > 2);

            var goodGradesSorted = grades
                .Where(x => x > 3.5)
                .OrderByDescending(x => x);

            var fakeEcts = grades
                .Where(x => x > 2)
                .Select(x => 3 * x + 10)
                .Sum();

            var myFirstGrade = grades.FirstOrDefault();
            var myLastGrade = grades.LastOrDefault();
            var countOf5 = grades.Count(x => x == 5);

            var anyNegativeGrades = grades.Any(x => x == 2);
            var allGradesAreWholeNumbers = grades.All(x => (int)x == x);

            var myFavouriteGrades = grades.Skip(3).Take(3);

            var leftSideHasGreaterAverage =
                grades.Take(grades.Length / 2).Average()
                    > grades.Skip(grades.Length / 2).Average();
        }
    }
}
