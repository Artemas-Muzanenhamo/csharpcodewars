using System;

namespace csharpcodewars.src.main.kyu8
{
    public static class HelloWorld
    {
        public static string Hello(string name = "World")
        {
            return string.IsNullOrEmpty(name) ? "Hello, World!" : $"Hello, {char.ToUpper(name[0]) + name[1..].ToLower()}!";
        }
    }
}