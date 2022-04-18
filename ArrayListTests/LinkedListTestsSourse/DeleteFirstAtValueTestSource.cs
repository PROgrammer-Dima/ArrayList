using System;
using System.Collections;

namespace MyLists.Tests.LinkedListTestsSourse
{
    public class DeleteFirstAtValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actualList = new LinkedList(new int[] {1,2,34,56,7,3,1});
            LinkedList expectedList = new LinkedList(new int[] { 1, 2, 56, 7, 3, 1 });
            int expectedIndex = 2;
            int value = 34;
            yield return new object[] { actualList, expectedList, expectedIndex, value };

            actualList = new LinkedList(new int[] { 1, 2, 34, 56, 7, 3, 1 });
            expectedList = new LinkedList(new int[] { 2, 34, 56, 7, 3, 1 });
            expectedIndex = 0;
            value = 1;
            yield return new object[] { actualList,expectedList, expectedIndex, value };

            actualList = new LinkedList(new int[] { 1 });
            expectedList = new LinkedList(new int[] { });
            expectedIndex = 0;
            value = 1;
            yield return new object[] { actualList, expectedList, expectedIndex, value };

            actualList = new LinkedList(new int[] { 1, 2, 34, 56, 7, 3, 11 });
            expectedList = new LinkedList(new int[] { 1, 2, 34, 56, 7, 3 });
            expectedIndex = 6;
            value = 11;
            yield return new object[] { actualList, expectedList, expectedIndex, value };

        }
    }
}
