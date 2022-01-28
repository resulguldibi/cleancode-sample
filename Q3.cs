using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Q3
    {
        static void Main3(string[] args)
        {
            /**
             
            Design and implement a TwoSum class. It should support the following operations: add
            and find.
            add(input) – Add the number input to an internal data structure.
            find(value) – Find if there exists any pair of numbers which sum is equal to the value.
            For example,
            add(1); add(3); add(5); find(4) -> true; find(7) -> false
              
            **/


            TwoSum twoSum = new TwoSum();

            twoSum.add(1);
            twoSum.add(3);
            twoSum.add(5);
            bool found = twoSum.find(4);
            found = twoSum.find(7);


        }
    }

    public class TwoSum
    {
        Dictionary<int, int> map;
        public TwoSum()
        {
            map = new Dictionary<int, int>();
        }

        public void add(int value)
        {
            int count = 0;
            if (map.ContainsKey(value))
            {
                count = map[value];
            }

            map[value] = count + 1;
        }

        public bool find(int total)
        {
            foreach (var entry in map)
            {
                int num1 = entry.Key;
                int num2 = total - num1;

                if (num2.Equals(num1))
                {
                    if (entry.Value >= 2)
                    {
                        return true;
                    }
                }
                else
                {
                    if (map.ContainsKey(num2))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
