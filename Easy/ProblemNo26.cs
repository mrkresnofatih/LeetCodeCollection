using System;

namespace LeetCodeCollection.Easy
{
    public class ProblemNo26
    {
        public static void RunCase()
        {
            int[] nums = {0,0,1,1,1,2,2,3,3,4};
            var res = SolveVersion1(nums);
            Console.WriteLine(res);
        }

        private static int SolveVersion1(int[] nums)
        {
            var counter = 0;
            var currentInteger = -1000;
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i; j < nums.Length; j++)
                {
                    if (nums[j] > currentInteger)
                    {
                        currentInteger = nums[j];
                        nums[i] = nums[j];
                        counter++;
                        break;
                    }
                }
            }

            return counter;
        }
    }
}