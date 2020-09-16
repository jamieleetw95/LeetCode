﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public partial class Solution
    {
        public string IntToRoman(int num)
        {
            Dictionary<int, string> nums = new Dictionary<int, string>()
            {
                { 1000,"M"},
                { 500,"D"},
                { 100,"C"},
                { 50,"L"},
                { 10,"X"},
                { 5,"V"},
                { 1,"I"},
            };


            return Division(nums, 0, num, string.Empty);
        }


        private string Division(Dictionary<int, string> nums, int index, int remainder, string preResult)
        {
            var kvp = nums.ElementAt(index);
            string left = string.Empty;
            string right = string.Empty;
            int tempRemainder = remainder;
            int max = tempRemainder / kvp.Key;

            for(int i = 0; i < max; i++)
            {
                right += kvp.Value;
                tempRemainder -= kvp.Key;
            }

            string temp = string.Format("{0}{1}", preResult, right);
            int lastCarryIdx = index + 2;

            if(lastCarryIdx < nums.Count)
            {
                KeyValuePair<int, string> lastCarryKvp = nums.ElementAt(index + 2);
                int remainderCount = tempRemainder / lastCarryKvp.Key;
                right = string.Empty;

                if(remainderCount == 4)
                {
                    left += lastCarryKvp.Value;
                    right += nums.ElementAt(index + 1).Value;
                    tempRemainder -= lastCarryKvp.Key * 4;
                    remainderCount -= 4;
                }
                else if(remainderCount == 9)
                {
                    left += lastCarryKvp.Value;
                    right = kvp.Value;
                    tempRemainder -= lastCarryKvp.Key * 9;
                    remainderCount -= 9;
                }
                else if(remainderCount >= 5)
                {
                    left += nums.ElementAt(index + 1).Value;
                    tempRemainder -= nums.ElementAt(index + 1).Key;
                    remainderCount -= 5;
                }

                if(remainderCount > 0)
                {
                    max = remainderCount;
                    for(int i = 0; i < max; i++)
                    {
                        right += lastCarryKvp.Value;
                        tempRemainder -= lastCarryKvp.Key;
                    }
                }
            }
            

            temp = string.Format("{0}{1}{2}", temp, left, right);

            if(tempRemainder > 0)
            {
                return Division(nums, index + 2, tempRemainder, temp);
            }
            else
            {
                return temp;
            }
        }

        public void IntToRomanTest()
        {
            GetAnswerAndCheck("3", IntToRoman(3), "III");
            GetAnswerAndCheck("4", IntToRoman(4), "IV");
            GetAnswerAndCheck("9", IntToRoman(9), "IX");
            GetAnswerAndCheck("58", IntToRoman(58), "LVIII");
            GetAnswerAndCheck("1994", IntToRoman(1994), "MCMXCIV");
            GetAnswerAndCheck("20", IntToRoman(20), "XX");
            GetAnswerAndCheck("41", IntToRoman(41), "XLI");
        }

    }
}
