using System;
using System.Collections.Generic;

namespace LeetCodeCollection.Easy
{
    public class ProblemNo202
    {
        public static void RunCase()
        {
            var num = 2;
            var res = SolveVersion1(num);
            Console.WriteLine(res);
        }

        private static bool SolveVersion1(int n)
        {
            int[] GetDigits(int number)
            {
                var listOfInts = new List<int>();
                while (number > 0)
                {
                    listOfInts.Add(number % 10);
                    number /= 10;
                }

                listOfInts.Reverse();
                return listOfInts.ToArray();
            }

            var listOfDigits = GetDigits(n);
            var isDone = false;
            while (n != 1 && !isDone)
            {
                var result = 0;
                foreach (var digit in listOfDigits)
                {
                    result += digit * digit;
                }
                n = result;

                if (n == 4)
                {
                    isDone = true;
                }
                
                listOfDigits = GetDigits(result);

            }

            return !isDone;
        }
    }
}