using Xunit;
using System.Collections.Generic;
using System;
namespace AnagramChecker
{
  public class AnagramTest
  {
    [Fact]
    public void IsAnagram_ForSingleWord_true()
    {
      Anagram testWord = new Anagram();
      Assert.Equal(true,  testWord.IsAnagram("a", "a"));
    }
    // public void Dispose()
    // {
    //   Anagram.DeleteAll();
    // }
  }
}
