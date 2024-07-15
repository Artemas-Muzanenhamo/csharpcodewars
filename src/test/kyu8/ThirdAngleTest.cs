namespace csharpcodewars.src.test.kyu8
{
    using csharpcodewars.src.main.kyu8;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ThirdAngleTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.Multiple(() =>
            {
                Assert.That(ThirdAngle.OtherAngle(30, 60), Is.EqualTo(90));
                Assert.That(ThirdAngle.OtherAngle(60, 60), Is.EqualTo(60));
                Assert.That(ThirdAngle.OtherAngle(43, 78), Is.EqualTo(59));
                Assert.That(ThirdAngle.OtherAngle(10, 20), Is.EqualTo(150));
            });

        }
    }
}