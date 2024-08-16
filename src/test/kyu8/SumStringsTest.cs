namespace csharpcodewars.src.test.kyu8 {
    using csharpcodewars.src.main.kyu8;
    using NUnit.Framework;
  using System;

  [TestFixture]
  public class SumStringsTest
  {
    [Test(Description = "Tests")]
    public void Tests()
    {
      Assert.That(SumStrings.StringsSum("4","5"), Is.EqualTo("9"));
      Assert.That(SumStrings.StringsSum("34","5"), Is.EqualTo("39"));
      Assert.That(SumStrings.StringsSum("","9"), Is.EqualTo("9"));
      Assert.That(SumStrings.StringsSum("9",""), Is.EqualTo("9"));
      Assert.That(SumStrings.StringsSum("",""), Is.EqualTo("0"));
    }
  }
}