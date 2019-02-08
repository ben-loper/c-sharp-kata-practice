using System;
using System.Collections.Generic;
using System.Text;

namespace Mumbling
{
    public class Mumbler
    {

        public static string GetMumbles(string phrase)
        {
            string result = "";

            char[] buildingBlocks = phrase.ToCharArray();

            for(int i = 0; i < buildingBlocks.Length; i++)
            {
                if (i != buildingBlocks.Length - 1)
                {
                    result += buildingBlocks[i].ToString().ToUpper();

                    for (int j = 1; j < i + 1; j++)
                    {
                        result += buildingBlocks[i].ToString().ToLower();
                    }

                    result += "-";
                }
                else
                {
                    result += buildingBlocks[i].ToString().ToUpper();

                    for(int j = 1; j < i + 1; j++)
                    {
                        result += buildingBlocks[i].ToString().ToLower();
                    }
                }
            }

            return result;
        }

        
    }
}
