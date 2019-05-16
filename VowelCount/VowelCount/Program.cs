using System;
using System.Collections.Generic;

namespace VowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetVowelCount("test"));
            Console.ReadKey();
        }

        static int GetVowelCount(string str)
        {
            int count = 0;

            HashSet<char> vowels = new HashSet<char>
            {
                'a', 'e', 'i', 'o', 'u'
            };

            for(int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i]))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
