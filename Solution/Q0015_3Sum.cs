﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCheckConsole.Solution
{
    public partial class Solution
    {
        /// <summary>
        /// 15. 3Sum
        /// <para>https://leetcode.com/problems/3sum/</para>
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            //TODO：
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        bool IsZeroByThreeSum(int a, int b, int c)
        {
            return (a + b + c) == 0 ? true : false;
        }

        public void ThreeSumTest()
        {
            List<int> input = new List<int>() { -1, 0, 1, 2, -1, -4 };
            List<List<int>> output = new List<List<int>>() {
                new List<int>() {-1, -1, 2},
                new List<int>() {-1, 0, 1 }
            };
            var result = ThreeSum(input.ToArray());




            input = new List<int>();
            output = new List<List<int>>();
            result = ThreeSum(input.ToArray());


            input = new List<int>() { 0 };
            output = new List<List<int>>() {};
            result = ThreeSum(input.ToArray());
        }
    }
}

