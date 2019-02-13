using System;
using Scrabble.Models;


namespace Scrabble
{
    public class Program
    {
    public static void Main()
        {
            Console.WriteLine("Enter a word to see its Scrabble value.");
            string wordInput = Console.ReadLine();
            Word newWord = new Word(wordInput);
            string result = newWord.WordScorer();
            Console.WriteLine(result);
        }
    }
}


