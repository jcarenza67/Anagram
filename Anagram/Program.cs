using System;
using System.Collections;
using System.Collections.Generic;
using Anagram.Models;

namespace Anagram
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to the Anagram/Palindrome Checker console App!");
      Console.WriteLine("Enter a word:");
      string mainWord = Console.ReadLine(); //ex: "least"
      AnagramClass checker = new AnagramClass();
      
      if (checker.CheckPalindrome(mainWord))
      {
        Console.WriteLine($"{mainWord} is a palindrome!");
      }
      else
      {
        Console.WriteLine($"{mainWord} is not a palindrome.");
      }
      
      Console.WriteLine("Enter a list of words to check if any are anagrams of the first word you entered. (separate words with a single space)");
      string wordsInput = Console.ReadLine(); //ex "stale tesla slate stale steal tales teals"

      string[] words = wordsInput.Split(" ");

      List<string> anagrams = checker.FindAnagram(mainWord, words);
      // Console.WriteLine(anagrams);
      Console.WriteLine($"The following words are anagrams of {mainWord}: ");
      foreach (string word in anagrams)
      {
        Console.WriteLine(word);
      }
    }
  }
}


//prompt the user to enter a word
//prompt the user to enter a list of words seperated by commas
//split the list of words into an array
//find the anagrams of the main word
//return the anagrams

// public class Demo {
//    public static void Main () {
//       string str1 = "heater";
//       string str2 = "reheat";
//       char[] ch1 = str1.ToLower().ToCharArray();
//       char[] ch2 = str2.ToLower().ToCharArray();
//       Array.Sort(ch1);
//       Array.Sort(ch2);
//       string val1 = new string(ch1);
//       string val2 = new string(ch2);

//       if (val1 == val2) {
//          Console.WriteLine("Both the strings are Anagrams");
//       } else {
//          Console.WriteLine("Both the strings are not Anagrams");
//       }
//    }
// }