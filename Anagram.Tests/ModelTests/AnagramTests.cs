using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System.Collections.Generic;
using System;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramTests
  {
    AnagramClass newAnagram = new AnagramClass();

    [TestMethod]
    public void AnagramConstructor_CreatesInstanceOfAnagram_Anagram()
    {
      Assert.AreEqual(typeof(AnagramClass), newAnagram.GetType());
    }

    [TestMethod]
    public void CheckAnagram_ReturnsTrueIfWordsAreAnagrams_True()
    {
      Assert.AreEqual(true, newAnagram.CheckAnagram("heater", "reheat"));
    }

    [TestMethod]
    public void CheckAnagram_ReturnsFalseIfWordsAreNotAnagrams_False()
    {
      Assert.AreEqual(false, newAnagram.CheckAnagram("heater", "cooler"));
    }

    [TestMethod]
//aether
    public void FindAnagram_ReturnsListOfAnagrams_List()
    {
      // Arrange
      string mainWord = "heater";
      string[] wordList = new string[] {"reheat", "aether", "spaghetti"};

      // Act
      List<string> result = newAnagram.FindAnagram(mainWord, wordList);

      // Assert
      CollectionAssert.AreEqual(new List<string> {"reheat", "aether"} , result);
    }
  }
}