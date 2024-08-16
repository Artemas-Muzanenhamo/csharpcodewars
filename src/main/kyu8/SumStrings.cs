using System;
namespace csharpcodewars.src.main.kyu8
{
    public static class SumStrings
    {
        public static string StringsSum(string s1, string s2)
        {
            string firstStringValidated = ZeroIfEmpty(s1);
            string secondStringValidated = ZeroIfEmpty(s2);
            return (Convert.ToInt32(firstStringValidated) + Convert.ToInt32(secondStringValidated)).ToString();
            // return $"{(s1 == "" ? 0 : int.Parse(s1)) + (s2 == "" ? 0 : int.Parse(s2))}";
        }

        private static string ZeroIfEmpty(string value)
        {
            return (string.IsNullOrEmpty(value)) ? "0" : value;
        }
    }
}