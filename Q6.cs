using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Q6
    {
        static void Main(string[] args)
        {
            /**
             
            Question:
            Given an input string s, reverse the string word by word.
            For example, given s = "the sky is blue", return "blue is sky the".

            Example Questions Candidate Might Ask:
            Q: What constitutes a word?
            A: A sequence of non-space characters constitutes a word.
            Q: Does tab or newline character count as space characters?
            A: Assume the input does not contain any tabs or newline characters.
            Q: Could the input string contain leading or trailing spaces?
            A: Yes. However, your reversed string should not contain leading or trailing spaces.
            Q: How about multiple spaces between two words?
            A: Reduce them to a single space in the reversed string.

            **/

            string reverseWord = reverse("the sky is blue");
        }


        public static string reverse(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new Exception("null or empty string");
            }

            char[] textChars = text.ToCharArray();
            List<string> words = new List<string>();
            string word = string.Empty;

            foreach (var textChar in textChars)
            {
                if (char.IsWhiteSpace(textChar))
                {
                    if (!string.IsNullOrEmpty(word))
                    {
                        words.Add(word);
                        word = string.Empty;
                    }
                    continue;
                }
                else
                {
                    word += textChar;
                }
            }

            if (!string.IsNullOrEmpty(word))
            {
                words.Add(word);
            }

            string reversed = string.Empty;

            if (words != null && word.Length > 0)
            {
                for (int i = words.Count-1; i >= 0; i--)
                {
                    if (string.IsNullOrEmpty(reversed))
                    {
                        reversed += words[i];
                    }
                    else
                    {
                        reversed += " " + words[i];
                    }
                }
            }

            return reversed;
        }
    }
}
