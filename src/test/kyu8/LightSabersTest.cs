namespace csharpcodewars.src.test.kyu8
{
    using System;
    using csharpcodewars.src.main.kyu8;
    using NUnit.Framework;

    [TestFixture]
    public class LightSabersTest
    {
        [Test]
        public static void Adam() => Assert.That(LightSabers.HowManyLightsabersDoYouOwn("Adam"), Is.EqualTo(0));

        [Test]
        public static void Zach() => Assert.That(LightSabers.HowManyLightsabersDoYouOwn("Zach"), Is.EqualTo(18));

        // [Test]
        // public static void NullName() => Assert.That(LightSabers.HowManyLightsabersDoYouOwn(null), Is.EqualTo(0));
    }
}