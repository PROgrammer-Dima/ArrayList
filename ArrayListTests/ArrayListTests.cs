using MyArrayList.Tests.ArrayListTestsSources;
using MyArrayLists;
using NUnit.Framework;
using System;
using System.Collections;

namespace ArrayListTests
{
    public class ArrayListsTest
    {
        [TestCaseSource(typeof(AddTestSource))]
        public void AddTest( ArrList List, ArrList expectedList, int num )
        {
            ArrList actualList = List;
            actualList.Add(num);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListToEndTestSource))]
        public void AddListToEndTest(ArrList list, ArrList actuallist, ArrList expectedList)
        {
            actuallist.AddListToEnd(list);
            Assert.AreEqual(expectedList, actuallist);
        }

        [TestCaseSource(typeof(AddFirstTestSource))]
        public void AddFirstTest(ArrList List, ArrList expectedList, int num)
        {
            ArrList actualList = List;
            actualList.AddFirst(num);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListToBeginningTestSource))]
        public void AddListToBeginningTest(ArrList list, ArrList actualList, ArrList expectedList)
        {
            actualList.AddListToBeginning(list);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddInIndexTestSource))]
        public void AddInIndexTest(ArrList List, ArrList expectedList, int index, int num)
        {
            ArrList actualList = List;
            actualList.AddInIndex(index,num);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListToIndexTestSource))]
        public void AddListToIndexTest(ArrList list, ArrList actualList, ArrList expectedList,int index)
        {
            actualList.AddListToIndex(list,index);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeletedEndTestSource))]
        public void DeletedEndTest(ArrList List, ArrList expectedList)
        {
            ArrList actualList = List;
            actualList.DeletedEnd();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeletedFirstTestSource))]
        public void DeletedFirstTest(ArrList List, ArrList expectedList)
        {
            ArrList actualList = List;
            actualList.DeletedFirst();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeletedAtIndexTestSource))]
        public void DeletedAtIndexTest(ArrList List, ArrList expectedList, int index)
        {
            ArrList actualList = List;
            actualList.DeletedAtIndex(index);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(RemovingNelementsFromTheEndTestSource))]
        public void RemovingNelementsFromTheEndTest(ArrList List, ArrList expectedList, int num)
        {
            ArrList actualList = List;
            actualList.RemovingNelementsFromTheEnd(num);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(RemovingNelementsFromTheHeadTestSource))]
        public void RemovingNelementsFromTheHeadTest(ArrList List, ArrList expectedList, int num)
        {
            ArrList actualList = List;
            actualList.RemovingNelementsFromTheHead(num);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeletingByIndexNelementsTestSource))]
        public void DeletingByIndexNelementsTest(ArrList List, ArrList expectedList,int index, int count)
        {
            ArrList actualList = List;
            actualList.DeletingByIndexNelements(index, count);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(FindIndexByFirstElementTestSource))]
        public void FindIndexByFirstElementTest(ArrList List, int expectedIndex, int value)
        {
            int actual =  List.FindIndexByFirstElement(value);
            Assert.AreEqual(expectedIndex, actual);
        }

        [TestCaseSource(typeof(ChangeValueByIndexTestSource))]
        public void ChangeValueByIndexTest(ArrList List, ArrList expectedList, int index, int value)
        {
            ArrList actualList = List;
            actualList.ChangeValueByIndex(index, value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ReversArrayTestSource))]
        public void ReversArrayTest(ArrList List, ArrList expectedList)
        {
            ArrList actualList = List;
            actualList.ReversArray();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(FindMaxValueTestSource))]
        public void FindMaxValueTest(ArrList List, int expectedValue)
        {
            int actual = List.FindMaxValue();
            Assert.AreEqual(expectedValue, actual);
        }

        [TestCaseSource(typeof(FindMinValueTestSource))]
        public void FindMinValueTest(ArrList List, int expectedValue)
        {
            int actual = List.FindMinValue();
            Assert.AreEqual(expectedValue, actual);
        }

        [TestCaseSource(typeof(FindIndexOfMaxValueTestSource))]
        public void FindIndexOfMaxValueTest(ArrList List, int expectedIndex)
        {
            int actual = List.FindIndexOfMaxValue();
            Assert.AreEqual(expectedIndex, actual);
        }

        [TestCaseSource(typeof(FindIndexOfMinValueTestSource))]
        public void FindIndexOfMinValueTest(ArrList List, int expectedIndex)
        {
            int actual = List.FindIndexOfMinValue();
            Assert.AreEqual(expectedIndex, actual);
        }

        [TestCaseSource(typeof(SortOrderArrayTestSource))]
        public void SortOrderArrayTest(ArrList List, ArrList expectedList)
        {
            ArrList actualList = List;
            actualList.SortOrderArray();
            Assert.AreEqual(expectedList, actualList);
        }
        [TestCaseSource(typeof(SortLessArrayTestSource))]
        public void SortLessArrayTest(ArrList List, ArrList expectedList)
        {
            ArrList actualList = List;
            actualList.SortLessArray();
            Assert.AreEqual(expectedList, actualList);
        }
            
        [TestCaseSource(typeof(DeleteFirstFoundTestSource))]
        public void DeleteFirstFoundTest(ArrList List, ArrList expectedList, int value, int expectedIndex)
        {
            int actualIndex = List.DeleteFirstFound(value);
            Assert.AreEqual(expectedIndex, actualIndex);
            Assert.AreEqual(expectedList, List);
        }

        [TestCaseSource(typeof(DeleteOllFoundTestSource))]
        public void DeleteOllFoundTest(ArrList List, ArrList expectedList, int value, int expectedCount)
        {
            int actualCount = List.DeleteOllFound(value);
            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedList, List);
        }

    }



}