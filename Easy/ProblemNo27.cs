using System;

namespace LeetCodeCollection.Easy
{
    public class ProblemNo27
    {
        public static void RunCase()
        {
            int[] nums = {0, 1, 2, 2, 3, 0, 4, 2};
            var res = SolveVersion1(nums, 2);
            Console.WriteLine("[{0}]", string.Join(", ", res));
        }

        private static int[] SolveVersion1(int[] nums, int val)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
                if (nums[i] != val)
                {
                    continue;
                }

                var j = i;
                while (nums[j] == val)
                {
                    Console.WriteLine();
                    Console.WriteLine(j);
                    Console.WriteLine(i);
                    j++;
                }

                nums[i] = nums[j];
            }

            return nums;
        }
    }
}