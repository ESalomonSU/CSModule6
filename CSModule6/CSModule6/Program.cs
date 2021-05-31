using System;
using System.Collections.Generic;

namespace Module6
{
    class Program 
    {
        static void Main(string[] args) 
        {
            int[] Array = new int[10]; 
            Array[0] = 1;
            Array[1] = 2;
            Array[2] = 3;
            Array[3] = 4;
            Array[4] = 5;
            Array[5] = 6;
            Array[6] = 7;
            Array[7] = 8;

            for (var i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }

            List<string> theList = new List<string>();
            theList.Add("1");
            theList.Add("2");
            theList.Add("3");
            theList.Add("4");
            theList.Add("5");
            theList.Add("6");
            theList.Add("7");
            theList.Add("8");
            theList.Add("9");
            theList.Add("10");

            foreach (var item in theList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
