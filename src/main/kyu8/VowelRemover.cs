using System;
using System.Text.RegularExpressions;

namespace csharpcodewars.src.main.kyu8
{
    public class VowelRemover
    {
        public static string Shortcut(string input)
        {
            // return input
            // .Replace("a", "")
            // .Replace("e", "")
            // .Replace("i", "")
            // .Replace("o", "")
            // .Replace("u", "");
            return Regex.Replace(input, "[aeiou]", "");
        }
    }
}