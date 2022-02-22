using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeCollection.Easy
{
    public class ProblemNo66
    {
        public static void RunCase()
        {
            int[] digits = {5,2,2,6,5,7,1,9,0,3,8,6,8,6,5,2,1,8,7,9,8,3,8,4,7,2,5,8,9};
            // int[] digits = {9,9,9};
            var res = SolveVersion1(digits);
            Console.WriteLine("[{0}]", string.Join(", ", res));
        }

        private static int[] SolveVersion1(int[] digits)
        {
            var lastIndex = digits.Length - 1;
            if (digits[lastIndex] != 9)
            {
                digits[lastIndex] += 1;
                return digits;
            }
            
            for (var i = lastIndex; i >= 0; i--)
            {
                if (digits[i] != 9)
                {
                    digits[i] += 1;
                    return digits;
                }
                digits[i] = 0;
            }

            var result = new List<int>();
            result.AddRange(digits);
            result.Insert(0, 1);

            return result.ToArray();
        }
    }
}