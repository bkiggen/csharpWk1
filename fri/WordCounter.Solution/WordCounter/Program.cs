using System;
using WordCounter.Models;


namespace WordCounter
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("We're going to play a game. You give me a word and a sentence, and I'll tell you how many times the word appears in your sentence. Ready? Here we go:");
            Console.WriteLine("Go on, type a word.");
            string wordInput = Console.ReadLine();
            Console.WriteLine("Now type a sentence.");
            string sentenceInput = Console.ReadLine();
            WordBundle newWordBundle = new WordBundle(wordInput, sentenceInput);
            int count = newWordBundle.CountWordsInSentence();
            Console.WriteLine("Cool, so it looks like '" + wordInput + "' shows up in '" + sentenceInput + "' " + count + " times.");
            Console.WriteLine("Would you like to play again? (yes/no)");
            string quitOrNot = Console.ReadLine();
            if (quitOrNot.Equals("yes"))
            {
                Main();
            }
        }
    }
}
