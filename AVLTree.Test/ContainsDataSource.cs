using AVLTreeNode;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AVLTree.Test
{
    public class ContainsDataSource : IEnumerable
    {

        AVLTree<int> actualTree = new AVLTree<int>();

        public IEnumerator GetEnumerator()
        {
            List<int> parameters = new List<int> { 10, 3, 2, 4, 12, 15, 11 };

            foreach (int i in parameters)
            {
                actualTree.Add(i);
            }

            yield return new object[] { actualTree, 11, true };
            yield return new object[] { actualTree, 10, true };
            yield return new object[] { actualTree, 2, true };
            yield return new object[] { actualTree, 6, false };
            yield return new object[] { actualTree, 8, false };
        }
    }
}
