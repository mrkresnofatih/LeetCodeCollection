using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeCollection.Easy
{
    public class ProblemNo53
    {
        public static void RunCase()
        {
            var nums = new[] {5,4,-1,7,8};
            // var nums = new[] {}
            // var nums = new[] {1};
            var result = SolveVersion1(nums);
            Console.WriteLine(result);
        }
        
        private static int SolveVersion1(int[] nums)
        {
            var largestSum = nums[0];
            void UpdateTracker(int newSum)
            {
                if (largestSum < newSum)
                {
                    largestSum = newSum;
                }
            }
            
            
            var count = 0;
            for (var index = 0; index < nums.Length; index++)
            {
                count = (nums[index]+count > nums[index]) ? nums[index]+count : nums[index];
                UpdateTracker(count);
            }

            return largestSum;
        }
    }
}