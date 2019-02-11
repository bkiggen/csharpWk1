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
           Ping newPing = new Ping(IntNum);
           newPing.TransformNums();

           foreach(string item in newPing.output)
           {
            Console.WriteLine(item);
           }
        }
    }
}