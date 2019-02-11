using System;
using System.Collections.Generic;

namespace PingPong
{
    public class Ping
    {
        public string[] output;
        private int inputNum;
        public Ping(int inputNum)
        {
            this.inputNum = inputNum;
        }
        public void TransformNums()
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
            output = newArray;
        }
    }
}