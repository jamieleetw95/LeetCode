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

        private void CheckResult(string problemName, string input, string output, string answer)
        {
            Console.WriteLine(string.Format("[{0}] input：{1}, output:{2}，answer：{3}，result = {4}", problemName, input, output, answer, output == answer));
        }
    }
}
