using System.Collections.Generic;

namespace WordCounter.Models
{
    public class WordBundle
    {
        private string _wordInput;
        private string _sentenceInput;

        public WordBundle (string wordInput, string sentenceInput)
        {
            _wordInput = wordInput;
            _sentenceInput = sentenceInput;
        }

    }
}