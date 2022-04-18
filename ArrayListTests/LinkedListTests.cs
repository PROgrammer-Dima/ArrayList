using NUnit.Framework;
using MyLists.Tests.LinkedListTestsSourse;

namespace MyLists.Tests
{
    public class LinkedListTests
    {
        [TestCaseSource(typeof(AddTestSource))]
        public void AddTest(LinkedList actualList, LinkedList expectedList, int value)
        {
            actualList.Add(value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddFirstTestSource))]
        public void AddFirstTest(LinkedList List, LinkedList expectedList, int value)
        {
            LinkedList actualList = List;
            actualList.AddFirst(value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddInIndexTestSource))]
        public void AddInIndexTest(LinkedList List, LinkedList expectedList, int index, int num)
        {
            LinkedList actualList = List;
            actualList.AddByIndex(index, num);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeletedLastTestSource))]
        public void DeleteLastTest(LinkedList List, LinkedList expectedList)
        {
            LinkedList actualList = List;
            actualList.DeleteLast();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFirstTestSource))]
        public void DeletedFirstTest(LinkedList List, LinkedList expectedList)
        {
            LinkedList actualList = List;
            actualList.DeleteFirst();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteByIndexTestSource))]
        public void DeleteByIndexTest(LinkedList List, LinkedList expectedList, int index)
        {
            LinkedList actualList = List;
            actualList.DeleteByIndex(index);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteRangeEndTestSource))]
        public void RemovingNelementsFromTheEndTest(LinkedList List, LinkedList expectedList, int range)
        {
            LinkedList actualList = List;
            actualList.DeleteRangeEnd(range);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteRangeHeadTestSource))]
        public void DeleteRangeHeadTest(LinkedList List, LinkedList expectedList, int num)
        {
            LinkedList actualList = List;
            actualList.DeleteRangeHead(num);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteRangeByIndexTestSource))]
        public void DeleteRangeByIndexTest(LinkedList List, LinkedList expectedList, int count, int index)
        {
            LinkedList actualList = List;
            actualList.DeleteRangeByIndex(index, count);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(FindIndexTestSource))]
        public void FindIndexTest(LinkedList list, int expectedValue, int index)
        {
           int actualValue = list.FindIndex(index);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestCaseSource(typeof(FindIndexByValueTestSource))]
        public void FindIndexByValueTest(LinkedList List, int expectedIndex, int value)
        {
            int actual = List.FindIndexByValue(value);
            Assert.AreEqual(expectedIndex, actual);
        }
        
        [TestCaseSource(typeof(ChangeValueByIndexTestSource))]
        public void ChangeValueByIndexTest(LinkedList List, LinkedList expectedList, int index, int value)
        {
            LinkedList actualList = List;
            actualList.ChangeValueByIndex(index, value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ReversTestSource))]
        public void ReversTest(LinkedList List, LinkedList expectedList)
        {
            LinkedList actualList = List;
            actualList.Revers();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(FindMaxValueTestSource))]
        public void FindMaxValueTest(LinkedList List, int expectedValue)
        {
            int actual = List.FindMaxValue();
            Assert.AreEqual(expectedValue, actual);
        }

        [TestCaseSource(typeof(FindMinValueTestSource))]
        public void FindMinValueTest(LinkedList List, int expectedValue)
        {
            int actual = List.FindMinValue();
            Assert.AreEqual(expectedValue, actual);
        }
        [TestCaseSource(typeof(FindIndexOfMaxValueTestSource))]
        public void FindIndexOfMaxValueTest(LinkedList List, int expectedIndex)
        {
            int actual = List.FindIndexOfMaxValue();
            Assert.AreEqual(expectedIndex, actual);
        }

        [TestCaseSource(typeof(FindIndexOfMinValueTestSource))]
        public void FindIndexOfMinValueTest(LinkedList List, int expectedIndex)
        {
            int actual = List.FindIndexOfMinValue();
            Assert.AreEqual(expectedIndex, actual);
        }

        [TestCaseSource(typeof(SortOrderListTestSource))]
        public void SortOrderArrayTest(LinkedList List, LinkedList expectedList)
        {
            LinkedList actualList = List;
            actualList.SortOrderList();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(SortLessTestSource))]
        public void SortLessTest(LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.SortLess();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFirstAtValueTestSource))]
        public void DeleteFirstAtValueTest(LinkedList list,LinkedList expectedList, int expectedIndex, int value)
        {
           int actual = list.DeleteFirstAtValue(value);
            Assert.AreEqual(expectedIndex, actual );
            Assert.AreEqual(expectedList, list);
        }

        [TestCaseSource(typeof(DeleteAllAtValueTestSousce))]
        public void DeleteAllAtValueTest(LinkedList list, LinkedList expectedList, int value, int expectedCount)
        {
            int actualCount = list.DeleteAllAtValue(value);
            Assert.AreEqual(expectedList, list);
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}
