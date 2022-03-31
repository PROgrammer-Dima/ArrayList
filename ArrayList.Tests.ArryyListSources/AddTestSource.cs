using NUnit.Framework;
using System.Collections;
using MyArrayLists;

namespace ArrayListTests.ArrayListSources
{
        public class AddTestSource : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                ArrayList actualList = new ArrList(new int[] { 1, 2, 3, 4, 5, 6 });
                ArrayList expectedList = new ArrList(new int[] { 7, 1, 2, 3, 4, 5, 6 });
                int num = 7;

                yield return new object[] { actualList, expectedList, num };
            }
        }
    
}