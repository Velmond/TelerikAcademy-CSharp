namespace BinarySearchTree
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    struct BinarySearchTree<T> : IEnumerable<TreeNode<T>>, ICloneable
        where T : IComparable<T>
    {
        private TreeNode<T> center;

        public TreeNode<T> Center
        {
            get { return this.center; }
        }

        public void Add(T data)
        {
            if (this.Center == null)
            {
                this.center = new TreeNode<T>(data);
                this.Center.Depth = 1;
                this.Center.Offset = 0;
            }
            else
            {
                TreeNode<T> current = this.Center;
                TreeNode<T> next;
                int depth = this.Center.Depth;
                int offset = this.Center.Offset;

                while (true)
                {
                    depth++;

                    if (data.CompareTo(current.Data) <= 0)
                    {
                        offset--;
                        next = current.Left;

                        if (next == null)
                        {
                            current.Left = new TreeNode<T>(data);
                            current.Left.Depth = depth;
                            current.Left.Offset = offset;
                            break;
                        }
                    }
                    else
                    {
                        offset++;
                        next = current.Right;

                        if (next == null)
                        {
                            current.Right = new TreeNode<T>(data);
                            current.Right.Depth = depth;
                            current.Right.Offset = offset;
                            break;
                        }
                    }

                    current = next;
                }
            }
        }

        public TreeNode<T> Find(T data)
        {
            if (this.Center == null)
            {
                throw new NullReferenceException("BinarySearchTree is empty.");
            }
            else
            {
                Stack<TreeNode<T>> parentStack = new Stack<TreeNode<T>>();
                TreeNode<T> current = this.Center;
                int depth = 1;

                while (true)
                {
                    if (data.CompareTo(current.Data) != 0)
                    {
                        if (current.Left == null && data.CompareTo(current.Data) < 0)
                        {
                            return null;
                        }
                        if (current.Right == null && data.CompareTo(current.Data) > 0)
                        {
                            return null;
                        }

                        if (current.Left == null && current.Right == null)
                        {
                            while (current.Right == null)
                            {
                                depth--;

                                if (depth < 0)
                                {
                                    return null;
                                }

                                current = parentStack.Pop();
                            }
                        }
                        else if (current.Left == null && current.Right != null)
                        {
                            parentStack.Push(current);
                            current = current.Right;
                            depth++;
                        }
                        else if (current.Left != null && current.Right == null)
                        {
                            parentStack.Push(current);
                            current = current.Left;
                            depth++;
                        }
                        else if (current.Right != null && current.Left != null)
                        {
                            if (data.CompareTo(current.Right.Data) < 0)
                            {
                                parentStack.Push(current);
                                current = current.Left;
                                depth++;
                            }
                            else if (data.CompareTo(current.Left.Data) > 0)
                            {
                                parentStack.Push(current);
                                current = current.Right;
                                depth++;
                            }
                        }

                        if (data.CompareTo(current.Data) == 0)
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                return current;
            }
        }

        public void Remove(T data)
        {
            TreeNode<T> nodeToRemove = ReplaceNode(Find(data));
        }

        private TreeNode<T> ReplaceNode(TreeNode<T> node)
        {
            TreeNode<T> result;

            if (node.Right != null)
            {
                node = node.Right;

                while (node.Left != null)
                {
                    node = node.Left;
                }

                result = node.Left;
                node = null;
                // node.Right (if there is such) should be translated one node up
                return result;
            }
            else if (node.Left != null)
            {
                result = node.Left;
                // everything bellow nodeToDelete.Left should be translated one node up
                return result;
            }
            else
            {
                return null;
            }
        }

        // ICloneable
        public object Clone()
        {
            BinarySearchTree<T> newTree = this;
            return newTree;
        }

        // IEnumerable<TreeNode<T>>
        public IEnumerator<TreeNode<T>> GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // TO DO
            throw new System.NotImplementedException();
        }

        // Standard methods from System.Object
        public override bool Equals(object obj)
        {
            BinarySearchTree<T> other = (BinarySearchTree<T>)obj;

            foreach (var node in other)
            {
                if (this.Find(node.Data) == null)
                {
                    return false;
                }
            }

            foreach (var node in this)
            {
                if (other.Find(node.Data) == null)
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();

            //StringBuilder toString = new StringBuilder();

            //foreach (var node in this)
            //{
            //    toString.AppendLine(string.Format("Node data: {0} (L:{1}/R:{2}) -> Depth: {3}, Offset: {4}", 
            //        node.Data, node.Left.Data, node.Right.Data, node.Depth, node.Offset));
            //}

            //return toString.ToString();
        }

        // Operators == and !=
        public static bool operator ==(BinarySearchTree<T> firstTree, BinarySearchTree<T> secondTree)
        {
            return BinarySearchTree<T>.Equals(firstTree, secondTree);
        }

        public static bool operator !=(BinarySearchTree<T> firstTree, BinarySearchTree<T> secondTree)
        {
            return !BinarySearchTree<T>.Equals(firstTree, secondTree);
        }
    }
}
