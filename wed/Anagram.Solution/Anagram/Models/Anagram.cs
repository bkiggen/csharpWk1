using System.Collections.Generic;

namespace Anagram.Models
{
    public class Word
    {
        private string _mainWord;
        private string _secondWord;
        private string _thirdWord;
        private List<string> _wordList = new List<string>();
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

    }
}