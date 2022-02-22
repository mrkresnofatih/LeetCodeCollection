using System;

namespace LeetCodeCollection.Easy
{
    public class ProblemNo58
    {
        public static void RunCase()
        {
            var s = "   fly me   to   the moon  ";
            var result = SolveVersion1(s);
            Console.WriteLine(result);
        }

        private static int SolveVersion1(string s)
        {
            var splitted = s.Split(" ");
            var result = "";
            foreach (var s1 in splitted)
            {
                if (s1.Length > 0)
                {
                    result = s1;
                }
            }
            return result.Length;
        }
    }
}