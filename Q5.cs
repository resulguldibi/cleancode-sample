using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Q5
    {
        static void Main5(string[] args)
        {
            /**
             
            Question:
            Implement strstr(). Returns the index of the first occurrence of needle in haystack, or –1
            if needle is not part of haystack.

            **/

            var xx = strstr("haystack", "sta");
        }

        public static int strstr(string text, string search)
        {
            char[] textChars = text.ToCharArray();
            char[] searchChars = search.ToCharArray();

            for (int i = 0; i < textChars.Length - searchChars.Length; i++)
            {
                bool isMatched = true;
                for (int j = 0; j < searchChars.Length; j++)
                {
                    if (!textChars[i + j].Equals(searchChars[j]))
                    {
                        isMatched = false;
                        break;
                    }
                }

                if (isMatched)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
