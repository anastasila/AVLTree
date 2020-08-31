using AVLTreeNode;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AVLTree.Test
{
    public class RemoveDataSource : IEnumerable
    {

        AVLTree<int> actualTree = new AVLTree<int>();
        AVLTree<int> balanceTree = new AVLTree<int>();

        public IEnumerator GetEnumerator()
        {
            List<int> parameters = new List<int> { 10, 3, 2, 4, 12, 15, 11 };

            foreach (int i in parameters)
            {
                actualTree.Add(i);
            }

            List<int> expected = new List<int> { 2, 3, 4, 10, 12, 15 };
            List<int> expected2 = new List<int> { 3, 4, 10, 12, 15 };
            List<int> expected3 = new List<int> { 3, 4, 10, 12 };            

            List<int> parameters2 = new List<int> { 10, 3, 2, 4, 12, 15, 11, 25, 14 };
            foreach (int i in parameters2)
            {
                balanceTree.Add(i);
            }
            List<int> expected4 = new List<int> { 2, 3, 4, 10, 12, 14, 15, 25 };

            yield return new object[] { actualTree, 11, expected };
            yield return new object[] { actualTree, 2, expected2 };
            yield return new object[] { actualTree, 15, expected3 };
            yield return new object[] { balanceTree, 11, expected4 };

        }
    }
}
