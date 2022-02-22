using System;
using System.Collections.Generic;
using DsaInCsharp;

namespace LeetCodeCollection.Easy
{
    public class ProblemNo257
    {
        public static void RunCase()
        {
            var rootNode = new IntBinaryTreeNode(1);
            rootNode.Left = new IntBinaryTreeNode(2);
            rootNode.Left.Right = new IntBinaryTreeNode(5);
            rootNode.Right = new IntBinaryTreeNode(3);

            var res = Solve(rootNode);
            Console.WriteLine("[{0}]", string.Join(", ", res));
        }

        private static List<string> Solve(IntBinaryTreeNode node)
        {
            if (node == null) return new List<string>();
            var left = Solve(node.Left);
            var right = Solve(node.Right);
            var res = new List<string>();
            res.AddRange(left);
            res.AddRange(right);
            if (left.Count == 0 && right.Count == 0)
            {
                res.Add(node.Value.ToString());
            }
            else
            {
                for (var i = 0; i < res.Count; i++)
                {
                    var str = node.Value + "->" + res[i];
                    Console.WriteLine(str);
                    res[i] = str;
                }
            }

            return res;
        }
    }
}