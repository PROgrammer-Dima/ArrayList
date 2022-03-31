using MyArrayLists;
using System.Collections;

namespace MyArrayList.Tests.ArrayListTestsSources
{
    internal class ChangeValueByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrList actualList = new ArrList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            ArrList expectedList = new ArrList(new int[] { 1, 2, 77, 4, 5, 6, 7 });
            int index = 2;
            int value = 77;
            yield return new object[] { actualList, expectedList, index, value };

            actualList = new ArrList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            expectedList = new ArrList(new int[] { 1, 2,3, 4, 77, 6, 7 });
            index = 4;
            value = 77;
            yield return new object[] { actualList, expectedList, index, value };

            actualList = new ArrList(new int[] { 1, 2, 3, 4, 77, 6, 7 });
            expectedList = new ArrList(new int[] { 1, 2, 3, 4, 77, 6, 0 });
            index = 6;
            value = 0;
            yield return new object[] { actualList, expectedList, index, value };
        }
    }
}

