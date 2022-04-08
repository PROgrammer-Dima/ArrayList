using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.LinkedListTestsSourse
{
    internal class FindIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actualList = new LinkedList(new int[] {1,2,3,4,5,6,65});
            int expectedValue = 1;
            int index = 0;
            yield return new object[] { actualList, index, expectedValue };
        }
    }
}
