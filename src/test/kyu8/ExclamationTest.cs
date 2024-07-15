
namespace csharpcodewars.src.test.kyu8
{
    using System;
    using csharpcodewars.src.main.kyu8;
    using NUnit.Framework;

    [TestFixture]
    public class SolutionTest
    {
        [Test, Description("Basic Tests")]
        public void BasicTest()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Exclamation.Replace("Hi!"), Is.EqualTo("H!!"));
                Assert.That(Exclamation.Replace("!Hi! Hi!"), Is.EqualTo("!H!! H!!"));
                Assert.That(Exclamation.Replace("aeiou"), Is.EqualTo("!!!!!"));
                Assert.That(Exclamation.Replace("ABCDE"), Is.EqualTo("!BCD!"));
            });

        }
    }

}