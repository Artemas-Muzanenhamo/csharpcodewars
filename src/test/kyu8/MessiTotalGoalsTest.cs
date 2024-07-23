namespace csharpcodewars.src.test.kyu8
{
    using System;
    using csharpcodewars.src.main.kyu8;
    using NUnit.Framework;

    [TestFixture]
    public static class MessiTotalGoalsTest
    {

        [Test]
        public static void Tests()
        {
            Assert.That(MessiTotalGoals.total_goals, Is.EqualTo(58));
        }
    }
}