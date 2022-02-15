using System;
using System.Collections.Generic;

namespace LeetCodeCollection.Easy
{
    public class ProblemNo20
    {
        public static void RunCase()
        {
            var s = "{}[]{}()[]";
            var result = SolveVersion1(s);
            Console.WriteLine(result);
        }

        private static bool SolveVersion1(string s)
        {
            var hashset = new HashSet<string>
                {"()", "{}", "[]"};
            var placeHolder = s;
            var looper = new int[s.Length / 2];
            foreach (var _ in looper)
            {
                foreach (var s1 in hashset)
                {
                    placeHolder = placeHolder.Replace(s1, "");
                }   
            }

            return placeHolder.Length == 0;
        }
    }
}