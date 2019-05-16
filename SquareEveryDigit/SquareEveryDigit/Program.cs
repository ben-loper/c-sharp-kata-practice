using System;
using System.Collections.Generic;

namespace SquareEveryDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SquareDigits(1234);

            Console.ReadKey();
        }


        static int SquareDigits(int n)
        {
            string strResult = "";

            string numString = n.ToString();

            for(int i = 0; i < numString.Length; i++)
            { 

                // Convert number to integer
                int num = int.Parse(numString[i].ToString());

                // Square the number
                int squaredNum = num * num;

                // Convert back to string
                string sqrdString = squaredNum.ToString();

                // Add the result to the string results
                strResult += sqrdString;

            }

            return int.Parse(strResult);
        }
    }
}
