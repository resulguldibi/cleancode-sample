using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Q1
    {
        static void Main1(string[] args)
        {
            /**
             
                Question:
                Given an array of integers, find two numbers such that they add up to a specific target
                number.
                The function twoSum should return indices of the two numbers such that they add up to
                the target, where index1 must be less than index2. Please note that your returned answers
                (both index1 and index2) are not zero-based.
                You may assume that each input would have exactly one solution. 
              
             * **/

            //numbers = 1,4,2,3,5,11,8,13
            //target=10
            //answer should be = 3,7

            int[] numbers = new int[] { 1, 4, 2, 3, 5, 11, 8, 13 };
            int target = 10;

            int[] indexes = twoSum(numbers, target);
            Console.WriteLine(string.Join(',', indexes));
        }

        public static int[] twoSum(int[] numbers, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                int x = numbers[i];

                if(x > target)
                {
                    continue;
                }

                if (map.ContainsKey(target - x))
                {
                    return new int[] { map[target - x] + 1, i + 1 };
                }

                map[x] = i;
            }

            throw new Exception("no two sum array");
        }
    }
}
