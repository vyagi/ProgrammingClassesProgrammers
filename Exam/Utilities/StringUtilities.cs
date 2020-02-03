using System;
using System.Linq;
namespace Utilities
{
    public static class StringUtilities
    {
        public static int ToWords(this string input) =>
            input.Split(' ').Length;

        public static string ToSentence(this string input) 
        {
            input = input.ToLower();
            return input[0].ToString().ToUpper() + input.Substring(1);
        }
        public static string ToCamelCase(this string input)
        {
            var split = input.Split(' ');
            for (int i = 0; i < split.Length; i++)
            {
                split[i] = split[i][0].ToString().ToUpper() + split[i].Substring(1).ToLower();
            }
            var combine = string.Join("", split);
            return combine[0].ToString().ToLower() + combine.Substring(1);
        }
    }
}
