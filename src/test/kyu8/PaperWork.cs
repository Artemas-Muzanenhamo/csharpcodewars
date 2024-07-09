using csharpcodewars.src.main.kyu8;
using NUnit.Framework;
using System;

namespace csharpcodewars.src.test.kyu8
{
    [TestFixture]
    public class PaperWork
    {
        [Test]
        public void Test()
        {
            Assert.That(Paper.Paperwork(5, 5), Is.EqualTo(25));
            Assert.That(Paper.Paperwork(5, -5), Is.EqualTo(0));
            Assert.That(Paper.Paperwork(-5, -5), Is.EqualTo(0));
            Assert.That(Paper.Paperwork(-5, 5), Is.EqualTo(0));
            Assert.That(Paper.Paperwork(5, 0), Is.EqualTo(0));
        }
    }
}