using Xunit;
using System.Collections.Generic;
using System;
namespace AnagramChecker
{
  public class AnagramTest
  {
    [Fact]
    public void IsAnagram_ForSingleLetter_true()
    {
      Anagram testWord = new Anagram();
      Assert.Equal(true,  testWord.IsAnagram("a", "a"));
    }
    [Fact]
    public void IsAnagram_ForSingleLetter_false()
    {
      Anagram testWord = new Anagram();
      Assert.Equal(false, testWord.IsAnagram("a", "b"));
    }
    // public void Dispose()
    // {
    //   Anagram.DeleteAll();
    // }
  }
}
