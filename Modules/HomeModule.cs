using Nancy;
using System;
using System.Collections.Generic;
using AnagramChecker;

namespace AnagramChecker
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/results"] = _ => {
        Anagram newAnagram = new Anagram();
        string word1 = Request.Form["anagram-word"];
        string word2 = Request.Form["anagram-list"];
        List<string> anagramList = newAnagram.IsAnagram(word1, word2);
        Console.WriteLine(word2);
        foreach (string i in anagramList)
        {
          Console.WriteLine(i);
        }

        return View["results.cshtml", anagramList];
      };
    }
  }
}
