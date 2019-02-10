using System;
using System.Collections.Generic;

namespace PingPong
{
    public class Ping
    {
        public List<int> TransformNums(int num)
        {
            List<int> newList = new List<int>();
            for(int i=0; i < num; i++)
            {
                if(i%15)
                {
                    newList.Add("PingPong!");
                }
                else if(i%3 == 0)
                {
                    newList.Add("Ping!");
                }
                else if (i%5 == 0)
                {
                    newList.Add("Pong!");
                }
                else
                {
                    newList.Add(i);
                }
            }
            Console.WriteLine(newList);
            return newList;
        }
    }
}