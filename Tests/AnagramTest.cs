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
      List<string> testList= testWord.IsAnagram("a", "a");
      Assert.Equal(testList, testWord.IsAnagram("a", "a"));
    }
    [Fact]
    public void IsAnagram_ForTwoLetters_true()
    {
      Anagram testWord = new Anagram();
      List<string> testList= testWord.IsAnagram("ab", "ba");
      Assert.Equal(testList, testWord.IsAnagram("ab", "ba"));
    }
    [Fact]
    public void IsAnagram_ForBigWord_true()
    {
      Anagram testWord = new Anagram();
      List<string> testList= testWord.IsAnagram("beard", "bread, beard, egg, butter");
      Assert.Equal(testList, testWord.IsAnagram("beard", "bread, beard, egg, butter"));
    }
    // public void Dispose()
    // {
    //   Anagram.DeleteAll();
    // }
  }
}
