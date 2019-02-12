using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System;
using System.Collections.Generic;

namespace Anagram.Tests
{
    [TestClass]
    public class AnagramTest : IDisposable
    {
        public void Dispose()
        {
            Anagram.ClearAll();
        }

        [TestMethod]
        public void AnagramConstructor_CreatesInstanceOfAnagram_Anagram()
        {
            Anagram newAnagram = new Anagram("dog", "goal", "god");
            Assert.AreEqual(typeof(Anagram), newAnagram.GetType());
        }
    }
}