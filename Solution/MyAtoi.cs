using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeeCode
{
    partial class Solution
    {
        public int MyAtoi(string str)
        {
            int result = 0;

            var tempStr = str.TrimStart(new char[] { ' ' });
            if (tempStr.Length==0)
            {
                return result;
            }
            
            var match = Regex.Match(tempStr, @"(-|\+)?\d+");
            
            if (!match.Success || tempStr.IndexOf(match.Value) > 0)
            {               
                return result;
            }

            double l1; 

            if (double.TryParse(match.Value, out l1) 
                && l1 != 0)
            {
                double temp2 = ((double)l1 / Int32.MinValue);

                result = (temp2 > 1)
                        ? Int32.MinValue
                    : (temp2 <= -1) 
                    ? Int32.MaxValue
                        : (int)l1;
            }

            return result;
        }

        internal void MyAtoiTest(string v1, int v2)
        {
            int result = MyAtoi(v1);
            Console.WriteLine(string.Format("MyAtoi test {0}，input：{1}，answer：{2}，myoutput：{3}"
                , result == v2
                , v1
                , v2
                , result));
        }

        public void MyAtoiTest()
        {
            MyAtoiTest("   -42", -42);
            MyAtoiTest("4193 with words", 4193);
            MyAtoiTest("words and 987", 0);
            MyAtoiTest("-91283472332", -2147483648);
            MyAtoiTest("   +0 123", 0);
            MyAtoiTest("-2147483647", -2147483647);
            MyAtoiTest("-2147483649", -2147483648);
            MyAtoiTest("2147483648", 2147483647);
            MyAtoiTest("20000000000000000000", 2147483647);
        }
    }
}
