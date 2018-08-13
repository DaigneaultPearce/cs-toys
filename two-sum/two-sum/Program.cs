/*Daigneault Pearce
 * Solultion to two-sum leetcode problem in c-sharp
 * using Dictionary
 * Given an array and a target value return the indices
 * of the values which sum corresponds to the target
 */

using System;
using System.Collections.Generic;

namespace two_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[4] { 2, 7, 11, 13 };
            int[] res;
            res = TwoSums(test, 20);
            Console.WriteLine("[{0}, {1}]", res[0], res[1]);
        }
        public static int[] TwoSums(int[] nums, int target)
        {
            int[] solution = new int[] { 0, 0 };
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++)
            {
                //Handle duplicates
                if (dic.ContainsKey(nums[i]))
                    continue;
                else
                    dic.Add(nums[i], i);
            }
            for(int i = 0; i < nums.Length; i++)
            {
                int compliment = target - nums[i];
                if(dic.ContainsKey(compliment) && dic[compliment] != i)
                {
                    solution[0] = dic[compliment];
                    solution[1] = i;
                }
            }
            return solution;
        }
    }
}
