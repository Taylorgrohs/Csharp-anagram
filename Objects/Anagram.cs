using System;
using System.Collections.Generic;

namespace AnagramChecker
{
  public class Anagram
  {
    public bool IsAnagram(string word1, string word2)
    {
      if(word1 == word2)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }

}
