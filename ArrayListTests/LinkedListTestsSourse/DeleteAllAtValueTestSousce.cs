using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.LinkedListTestsSourse
{
    public class DeleteAllAtValueTestSousce : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 2, 4, 5, 2, 1 });
            LinkedList expectedList = new LinkedList(new int[] { 1,  3,  4, 5,  1 });
            int value = 2;
            int expectedCount = 3;
            yield return new object[] {list, expectedList, value, expectedCount};

            list = new LinkedList(new int[] {2,2,2,2 });
            expectedList = new LinkedList(new int[] { });
            value = 2;
            expectedCount = 4;
            yield return new object[] { list, expectedList, value, expectedCount };

            list = new LinkedList(new int[] {1 });
            expectedList = new LinkedList(new int[] { });
            value = 1;
            expectedCount = 1;
            yield return new object[] { list, expectedList, value, expectedCount };

            list = new LinkedList(new int[] { 1,23,5,3,212,4 });
            expectedList = new LinkedList(new int[] { 1, 23, 5, 3, 212, 4 });
            value = 55;
            expectedCount = 0;
            yield return new object[] { list, expectedList, value, expectedCount };

        }
    }
}
