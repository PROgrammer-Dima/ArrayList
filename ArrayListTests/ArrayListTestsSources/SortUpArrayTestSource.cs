using MyArrayLists;
using System.Collections;

namespace MyArrayList.Tests.ArrayListTestsSources
{
    internal class SortOrderArrayTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrList actualList = new ArrList(new int[] { 23,56,75,2,67,5,34,-90});
            ArrList expectedList = new ArrList(new int[] { -90, 2, 5, 23, 34, 56, 67, 75});
            yield return new object[] { actualList, expectedList };

            actualList = new ArrList(new int[] { 12, 5, 76, 3, 67, 0, 6, 3, -1 });
            expectedList = new ArrList(new int[] { -1,0,3,3,5,6,12,67,76 });
            yield return new object[] { actualList, expectedList };
        }
    }
}
