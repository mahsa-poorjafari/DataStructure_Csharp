using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure_Csharp
{
    class PlayWithChar
    {
        //This time no story, no theory. The examples below show you how to write function accum:
        //    Examples: accum("abcd") -> "A-Bb-Ccc-Dddd"
        public String Accum(string s)
        {
            s = s.ToLower();
            char[] charArray = s.ToCharArray();
            string finalString = "";
            string a;
            int len = charArray.Length;
            for (int i = 0; i < len; i++)
            {
                a = "";
                a = string.Concat(a, Char.ToUpper(charArray[i]).ToString());
                for (int j = 0; j < i; j++)
                {
                    a = string.Concat(a, charArray[i].ToString());
                }
                if (a.Length == len)
                {
                    finalString = string.Concat(finalString, a);
                }
                else
                {
                    finalString = string.Concat(finalString, string.Concat(a, "-"));
                }
            }
            return finalString;
        }
    }
}
