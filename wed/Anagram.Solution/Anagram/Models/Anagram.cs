using System.Collections.Generic;

namespace Anagram.Models
{
    public class Anagram
    {
        private string _mainWord;
        private string _secondWord;
        private string _thirdWord;
        public Anagram (string mainWord, string secondWord, string thirdWord)
        {
            _mainWord = mainWord;
            _secondWord = secondWord;
            _thirdWord = thirdWord;       
        }

    }
}