using System;

namespace HigherLower {

    public class Program
    {
        public static void CheckNumber(double highNum, double lowNum, double guessNum)
        {
            Console.WriteLine("OK. So is your number higher or lower than" + highNum + " ? higher/lower/correct");
            string numAnswer = Console.ReadLine();
            if (numAnswer == "higher")
            {
                CheckNumber(Math.Round((guessNum + highNum) / 2));
            }
            else if (numAnswer == "lower")
            {
                CheckNumber(Math.Round((guessNum + lowNum) / 2));
            }
            else if (numAnswer == "correct")
            {
                Console.WriteLine("I got it! You're so bad at this game!");
            }
            else 
            {
                Console.WriteLine("error!");
            }
        }
        public static void Main()
        {
            Console.WriteLine("Would you like to play the higher/lower game? yes/no");
            string playAnswer = Console.ReadLine();
            if(playAnswer == "yes"){
                Console.WriteLine("Cool! Think of a number between 1 and 100");
                CheckNumber(100, 0, 50);
            }
            else {
                Console.WriteLine("Bummer.");
                System.Environment.Exit(1);
            }
        }
    }
}