using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCheckConsole
{
    public partial class Solution
    {
        public bool IsMatch(string s, string p)
        {
            bool isMatch = true;
            char compareChar = p[0];
            int pIdx = 0;

            for(int i = 0; i < s.Length; i++)
            {
                //var temp1 = p[pIdx];
                //var temp2 = s[i];

                if(pIdx >= p.Length)
                {
                    isMatch = false;
                    break;
                }

                if(p[pIdx] == '.')
                {
                    pIdx++;
                    continue;
                }
                else if(p[pIdx] != '*')
                {
                    compareChar = p[pIdx];
                    pIdx++;
                }


                if(compareChar == '.')
                {
                    continue;
                }

                if(compareChar != s[i])
                {
                    isMatch = false;
                    break;
                }
            }

            return isMatch;
        }

        public void RegularExpressionMatchingTest()
        {
            string s = "aa";
            string p = "a";
            CheckResult(string.Format("[ s：{0}，p：{1} ]", s, p), IsMatch(s, p).ToString(), "False");

            s = "aa";
            p = "a*";
            CheckResult(string.Format("[ s：{0}，p：{1} ]", s, p), IsMatch(s, p).ToString(), "True");

            s = "ab";
            p = ".*";
            CheckResult(string.Format("[ s：{0}，p：{1} ]", s, p), IsMatch(s, p).ToString(), "True");

            s = "aab";
            p = "c*a*b";
            CheckResult(string.Format("[ s：{0}，p：{1} ]", s, p), IsMatch(s, p).ToString(), "True");

            s = "mississippi";
            p = "mis*is*p*.";
            CheckResult(string.Format("[ s：{0}，p：{1} ]", s, p), IsMatch(s, p).ToString(), "False");
        }
    }
}
