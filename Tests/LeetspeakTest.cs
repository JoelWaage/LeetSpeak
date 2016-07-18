using Xunit;
using System.Collections.Generic;

namespace LeetSpeakList.Objects
{
  public class LeetSpeakTest
  {
    [Fact]
    public void IsLeetSpeak_IsLetterE_3()
    {
      LeetSpeak LeetTest = new LeetSpeak("few");
      Assert.Equal("f3w", LeetTest.LeetSpeakGenerator());
    }
    [Fact]
    public void IsLeetSpeak_IsLetterO_0()
    {
      LeetSpeak LeetTest = new LeetSpeak("how");
      Assert.Equal("h0w", LeetTest.LeetSpeakGenerator());
    }
    [Fact]
    public void IsLeetSpeak_IsLetterI_1()
    {
      LeetSpeak LeetTest = new LeetSpeak("Ink");
      Assert.Equal("1nk", LeetTest.LeetSpeakGenerator());
    }
    [Fact]
    public void IsLeetSpeak_IsFirstLetterNotS_z()
    {
      LeetSpeak LeetTest = new LeetSpeak("pass");
      Assert.Equal("pazz", LeetTest.LeetSpeakGenerator());
    }
    [Fact]
    public void IsLeetSpeak_IsFirstLetterIsS_z()
    {
      LeetSpeak LeetTest = new LeetSpeak("Sears");
      Assert.Equal("s3arz", LeetTest.LeetSpeakGenerator());
    }
  }
}
