using MyArrayLists;
using System.Collections;

namespace MyArrayList.Tests.ArrayListTestsSources
{
    internal class SortLessArrayTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrList actualList = new ArrList(new int[] { 23, 56, 75, 2, 67, 5, 34, -90 });
            ArrList expectedList = new ArrList(new int[] { 75, 67, 56, 34, 23, 5, 2, -90 });
            yield return new object[] { actualList, expectedList };

            actualList = new ArrList(new int[] { 12, 5, 76, 3, 67, 0, 6, 3,-1 });
            expectedList = new ArrList(new int[] { 76, 67,12,6, 5,3,3,0,-1 });
            yield return new object[] { actualList, expectedList };
        }
    }
}
