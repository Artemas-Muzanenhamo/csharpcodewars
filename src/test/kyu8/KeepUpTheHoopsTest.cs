using csharpcodewars.src.main.kyu8;
using NUnit.Framework;
using System;

namespace csharpcodewars.src.test.kyu8
{
  [TestFixture]
  public class KeepUpTheHoopsTest
  {
    [Test]
    public static void SadPath() => Assert.That(KeepUpTheHoops.HoopCount(6), Is.EqualTo("Keep at it until you get it"), "Should work for 6");

    [Test]
    public static void HappyPath() => Assert.That(KeepUpTheHoops.HoopCount(22), Is.EqualTo("Great, now move on to tricks"), "Should work for 22");
  }
}