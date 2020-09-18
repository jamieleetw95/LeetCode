using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCheckConsole
{
    public partial class Solution
    {
        private void CheckResult(string input, string output, string answer)
        {
            Console.WriteLine(string.Format("input：{0}, output:{1}，answer：{2}，result = {3}", input, output, answer, output == answer));
        }
    }
}
