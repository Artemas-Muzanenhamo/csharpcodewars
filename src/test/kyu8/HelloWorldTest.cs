using System;
using csharpcodewars.src.main.kyu8;
using NUnit.Framework;

namespace csharpcodewars.src.test.kyu8
{
    [TestFixture]
    public class HelloWorldTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.Multiple(() =>
            {
                Assert.That(HelloWorld.Hello("jEFF"), Is.EqualTo("Hello, Jeff!"));
                Assert.That(HelloWorld.Hello("tonY"), Is.EqualTo("Hello, Tony!"));
                Assert.That(HelloWorld.Hello("Alicia"), Is.EqualTo("Hello, Alicia!"));
                Assert.That(HelloWorld.Hello("vasya"), Is.EqualTo("Hello, Vasya!"));
                Assert.That(HelloWorld.Hello("JOHN"), Is.EqualTo("Hello, John!"));
                Assert.That(HelloWorld.Hello(""), Is.EqualTo("Hello, World!"));
                Assert.That(HelloWorld.Hello(), Is.EqualTo("Hello, World!"));
            });

        }
    }
}