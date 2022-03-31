using MyArrayLists;
using System.Collections;

namespace MyArrayList.Tests.ArrayListTestsSources
{
    internal class DeleteOllFoundTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrList actualList = new ArrList(new int[] { 23, 56, 75, 2, 67, 5, 34, -90 });
            int value = 67;
            ArrList expectedList = new ArrList(new int[] { 23, 56, 75, 2, 5, 34, -90 });
            int expectedCount = 1;
            yield return new object[] { actualList, expectedList, value, expectedCount };

            actualList = new ArrList(new int[] { 23, 56, 75, 2, 67, 5, 34, 67, -90,3,44,55,44,67,544,32,1 });
            value = 67;
            expectedList = new ArrList(new int[] { 23, 56, 75, 2, 5, 34, -90,3,44,55,44,544,32,1 });
            expectedCount = 3;
            yield return new object[] { actualList, expectedList, value, expectedCount };

            actualList = new ArrList(new int[] { 23, 56, 75, 2, 67, 5, 34, 67,67,67 ,-90, 3, 44, 55, 44, 67, 544, 32, 1 });
            value = 67;
            expectedList = new ArrList(new int[] { 23, 56, 75, 2, 5, 34, -90, 3, 44, 55, 44, 544, 32, 1 });
            expectedCount = 5;
            yield return new object[] { actualList, expectedList, value, expectedCount };
        }
    }
}
