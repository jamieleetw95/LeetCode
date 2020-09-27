using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCheckConsole.Solution
{
    public partial class Solution
    {
        /// <summary>
        /// 3. Longest Substring Without Repeating Characters       
        /// <para>https://leetcode.com/problems/longest-substring-without-repeating-characters/</para>
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring(string str)
        {
            int result = 0;

            if(str.Length == 0)
            {
                return result;
            }
            else
            {
                result = 1;

                if(str.Length < 2)
                {
                    return result;
                }
            }


            int stratIdx = 0;
            int count = 1;
            int nextIdx;
            string tempStr1;
            int len;


            do
            {
                tempStr1 = str.Substring(stratIdx, count);
                nextIdx = stratIdx + count;

                if(nextIdx < str.Length && !tempStr1.Contains(str.Substring(nextIdx, 1)))
                {
                    len = tempStr1.Length + 1;
                    count++;

                    if(result < len)
                    {
                        result = len;
                    }

                    if(nextIdx < str.Length)
                    {
                        continue;
                    }
                }

                // reset
                stratIdx++;
                count = 1;

            } while(stratIdx + 1 < str.Length);

            return result;
        }

        public void LengthOfLongestSubstringTest()
        {
            var v1 = LengthOfLongestSubstring("abcabcbb");
            Console.WriteLine(v1);

            v1 = LengthOfLongestSubstring("bbbbb");
            Console.WriteLine(v1);

            v1 = LengthOfLongestSubstring("pwwkew");
            Console.WriteLine(v1);

            v1 = LengthOfLongestSubstring("");
            Console.WriteLine(v1);

            v1 = LengthOfLongestSubstring(" ");
            Console.WriteLine(v1);
        }
    }
}
