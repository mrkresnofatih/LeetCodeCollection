using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeCollection.Easy
{
    public class ProblemNo136
    {
        public static void RunCase()
        {
            var nums = new[] {4,1,2,1,2};
            var result = SolveVersion1(nums);
            Console.WriteLine(result);
        }

        private static int SolveVersion1(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num] += 1;
                }
                else
                {
                    dict.Add(num, 1);
                }
            }

            return dict.FirstOrDefault(x => x.Value == 1).Key;
        }
    }
}