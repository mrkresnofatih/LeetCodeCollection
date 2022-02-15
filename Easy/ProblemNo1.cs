using System;
using System.Collections.Generic;

namespace LeetCodeCollection.Easy
{
    public class ProblemNo1
    {
        public static void RunCase()
        {
            int[] nums = {3, 2, 4};
            int target = 6;
            var result = SolveVersion1(nums, target);
            Console.WriteLine("[{0}]", string.Join(", ", result));
        }

        private static int[] SolveVersion1(int[] nums, int target)
        {
            if (nums.Length == 2)
            {
                return new[] {0, 1};
            }
            var indices = new int[2];
            for (var index = 0; index < nums.Length; index++)
            {
                for (var deepIndex = index + 1; deepIndex < nums.Length; deepIndex++)
                {
                    if (nums[index] + nums[deepIndex] == target)
                    {
                        indices[0] = index;
                        indices[1] = deepIndex;
                        break;
                    }
                }
            }

            return indices;
        }
    }
}