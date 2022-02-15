using System;
using System.Collections.Generic;

namespace LeetCodeCollection.Easy
{
    public class ProblemNo13
    {
        public static void RunCase()
        {
            var rom = "MMMXLV";
            Console.WriteLine(SolveVersion1(rom));
        }

        private static int SolveVersion1(string s)
        {
            string ReplaceFirst(string text, string search, string replace)
            {
                int pos = text.IndexOf(search);
                if (pos < 0)
                {
                    return text;
                }
                return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
            }
            
            Dictionary<string, int> romanNormal = new Dictionary<string, int>
            {
                {"I", 1},
                {"V", 5},
                {"X", 10},
                {"L", 50},
                {"C", 100},
                {"D", 500},
                {"M", 1000}
            };

            Dictionary<string, int> romanMix = new Dictionary<string, int>
            {
                {"IV", 4},
                {"IX", 9},
                {"XL", 50},
                {"XC", 90},
                {"CD", 400},
                {"CM", 900}
            };

            int result = 0;
            string template = s;
            while (template.Length != 0)
            {
                foreach (var romanMixKey in romanMix.Keys)
                {
                    if (template.Contains(romanMixKey))
                    {
                        result += romanMix[romanMixKey];
                        template = ReplaceFirst(template, romanMixKey, "");
                    }
                }

                foreach (var romanNormalKey in romanNormal.Keys)
                {
                    if (template.Contains(romanNormalKey))
                    {
                        result += romanNormal[romanNormalKey];
                        template = ReplaceFirst(template, romanNormalKey, "");
                    }
                }   
            }

            return result;
        }
    }
}