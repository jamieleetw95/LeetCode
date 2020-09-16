using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public partial class Solution
    {
        /// <summary>
        /// 6. ZigZag Conversion
        /// <para>https://leetcode.com/problems/zigzag-conversion/</para>
        /// </summary> 
        /// <param name="s"></param>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public string Convert(string s, int numRows)
        {
            List<List<char>> temp = new List<List<char>>();
            int targetIdx = 0;
            int colIdx = 0;
            int max = numRows - 1;

            for(int i = 0; i < numRows; i++)
            {
                temp.Add(new List<char>());
            }

            do
            {
                if(colIdx % max == 0)
                {
                    for(int i = 0; i < numRows; i++)
                    {
                        temp[i].Add(s[targetIdx]);
                        targetIdx++;
                        if(targetIdx == s.Length)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    for(int i = 0; i < numRows; i++)
                    {
                        if(i == 0 || i== max)
                        {
                            temp[i].Add(' ');
                        }
                        else
                        {
                            temp[i].Add(s[targetIdx]);
                            targetIdx++;
                            if(targetIdx == s.Length)
                            {
                                break;
                            }
                        }
                    }
                }

                colIdx++;
            } while(targetIdx < s.Length);

            return string.Concat(temp.SelectMany(x => x.Where(y => !(y == ' '))));
        }

        public void ZigZagConversionTest()
        {
            string s = "PAYPALISHIRING";
            int numRows = 3;

            GetAnswerAndCheck(s, Convert(s, numRows), "PAHNAPLSIIGYIR");

            s = "PAYPALISHIRING";
            numRows = 4;
            GetAnswerAndCheck(s, Convert(s, numRows), "PINALSIGYAHRPI");
        }
    }
}
