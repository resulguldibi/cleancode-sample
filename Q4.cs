using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Q4
    {
        static void Main4(string[] args)
        {
            /**
             
            Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
            For example,
            "A man, a plan, a canal: Panama" is a palindrome.
            "race a car" is not a palindrome.
              
            Example Questions Candidate Might Ask:
            Q: What about an empty string? Is it a valid palindrome?
            A: For the purpose of this problem, we define empty string as valid palindrome.
            **/

            //var _isPalindrome = isPalindrome("A man, a plan, a canal: Panama");

            var _isPalindrome = isPalindrome("race a car");
        }

        public static bool isPalindrome(string text)
        {
            int i = 0;
            char[] chars = text.ToCharArray();

            int j = chars.Length - 1;

            while (i <= j)
            {

                if (!char.IsLetterOrDigit(chars[i]))
                {
                    i++;
                    continue;
                }

                if (!char.IsLetterOrDigit(chars[j]))
                {
                    j--;
                    continue;
                }

                if (char.ToLower(chars[i]).Equals(char.ToLower(chars[j])))
                {
                    i++;
                    j--;
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
