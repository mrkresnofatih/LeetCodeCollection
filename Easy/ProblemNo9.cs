using System;
using System.Collections.Generic;

namespace LeetCodeCollection.Easy
{
    public class ProblemNo9
    {
        public static void RunCase()
        {
            int number = 3232;
            var isNumberPalindrome = SolveVersion1(number);
            Console.WriteLine(isNumberPalindrome);
        }

        private static bool SolveVersion1(int x)
        {
            var dict = new Dictionary<int, char>();
            var correspondence = new Dictionary<int, int>();
            var stringNumber = x.ToString();
            for (var i = 0; i < stringNumber.Length; i++)
            {
                dict.Add(i, stringNumber[i]);
                correspondence.Add(i, stringNumber.Length - i - 1);
            }

            var numberOfDigits = dict.Keys.Count;
            var trip = (numberOfDigits % 2 == 0) ? (numberOfDigits / 2) : ((numberOfDigits - 1) / 2);
            for (var index = 0; index < trip; index++)
            {
                var correspondingIndex = correspondence[index];
                var isEqual = dict[index] == dict[correspondingIndex];
                if (!isEqual)
                {
                    return false;
                }
            }

            return true;
        }
    }
}