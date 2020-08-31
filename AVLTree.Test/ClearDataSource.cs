using AVLTreeNode;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AVLTree.Test
{
    public class ClearDataSource : IEnumerable
    {

        AVLTree<int> actualTree = new AVLTree<int>();

        public IEnumerator GetEnumerator()
        {
            List<int> parameters = new List<int> { 10, 3, 2, 4, 12, 15, 11 };

            foreach (int i in parameters)
            {
                actualTree.Add(i);
            }

            AVLTree<int> expectedTree = new AVLTree<int>();

            yield return new object[] { actualTree, expectedTree };

        }
    }
}
