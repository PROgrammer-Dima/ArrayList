using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.LinkedListTestsSourse
{
    internal class DeleteRangeByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actualList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            LinkedList expectedList = new LinkedList(new int[] { 1, 5, 6, 7 });
            int index = 1;
            int count = 3;
            yield return new object[] { actualList, expectedList, index, count };

            actualList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            expectedList = new LinkedList(new int[] { 1, 2, 7 });
            index = 2;
            count = 4;
            yield return new object[] { actualList, expectedList, index, count };

            actualList = new LinkedList(new int[] { 0, 2, 3, -4, 5, 6, 7 });
            expectedList = new LinkedList(new int[] { 0,  7 });
            index = 1;
            count = 5;
            yield return new object[] { actualList, expectedList, index, count };

            actualList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            expectedList = new LinkedList(new int[] { 5,6, 7 });
            index = 0;
            count = 4;
            yield return new object[] { actualList, expectedList, index, count };
        }
    }
}
