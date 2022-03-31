using MyArrayLists;
using System;
using System.Collections;

namespace MyArrayList.Tests.ArrayListTestsSources
{
    public class AddListToEndTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrList addList = new ArrList(new int[] { 1, 2, 3, 4, 5, 6 });
            ArrList expectedList = new ArrList(new int[] { -1, -2, -3, -4, 1, 2, 3, 4, 5, 6 });
            ArrList actualList = new ArrList(new int[] { -1, -2, -3, -4 });
            yield return new object[]{addList, actualList, expectedList};

            addList = new ArrList(new int[] { });
            actualList = new ArrList(new int[] { 6, 5, 4, 3, 2, 1 });
            expectedList = new ArrList(new int[] { 6, 5, 4, 3, 2, 1 });
            yield return new object[] { addList, actualList, expectedList };

            addList = new ArrList(new int[] { 1, 2, 3 });
            actualList = new ArrList(new int[] { -77, -2, 0, -400 });
            expectedList = new ArrList(new int[] { -77, -2, 0, -400, 1, 2, 3 });
            yield return new object[] { addList, actualList, expectedList };
        }
    }
}
