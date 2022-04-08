using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.LinkedListTestsSourse
{
    internal class FindIndexByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actualList = new LinkedList(new int[] { 1, 2, 34, 5, 67, 53, 2 });
            int value = 5;
            int expectedIndex = 3;
            yield return new object[] { actualList, expectedIndex, value };
        }
    }
}
