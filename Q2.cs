using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Q2
    {
        static void Main2(string[] args)
        {
            /**
             
            Similar to Question [1. Two Sum], except that the input array is already sorted in ascending order.
              
            **/

            //numbers = 1,2,3,4,5,8,11,13
            //target=10
            //answer should be = 2,6

            int[] numbers = new int[] { 1, 2, 3, 4, 4, 4, 5, 8, 11, 13 };
            int target = 8;
            bool found = false;
            int index = -1;

            int[] indexes = twoSum(numbers, target);
            Console.WriteLine(string.Join(',', indexes));
        }

        public static int[] twoSumV2(int[] numbers, int target)
        {
            int i = 0;
            int j = numbers.Length - 1;

            while (i <= j)
            {
                var sum = numbers[i] + numbers[j];
                if (sum == target)
                {
                    return new int[] { i + 1, j + 1 };
                }

                if(sum > target)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }

            throw new Exception("no two sum array");
        }

        public static int[] twoSum(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                bool found = false;
                int index = -1;

                (found, index) = binarySearch(numbers, target - numbers[i], i + 1);

                if (found)
                {
                    return new int[] { i + 1, index + 1 };
                }
            }

            throw new Exception("no two sum array");
        }

        public static (bool, int) binarySearch(int[] numbers, int target, int start)
        {

            int end = numbers.Length - 1;
            bool found = false;
            int index = -1;

            while (start <= end)
            {
                int mean = (start + end) / 2;

                if (numbers[mean] == target)
                {
                    index = mean;
                    found = true;
                    break;
                }

                if (numbers[mean] < target)
                {
                    start = mean + 1;
                }
                else
                {
                    end = mean - 1;
                }
            }


            return (found, index);
        }
    }
}
