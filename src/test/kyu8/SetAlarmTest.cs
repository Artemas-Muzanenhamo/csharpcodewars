namespace csharpcodewars.src.test.kyu8
{
    using csharpcodewars.src.main.kyu8;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SetAlarmTest
    {
        [Test]
        public void Tests()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Clock.SetAlarm(true, true), Is.EqualTo(false));
                Assert.That(Clock.SetAlarm(false, true), Is.EqualTo(false));
                Assert.That(Clock.SetAlarm(true, false), Is.EqualTo(true));
                Assert.That(Clock.SetAlarm(false, false), Is.EqualTo(false));
            });

        }
    }
}