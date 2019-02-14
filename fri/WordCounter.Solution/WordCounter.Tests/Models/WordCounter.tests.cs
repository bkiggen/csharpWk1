using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System;
using System.Collections.Generic;

namespace WordCounter.TestTools
{
    [TestClass]
    public class WordBundleTest
    {
        [TestMethod]
        public void WordBundleConstructor_CreatesInstanceOfWordBundle_WordBundle()
        {
            WordBundle newWordBundle = new WordBundle("cat", "Who let the cat out of the cathedral?");
            Assert.AreEqual(typeof(WordBundle), newWordBundle.GetType());
        }
        
    }
}