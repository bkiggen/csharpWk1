using System;
using Scrabble.Models;


namespace WordCounter
{
    public class WordBundle
    {
        public static void Main()
        {
            Console.WriteLine("We're going to play a game. You give me a word and a sentence, and I'll tell you how many times the word appears in your sentence. Ready? Here we go:");
            Console.WriteLine("Go on, type a word.");
            string wordInput = Console.ReadLine();
            Console.WriteLine("Now type a sentence.")
            string sentenceInput = Console.ReadLine();
            // Word newWord = new Word(wordInput);
            // string result = newWord.WordScorer();
            // Console.WriteLine(result);
            Console.WriteLine("This is where the result will go.");

            Console.WriteLine("Would you like to play again? (yes/no)");
            string quitOrNot = Console.ReadLine();
            if (quitOrNot.Equals("yes"))
            {
                Main();
            }
        }
    }
}
