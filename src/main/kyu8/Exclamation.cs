namespace csharpcodewars.src.main.kyu8
{
    using System;
    using System.Text.RegularExpressions;

    public static class Exclamation
    {
        public static string Replace(string s) => Regex.Replace(s, @"[aeiou]","!", RegexOptions.IgnoreCase);
    }
}