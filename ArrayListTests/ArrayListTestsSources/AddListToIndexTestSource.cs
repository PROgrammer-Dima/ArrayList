using MyArrayLists;
using System;
using System.Collections;

namespace MyArrayList.Tests.ArrayListTestsSources
{
    public class AddListToIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrList addList = new ArrList(new int[] { -1, -2, -3, -4 });
            ArrList actualList = new ArrList(new int[] { 1, 2, 3, 4, 5, 6 });
            ArrList expectedList = new ArrList(new int[] {  1, 2, -1, -2, -3, -4, 3, 4, 5, 6 });
            int index = 2;
            yield return new object[] { addList, actualList, expectedList , index};

            addList = new ArrList(new int[] {22,33,44 });
            actualList = new ArrList(new int[] { 6, 5, 4, 3, 2, 1 });
            expectedList = new ArrList(new int[] { 6, 5, 4, 3, 2,22,33,44, 1 });
            index = 5;
            yield return new object[] { addList, actualList, expectedList,index };

            addList = new ArrList(new int[] { });
            actualList = new ArrList(new int[] { 6, 5, 4, 3, 2, 1 });
            expectedList = new ArrList(new int[] { 6, 5, 4, 3, 2, 1 });
            index = 3;
            yield return new object[] { addList, actualList, expectedList,index };

            addList = new ArrList(new int[] { 1, 2, 3 });
            actualList = new ArrList(new int[] { -77, -2, 0, -400 });
            expectedList = new ArrList(new int[] {  -77, -2, 0, 1, 2, 3, -400 });
            index = 3;
            yield return new object[] { addList, actualList, expectedList ,index};
        }
    }
}
