using System;

namespace AVLTreeNode
{
    class Program
    {
        static void Main(string[] args)
        {
            AVLTree<int> example = new AVLTree<int>();

            example.Add(10);
            example.Add(3);
            example.Add(2);
            example.Add(4);
            example.Add(12);
            example.Add(15);
            example.Add(11);

            foreach (var item in example)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
