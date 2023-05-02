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

      Console.WriteLine($"The following words are anagrams of {mainWord}: ");
      foreach (string word in anagrams)
      {
        Console.WriteLine(word);
      }
    }
  }
}