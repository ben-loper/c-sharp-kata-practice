using System;
using System.Collections.Generic;

namespace SplitStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] results = Solution("Test");

            foreach(string pair in results)
            {
                Console.WriteLine(pair);
            }

            Console.ReadKey();
        }

        static string[] Solution(string str)
        {
            List<string> results = new List<string>();

            string pair = "";
            int count = 0;

            for(int i = 0; i < str.Length; i++)
            {
                pair += str[i];
                count++;

                if(count == 1 && i + 1 == str.Length)
                {
                    pair += "_";
                    results.Add(pair);
                }
                else if (count == 2)
                {
                    results.Add(pair);
                    pair = "";
                    count = 0;
                }

            }



            return results.ToArray();
        }
    }
}
