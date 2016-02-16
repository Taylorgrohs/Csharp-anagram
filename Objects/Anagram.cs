using System;
using System.Collections.Generic;

namespace AnagramChecker
{
  public class Anagram
  {                                         //bread beard beard.split(" ")
    public List<string> IsAnagram(string word1, string word2)
    {
      char[] wordArray = word1.ToCharArray();
      Array.Sort(wordArray);
      string sortedWord1 = String.Join("", wordArray);
      //.Split returns char[]. Have to use following syntax to return string[]
      List<string> words = new List<string>(word2.Split(new string[] {" "}, StringSplitOptions.None));
      List<string> resultWords = new List<string> {};
      foreach(string word in words)
      {
        char[] wordArray2 = word.ToCharArray();
          Array.Sort(wordArray2);
        string sortedWord2 = String.Join("",wordArray2 );
        if(sortedWord1 == sortedWord2)
        {
          resultWords.Add(word);
        }

      }
      return resultWords;

    }
  }

}
