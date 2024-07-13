using System;
using System.Numerics;

namespace csharpcodewars.src.main.kyu8
{
    public class SuperDuperEasy
    {
        public static string Problem(string a)
        {
            //magic code 
            return double.TryParse(a, out _) ? (double.Parse(a) * 50 + 6).ToString() : "Error";
        }
    }
}