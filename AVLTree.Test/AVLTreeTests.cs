using AVLTreeNode;
using NUnit.Framework;
using System.Collections.Generic;

namespace AVLTree.Test
{
    [TestFixture]
    public class AVLTreeTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test, TestCaseSource(typeof(TreeDataSource))]
        public void AddTest(List<int> numbers, List<int> expected)
        {
            AVLTree<int> actualTree = new AVLTree<int>();

            foreach (int i in numbers)
            {
                actualTree.Add(i);
            }

            List<int> actual = new List<int>();

            foreach (var item in actualTree)
            {
                actual.Add(item);
            }

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test, TestCaseSource(typeof(ContainsDataSource))]
        public void ContainsTest(AVLTree<int> actualTree, int parameter, bool expected)
        {
            bool actual = actualTree.Contains(parameter);
            Assert.AreEqual(expected, actual);
        }

        [Test, TestCaseSource(typeof(RemoveDataSource))]
        public void RemoveTest(AVLTree<int> actualTree, int parameter, List<int> expected)
        {
            actualTree.Remove(parameter);

            List<int> actual = new List<int>();

            foreach (var item in actualTree)
            {
                actual.Add(item);
            }

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test, TestCaseSource(typeof(ClearDataSource))]
        public void ClearTest(AVLTree<int> actualTree, AVLTree<int> expected)
        {
            actualTree.Clear();

            CollectionAssert.AreEqual(expected, actualTree);
        }
    }
}