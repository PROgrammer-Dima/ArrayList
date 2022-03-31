using MyArrayLists;
using System.Collections;

namespace MyArrayList.Tests.ArrayListTestsSources
{
    internal class DeleteFirstFoundTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrList actualList = new ArrList(new int[] { 23, 56, 75, 2, 67, 5, 34, -90 });
            int value = 67;
            ArrList expectedList = new ArrList(new int[] { 23, 56, 75, 2, 5, 34, -90 });
            int expectedIndex = 4;
            yield return new object[] { actualList, expectedList, value, expectedIndex };

            actualList = new ArrList(new int[] { 23, 56, 75, 2, 67, 5, 34,67, -90 });
            value = -90;
            expectedList = new ArrList(new int[] { 23, 56, 75, 2,67, 5, 34,67 });
            expectedIndex =8 ;
            yield return new object[] { actualList, expectedList, value, expectedIndex };

            actualList = new ArrList(new int[] { 1, 22, 33, 44, 55 });
            value = 1;
            expectedList = new ArrList(new int[] { 22, 33, 44, 55 });
            expectedIndex = 0;
            yield return new object[] { actualList, expectedList, value, expectedIndex };

        }
    }
}
