using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AVLTree.Test
{
    public class TreeDataSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            List<int> parameters = new List<int> { 10, 3, 2, 4, 12, 15, 11 };
            List<int> expected = new List<int> { 2, 3, 4, 10, 11, 12, 15 };

            List<int> parameters2 = new List<int> { 10, 3, 2, 4, 12, 15, 11, 25, 14 };
            List<int> expected2 = new List<int> { 2, 3, 4, 10, 11, 12, 14, 15, 25 };

            yield return new object[] { parameters, expected };
            yield return new object[] { parameters2, expected2 };
        }
    }
}
