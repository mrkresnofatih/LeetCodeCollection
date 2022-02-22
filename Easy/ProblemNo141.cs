using System;
using System.Collections.Generic;

namespace LeetCodeCollection.Easy
{
    public class ProblemNo141
    {
        public static void RunCase()
        {
            var Node1 = new ListNode(3);
            Node1.next = new ListNode(2);
            Node1.next.next = new ListNode(0);
            Node1.next.next.next = new ListNode(4);
            Node1.next.next.next.next = Node1.next;

            var isCycling = SolveVersion1(Node1);
            Console.WriteLine(isCycling);
        }

        private static bool SolveVersion1(ListNode head)
        {
            if (head == null)
            {
                return false;
            }
            
            var setOfListNodes = new HashSet<ListNode>();
            var isCycling = false;
            var currentNode = head;
            while (!isCycling && currentNode.next != null)
            {
                if (!setOfListNodes.Contains(currentNode))
                {
                    setOfListNodes.Add(currentNode);
                }
                else
                {
                    isCycling = true;
                    return isCycling;
                }
                currentNode = currentNode.next;
            }
            
            return isCycling;
        }

        class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }
    }
}