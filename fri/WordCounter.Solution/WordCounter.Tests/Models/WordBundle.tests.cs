using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System;
using System.Collections.Generic;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordBundleTest
    {
        [TestMethod]
        public void WordBundleConstructor_CreatesInstanceOfWordBundle_WordBundle()
        {
            string testWord = "cat";
            string testSentence = "Who let the cat out of the cathedral?";
            WordBundle newWordBundle = new WordBundle(testWord, testSentence);
            Assert.AreEqual(typeof(WordBundle), newWordBundle.GetType());
        }
        [TestMethod]
        public void CountWordsInSentence_ReturnsWordCount_Int()
        {
            string testWord = "cat";
            string testSentence = "Who let the cat out of the cathedral?";
            WordBundle newWordBundle = new WordBundle(testWord, testSentence);
            int result = newWordBundle.CountWordsInSentence();
            Assert.AreEqual(result, 1);
        }
        [TestMethod]
        public void GetSentence_ReturnSentence_String()
        {
            string testWord = "cat";
            string testSentence = "Who let the cat out of the cathedral?";
            WordBundle newWordBundle = new WordBundle(testWord, testSentence);
            string result = newWordBundle.GetSentence();
            Assert.AreEqual(result, "Who let the cat out of the cathedral?");
        }
        [TestMethod]
        public void GetWord_ReturnWord_String()
        {
            string testWord = "cat";
            string testSentence = "Who let the cat out of the cathedral?";
            WordBundle newWordBundle = new WordBundle(testWord, testSentence);
            string result = newWordBundle.GetWord();
            Assert.AreEqual(result, "cat");
        }
    }
}