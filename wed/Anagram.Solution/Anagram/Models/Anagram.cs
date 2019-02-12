using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram.Models
{
    public class Word
    {
        private string _mainWord;
        private string _secondWord;
        private string _thirdWord;
        private List<string> _wordList = new List<string>();
        private List<string> _sortedWordList = new List<string>();
        public Word (string mainWord, string secondWord, string thirdWord)
        {
            _mainWord = mainWord;
            _secondWord = secondWord;
            _thirdWord = thirdWord;
            _wordList.Insert(0, _mainWord);
            _wordList.Insert(1, _secondWord);
            _wordList.Insert(2, _thirdWord);

        }
        public List<string> GetWordList()
        {
            return _wordList;
        }
        public List<string> GetSortedWordList()
        {
            List<string> newList = new List<string>();
            foreach (string word in _wordList)
            {
                char[] newWordArray = word.ToCharArray();
                Array.Sort(newWordArray);
                string newWordString = string.Join("", newWordArray.ToArray());
                Console.WriteLine(newWordString);
                newList.Add(newWordString);
            }
            _sortedWordList = newList;
            return _sortedWordList;
        }

        public List<string> GetAnagrams()
        {
            List<string> newList = new List<string>();
            string targetWord = _sortedWordList[0];
            foreach (string word in _sortedWordList)
            {
                if(word == targetWord){
                    newList.Add(word);
                }
            }
            return newList;
        }

    }
}