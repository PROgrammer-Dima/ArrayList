using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.LinkedListTestsSourse
{
    public class AddInIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expectedList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 71, 6 });
            LinkedList actualList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            int index = 5;
            int num = 71;
            yield return new object[] { actualList, expectedList, index, num };


            actualList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            expectedList = new LinkedList(new int[] { 23, 1, 2, 3, 4, 5, 6 });
            index = 0;
            num = 23;
            yield return new object[] { actualList, expectedList, index, num };


            actualList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            expectedList = new LinkedList(new int[] { 1, 2, 3, -77, 4, 5, 6 });
            index = 3;
            num = -77;
            yield return new object[] { actualList, expectedList, index, num };
        }
    }
}
