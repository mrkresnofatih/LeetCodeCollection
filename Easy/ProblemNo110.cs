using System;
using System.Collections.Generic;
using DsaInCsharp;

namespace LeetCodeCollection.Easy
{
    public class ProblemNo110
    {
        public static void RunCase()
        {
            var rootNode = new CharBinaryTreeNode('a');
            rootNode.Left = new CharBinaryTreeNode('b');
            rootNode.Right = new CharBinaryTreeNode('c');
            rootNode.Left.Left = new CharBinaryTreeNode('d');
            // rootNode.Left.Left.Left = new CharBinaryTreeNode('e');
            
            var isBalanced = Solve(rootNode);
            Console.WriteLine(isBalanced);
        }

        private static bool Solve(CharBinaryTreeNode node)
        {
            Dictionary<string, int> GetIsBalanced(CharBinaryTreeNode node)
            {
                if (node == null) return new Dictionary<string, int>
                {
                    {"height", 0},
                    {"diff", 0}
                };
                var leftResult = GetIsBalanced(node.Left);
                var leftHeight = leftResult["height"];
                var leftDiff = leftResult["diff"];
                var rightResult = GetIsBalanced(node.Right);
                var rightHeight = rightResult["height"];
                var rightDiff = rightResult["diff"];
                var addHeight = leftHeight > rightHeight ? leftHeight : rightHeight;
                var diff = leftDiff > rightDiff ? leftDiff : rightDiff;
                var newDiff = leftHeight > rightHeight ? leftHeight - rightHeight : rightHeight - leftHeight;
                newDiff = newDiff > diff ? newDiff : diff;
                return new Dictionary<string, int>
                {
                    {"height", addHeight+1},
                    {"diff", newDiff}
                };
            }

            return GetIsBalanced(node)["diff"] <= 1;
        }
    }
}