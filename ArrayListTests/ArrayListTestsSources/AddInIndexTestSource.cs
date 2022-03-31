using System.Collections;
using MyArrayLists;

namespace MyArrayList.Tests.ArrayListTestsSources
{
    public class AddInIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrList expectedList = new ArrList(new int[] { 1, 2, 3, 4, 5, 7, 6 });
            ArrList actualList = new ArrList(new int[] { 1, 2, 3, 4, 5, 6 });
            int index = 5;
            int num = 7;

            yield return new object[] { actualList, expectedList, index, num };



            actualList = new ArrList(new int[] { 1, 2, 3, 4, 5, 6 });
            expectedList = new ArrList(new int[] { 7, 1, 2, 3, 4, 5, 6 });
            index = 0;
            num = 7;

            yield return new object[] { actualList, expectedList, index, num };



            actualList = new ArrList(new int[] { 1, 2, 3, 4, 5, 6 });
            expectedList = new ArrList(new int[] { 1, 2, 3, -7, 4, 5, 6 });
            index = 3;
            num = -7;

            yield return new object[] { actualList, expectedList, index,num };
        }
    }

}
