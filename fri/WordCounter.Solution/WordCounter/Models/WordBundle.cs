using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{
    public class WordBundle
    {
        private string _wordInput;
        private string _sentenceInput;

        public WordBundle(string wordInput, string sentenceInput)
        {
            _wordInput = wordInput.ToLower();
            _sentenceInput = sentenceInput.ToLower();
        }

        public int CountWordsInSentence()
        {
            int count = 0;
            string[] wordList = _sentenceInput.Split(' ');

            foreach (string word in wordList)
            {
                if(word == _wordInput){
                    count++;
                }
            }
            return count;
        }

        public string GetWord()
        {
            return _wordInput;
        }
        public string GetSentence()
        {
            return _sentenceInput;
        }

    }
}