namespace DsaInCsharp
{
    public class IntBinaryTreeNode
    {
        public int Value { get; set; }
        public IntBinaryTreeNode Left { get; set; }
        public IntBinaryTreeNode Right { get; set; }

        public IntBinaryTreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}