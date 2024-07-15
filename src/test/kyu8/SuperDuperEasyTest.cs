namespace csharpcodewars.src.test.kyu8
{
    using System;
    using csharpcodewars.src.main.kyu8;
    using NUnit.Framework;

    [TestFixture]
    public class SuperDuperEasyTest
    {

        [Test]
        public void Test1()
        {
            Assert.Multiple(() =>
            {
                Assert.That(SuperDuperEasy.Problem("hello"), Is.EqualTo("Error"));
                Assert.That(SuperDuperEasy.Problem("1"), Is.EqualTo("56"));
                Assert.That(SuperDuperEasy.Problem("5"), Is.EqualTo("256"));
                Assert.That(SuperDuperEasy.Problem("0"), Is.EqualTo("6"));
                Assert.That(SuperDuperEasy.Problem("1.2"), Is.EqualTo("66"));
            });

        }
    }
}