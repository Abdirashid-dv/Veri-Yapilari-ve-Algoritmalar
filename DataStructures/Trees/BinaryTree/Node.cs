namespace Datastructures.Trees.BinaryTree
{
    public class Node<T>
    {

        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public bool isLeaf => Left == null && Right == null;
        public Node()
        {

        }

        public Node(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return $"{Value}";
        }
    }
}