using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System;
using System.Collections.Generic;

namespace Anagram.Tests
{
    [TestClass]
    public class WordTest
    {

        [TestMethod]
        public void WordConstructor_CreatesInstanceOfWord_Word()
        {
            Word newWord = new Word("dog", "goal", "god");
            Assert.AreEqual(typeof(Word), newWord.GetType());
        }

        [TestMethod]
        public void GetWordList_ReturnListOfWords_List()
        {
            Word newWord = new Word("dog", "hog", "god");
            List<string> testArray = new List<string> {"dog", "hog", "god"};
            List<string> result = newWord.GetWordList();
            CollectionAssert.AreEqual(testArray, result);
        }
        [TestMethod]
        public void GetSortedWordList_ReturnListOfWords_List()
        {
            Word newWord = new Word("dog", "hog", "god");
            List<string> testArray = new List<string> {"dgo", "gho", "dgo"};
            List<string> result = newWord.GetSortedWordList();
            CollectionAssert.AreEqual(testArray, result);
        }
        [TestMethod]
        public void GetAnagrams_ReturnAnagramList_List()
        {
            Word newWord = new Word("dog", "hog", "god");
            List<string> result = newWord.GetAnagrams();
            List<string> testArray = new List<string> { "dgo", "dgo" };
            CollectionAssert.AreEqual(testArray, result);
        }

    }
}