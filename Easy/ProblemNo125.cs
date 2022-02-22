using System;

namespace LeetCodeCollection.Easy
{
    public class ProblemNo125
    {
        public static void RunCase()
        {
            var text = "A man, a plan, a canal: Panama";
            var palindrome = IsPalindrome(text);
            Console.WriteLine(palindrome);
        }

        private static bool IsPalindrome(string s)
        {
            string TextStripper(string unstrippedText)
            {
                var sb = "";
                foreach(var c in unstrippedText.ToLower())
                {
                    if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9'))
                    {
                        sb += c;
                    }
                }
                return sb;
            }

            var strippedText = TextStripper(s);
            var loopLimit = strippedText.Length / 2;
            for (var i = 0; i < loopLimit; i++)
            {
                if (strippedText[i] != strippedText[strippedText.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}