namespace BinarySearchTree
{
    using System;
    using System.Text;

    class TreeNode<T>
    {
        private T data;
        private int offset;
        private int depth;
        private TreeNode<T> left;
        private TreeNode<T> right;

        public T Data
        {
            get { return this.data; }
            internal set { this.data = value; }
        }

        public int Offset
        {
            get { return this.offset; }
            internal set { this.offset = value; }
        }

        public int Depth
        {
            get { return this.depth; }
            internal set { this.depth = value; }
        }

        public TreeNode<T> Left
        {
            get { return this.left; }
            internal set { this.left = value; }
        }

        public TreeNode<T> Right
        {
            get { return this.right; }
            internal set { this.right = value; }
        }

        public TreeNode(T data)
        {
            this.Data = data;
        }

        public override string ToString()
        {
            return string.Format("Data: {0} (L: {1}, R: {2}) -> Depth: {3}, Offset: {4}", this.Data, this.Left, this.Right, this.Depth, this.Offset);
        }
    }
}
