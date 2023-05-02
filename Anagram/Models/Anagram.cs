using System;
using System.Collections;
using System.Collections.Generic;

namespace Anagram.Models
{
  public class AnagramClass
  {
    
    public bool CheckAnagram(string word1, string word2)
    {
      string str1 = word1;
      string str2 = word2;
      char[] ch1 = str1.ToLower().ToCharArray();  //create arrays with the letters separated into their own elements
      char[] ch2 = str2.ToLower().ToCharArray();
      Array.Sort(ch1);  //sort the char arrays into alphabetical order
      Array.Sort(ch2);
      return new string(ch1) == new string(ch2);  //will return true if they are anagrams
      
    }
    public List<string> FindAnagram(string mainWord, string[] wordList)
    {
      List<string> anagramList = new List<string>(); // creating a new list to store anagrams
      foreach (string word in wordList)
      {
        if (CheckAnagram(mainWord, word))
        {
          anagramList.Add(word);
        }
      }
      return anagramList;
    }

    public bool CheckPalindrome(string word)
    {
      string wordString = word;
      char[] charArray1 = wordString.ToLower().ToCharArray();
      char[] charArray2 = charArray1;
      Array.Reverse(charArray1);
      return (charArray1 == charArray2);
    }
  }
}

// string orderedStr1 = new string(ch1);  //create new string with the alphabetical order of chars
      // string orderedStr2 = new string(ch2);

      // if (orderedStr1 == orderedStr2)
      // {
      //   return true; //they are anagrams
      // }
      // else
      // {
      //   return false; //not anagrams
      // }