using System;
using System.Collections.Generic;
using System.Text;

namespace WhoLikeItKata
{
    public class WhoLikesIt
    {

        public static string Likes(string[] name)
        {
            string result = "No one likes this";

            if(name.Length > 3)
            {
                result = $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
            }
            else if(name.Length == 3)
            {
                result = $"{name[0]}, {name[1]} and {name[2]} like this";
            }
            else if(name.Length == 2)
            {
                result = $"{name[0]} and {name[1]} like this";
            }
            else if (name.Length == 1)
            {
                result = $"{name[0]} likes this";
            } 

            return result;
        }
    }
}
