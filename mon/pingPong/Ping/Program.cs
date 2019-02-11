using System;
using PingPong;

namespace PingPong
{

    public class Program
    {
        public static void Main()
        {
           Console.WriteLine("Enter a number: ");
           string InputNum = Console.ReadLine();
           int IntNum = int.Parse(InputNum);
           string[] ResultArray = Ping.TransformNums(IntNum);

           foreach(string item in ResultArray)
           {
            Console.WriteLine(item);
           }
        }
    }
}