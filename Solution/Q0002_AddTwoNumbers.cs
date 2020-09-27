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
        /// 2. Add Two Numbers
        /// <para>https://leetcode.com/problems/add-two-numbers/</para>
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode node1 = new ListNode(l1.val, l1.next);
            ListNode node2 = new ListNode(l2.val, l2.next);
            ListNode nextNode = new ListNode();
            ListNode result = null;
            int tempValue1, tempValue2, tempValue3;
            int nextValue = 0;

            tempValue1 = node1 == null ? 0 : node1.val;
            tempValue2 = node2 == null ? 0 : node2.val;

            do
            {
                tempValue3 = tempValue1 + tempValue2 + nextValue;
                nextValue = tempValue3 / 10;

                nextNode.val = tempValue3 % 10;

                if((node1 != null && node1.next != null) || (node2 != null && node2.next != null) || nextValue != 0)
                {
                    nextNode.next = new ListNode();

                    result = result ?? new ListNode(nextNode.val, nextNode.next);

                    nextNode = nextNode.next;

                    if(node1.next == null)
                    {
                        tempValue1 = 0;
                    }
                    else
                    {
                        tempValue1 = node1.next.val;
                        node1 = node1.next;
                    }

                    if(node2.next == null)
                    {
                        tempValue2 = 0;
                    }
                    else
                    {
                        tempValue2 = node2.next.val;
                        node2 = node2.next;
                    }
                }
                else
                {
                    result = result ?? new ListNode(nextNode.val, nextNode.next);
                    break;
                }

            } while(true);

            return result;
        }

        public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    }
}
