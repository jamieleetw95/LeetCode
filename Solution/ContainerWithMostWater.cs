using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode
{
    partial class Solution
    {
        public int ContainerWithMostWater(int[] inputs)
        {
            int result = 0;
            int max = inputs.Length - 1;
            int tempLen;
            var orderArray = OrderArray(inputs);
            int tempValue;
            int lastVaule = 0;
            int lastLen = 0;
            int lastT = 0;

            for (int i = 0; i <= max-1; i++)
            {
                var temp1 = orderArray.ElementAt(i);

                for (int j = i+1; j <= max; j++)
                {
                    var temp2 = orderArray.ElementAt(j);
                    if(temp2.Value== lastVaule)
                    {
                        continue;
                    }

                    tempLen = Math.Abs(temp1.Key - temp2.Key);

                    if (tempLen < lastLen)
                    {
                        continue;
                    }
                    tempValue = temp2.Value * tempLen;
                    if(tempValue>= result)
                    {
                        result = tempValue;
                    }
                    
                }
            }            

            return result;
        }

        private IOrderedEnumerable<KeyValuePair<int,int>> OrderArray(int[] inputs)
        {
            int i = 0;
            return inputs
                .ToDictionary(x => i++, y => y)
                .OrderByDescending(x=>x.Value).ThenBy(x=>x.Key);
        }

        public void ContainerWithMostWaterTest(int[] inputs, int anwser)
        {

            int result = ContainerWithMostWater(inputs);
            Console.WriteLine(string.Format("ContainerWithMostWater test {0}，input：{1}，answer：{2}，myoutput：{3}"
                , result == anwser
                , string.Join(",", inputs.Select(x => x.ToString()))
                , anwser
                , result));
        }
    }
}
