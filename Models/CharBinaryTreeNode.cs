namespace DsaInCsharp
{
    public class CharBinaryTreeNode
    {
        public char Value { get; set; }
        public CharBinaryTreeNode Left { get; set; }
        
        public CharBinaryTreeNode Right { get; set; }

        public CharBinaryTreeNode(char value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}