using System;
using System.Collections.Generic;

namespace PingPong
{
    public static class Ping
    {
        public static string[] TransformNums(int inputNum)
        {
            string[] newArray = new string[inputNum];
            for(int i=0; i < inputNum; i++)
            {
                if(i%15 == 0 )
                {
                    newArray[i] = "PingPong!";
                }
                else if(i%3 == 0)
                {
                    newArray[i] = "Ping!";
                }
                else if (i%5 == 0)
                {
                    newArray[i] = "Pong!";
                }
                else
                {
                    newArray[i] = i.ToString();
                }
            }
            return newArray;
        }
    }
}