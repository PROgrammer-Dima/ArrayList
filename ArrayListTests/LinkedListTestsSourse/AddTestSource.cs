using System;
using System.Collections;

namespace MyLists.Tests.LinkedListTestsSourse
{
    public class AddTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actualList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList expectedList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            int value = 6;
            yield return new object[] { actualList, expectedList, value };

            actualList = new LinkedList(new int[] { });
            expectedList = new LinkedList(new int[] { 7 });
            value = 7;
            yield return new object[] { actualList, expectedList, value };
        }
    }
}
