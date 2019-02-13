using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
    public class Word
    {
        private string _wordInput;
        public Word (string wordInput)
        {
            _wordInput = wordInput;
        }
        public string WordScorer()
        {
            int totalScore = 0;
            string lowerWord = _wordInput.ToLower();
            char[] letterArray = lowerWord.ToCharArray();
            foreach (char letter in letterArray)
            {
                if(letter.Equals('a') || letter.Equals('e') || letter.Equals('i') || 
                letter.Equals('o') || letter.Equals('u') || letter.Equals('l') || letter.Equals('n') || 
                letter.Equals('r') || letter.Equals('s') || letter.Equals('t'))
                {
                    totalScore += 1;
                }
                else if (letter.Equals('d') || letter.Equals('g'))
                {
                    totalScore += 2;
                }
                else if (letter.Equals('b') || letter.Equals('c') || letter.Equals('m') || letter.Equals('p'))
                {
                    totalScore += 3;
                }
                else if (letter.Equals('f') || letter.Equals('h') || letter.Equals('v') || letter.Equals('w') || letter.Equals('y'))
                {
                    totalScore += 4;
                }
                else if (letter.Equals('k'))
                {
                    totalScore += 5;
                }
                else if (letter.Equals('j') || letter.Equals('x'))
                {
                    totalScore += 8;
                }
                else if (letter.Equals('q') || letter.Equals('z'))
                {
                    totalScore += 10;
                }
            }
            string result = "Your word '" + _wordInput + "' is worth " + totalScore + " points!";
            return result;
        }
    }

}
