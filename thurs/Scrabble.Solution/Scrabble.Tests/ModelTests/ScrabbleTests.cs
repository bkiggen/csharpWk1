using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;
using System;
using System.Collections.Generic;

namespace Scrabble.Tests
{
    [TestClass]
    public class WordTest 
    {

        [TestMethod]
        public void WordConstructor_CreatesInstanceOfWord_Word()
        {
            Word newWord = new Word("Cooper");
            Assert.AreEqual(typeof(Word), newWord.GetType());
        }
        [TestMethod]
        public void WordScorer_ReturnsScore_Int()
        {
            Word newWord = new Word("Syzygy");
            int testInt = 5;
            string result = newWord.WordScorer();
            Assert.AreEqual(testInt.GetType(), result.GetType());
        }
        [TestMethod]
        public void WordScorer_ReturnsCorrectScore_Int()
        {
            Word newWord = new Word("Zookeeper");
            int testInt = 6;
            string result = newWord.WordScorer();
            Assert.AreEqual(testInt.GetType(), result.GetType());
        }


    }
}


