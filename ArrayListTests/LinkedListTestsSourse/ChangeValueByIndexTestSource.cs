using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.LinkedListTestsSourse
{
    internal class ChangeValueByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actualList = new LinkedList(new int[] { 12, 33, 2345, 23, 553, 2 });
            LinkedList expectedList = new LinkedList(new int[] { 12, 33, 2345, 23, 12, 2 });
            int index = 4;
            int value = 12;
            yield return new object[] {actualList,expectedList,index,value};

            actualList = new LinkedList(new int[] { 12, 33, 2345, 23, 553, 2 });
            expectedList = new LinkedList(new int[] { 543, 33, 2345, 23, 553, 2 });
            index = 0;
            value = 543;
            yield return new object[] { actualList, expectedList, index, value };

            actualList = new LinkedList(new int[] { 12, 33, 2345, 23, 553, 2 });
            expectedList = new LinkedList(new int[] { 12, 33, 2345, 23, 553, 543 });
            index = 5;
            value = 543;
            yield return new object[] { actualList, expectedList, index, value };
        }
    }
}
