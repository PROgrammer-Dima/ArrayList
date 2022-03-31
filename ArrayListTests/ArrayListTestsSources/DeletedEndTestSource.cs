using MyArrayLists;
using System.Collections;

namespace MyArrayList.Tests.ArrayListTestsSources
{
    internal class DeletedEndTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrList actualList = new ArrList(new int[] { 1, 2, 3, 4, 5, 6 });
            ArrList expectedList = new ArrList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { actualList, expectedList};


            actualList = new ArrList(new int[] { 1, 2, 3, 4, 5, 6,0 });
            expectedList = new ArrList(new int[] { 1, 2, 3, 4, 5,6 });
            yield return new object[] { actualList, expectedList };

            actualList = new ArrList(new int[] { 1, 2, 3, 4, 5, 6,23,44,-90 });
            expectedList = new ArrList(new int[] { 1, 2, 3, 4, 5, 6, 23, 44 });
            yield return new object[] { actualList, expectedList };
        }
    }
}
