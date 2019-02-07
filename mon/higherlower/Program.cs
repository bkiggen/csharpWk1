using System;

namespace HigherLower {

    public class Program
    {
        public static void CheckNumber(double highNum, double lowNum, double guessNum)
        {
            Console.WriteLine("OK. So is your number higher or lower than" + guessNum + " ? higher/lower/correct");
            string numAnswer = Console.ReadLine();
            
            if (numAnswer == "higher")
            {
                lowNum = guessNum;
                guessNum = Math.Round((guessNum + highNum) / 2);
                CheckNumber(highNum, lowNum, guessNum);
            }
            else if (numAnswer == "lower")
            {
                highNum = guessNum;
                guessNum = Math.Round((guessNum + lowNum) / 2);
                CheckNumber(highNum, lowNum, guessNum);
            }
            else if (numAnswer == "correct")
            {
                Console.WriteLine("I got it! You're so stupid!");
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