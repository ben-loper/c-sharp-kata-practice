using System;
using System.Collections.Generic;
using System.Text;

namespace Masking
{
    public class CreditCardMasking
    {
        public static string Maskify(string cc)
        {
            string result = "";

            if(cc.Length < 4)
            {
                result = cc;
            }

            return result;
        }
    }
}
