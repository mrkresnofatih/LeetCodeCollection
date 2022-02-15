using System;

namespace LeetCodeCollection.Easy
{
    public class ProblemNo14
    {
        public static void RunCase()
        {
            var strs = new[] {"ikangoreng", "ikan", "ikangendut"};
            var result = SolveVersion1(strs);
            Console.WriteLine(result);
        }

        private static string SolveVersion1(string[] strs)
        {
            var shortestLength = 1000;
            foreach (var str in strs)
            {
                var strLength = str.Length;
                if (shortestLength > strLength)
                {
                    shortestLength = strLength;
                }
            }

            var result = "";
            for (int i = 0; i < shortestLength; i++)
            {
                var wordCounter = 0;
                var sample = strs[0][i];
                for (int j = 0; j < strs.Length; j++)
                {
                    if (strs[j][i] == sample)
                    {
                        wordCounter++;
                    }
                }

                if (wordCounter != strs.Length)
                {
                    return result;
                }

                result += sample.ToString();
            }

            return result;
        }
    }
}