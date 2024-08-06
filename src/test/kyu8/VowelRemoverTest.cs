using System;
using csharpcodewars.src.main.kyu8;
using NUnit.Framework;

namespace csharpcodewars.src.test.kyu8
{
    [TestFixture]
    public class VowerRemoverTest
    {
        [Test]
        public void Test1()
        {
            Assert("hello", "hll");
            Assert("how are you today?", "hw r y tdy?");
            Assert("complain", "cmpln");
            Assert("never", "nvr");
        }

        private static void Assert(string input, string expected)
        {
            var result = VowelRemover.Shortcut(input);
            NUnit.Framework.Assert.That(result, Is.EqualTo(expected), String.Format("Expected \"{0}\" but got \"{1}\"", expected, result));
        }
    }
}