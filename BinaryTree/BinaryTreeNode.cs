using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    // перечисления расположения узла относительно родителя
    public enum Side
    {
        Left, 
        Right
    }

    // узел бинарного дерева
    public class BinaryTreeNode<T> where T : IComparable
    {
        public BinaryTreeNode(T data)
        {
            data = data;
        }

        // данные которые хранятся в узле
        public T Data { get; set; }

        // левая ветка
        public BinaryTreeNode<T> LeftNode { get; set; }

        // правая ветка
        public BinaryTreeNode<T> RightNode { get; set; }

        // родитель
        public BinaryTreeNode<T> ParentNode { get; set; }

        // расположение узла относительно его родителя
        public Side? NodeSide =>
            ParentNode == null
            ? (Side?)null
            : ParentNode.LeftNode == this
                ? Side.Left
                : Side.Right;

        // преобразование экземпляра в строку
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
