﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomL;

namespace CustomListTest
{
    [TestClass]
    public class CustomListTest
    {

        //Add Test 1: to check when something is added to an empty 
        //list, will it go to index 0.

        [TestMethod]
        public void Add_ToAnEmptyList_ItemShouldGoToIndexNumberZero()
        {
            // arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 13;
            int actual;
            int num1 = 13;

            // act
            customList.Add(num1);

            actual = customList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }


        //Add Test 2: to check when 7 values are added to customlist, 
        //will the count be 7

        [TestMethod]
        public void Add_ItemsToList_ReturnsCountOfList()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int num1 = 5;
            int num2 = 10;
            int num3 = 15;
            int num4 = 20;
            int num5 = 25;
            int num6 = 30;
            int num7 = 35;
            int expected = 7;
            int actual;

            //act
            customList.Add(num1);
            customList.Add(num2);
            customList.Add(num3);
            customList.Add(num4);
            customList.Add(num5);
            customList.Add(num6);
            customList.Add(num7);
            actual = customList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        //Add Test 3: to check the capacity even when the count is less 
        //than the capacity.

        [TestMethod]
        public void Add_ItemsToList_ReturnsCapacity()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 8;
            int actual;
            int num1 = 5;
            int num2 = 10;
            int num3 = 15;
            int num4 = 20;
            int num5 = 25;
            int num6 = 30;
            int num7 = 35;

            //act
            customList.Add(num1);
            customList.Add(num2);
            customList.Add(num3);
            customList.Add(num4);
            customList.Add(num5);
            customList.Add(num6);
            customList.Add(num7);

            actual = customList.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }

        //Add Test 4: check if new item is added to the end

            [TestMethod]
        public void Add_string_ReturnsNewerItemsAddedTotheEnd()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            string expected = "Pewaukee";
            string actual;
            string city1 = "Milwaukee";
            string city2 = "Waukesha";
            string city3 = "Brookfield";
            string city4 = "Pewaukee";

            //act

            customList.Add(city1);
            customList.Add(city2);
            customList.Add(city3);
            customList.Add(city4);


            actual = customList[3];

            //assert
            Assert.AreEqual(expected, actual);
        }

        //Add Test 5: to check when items are added to a full array , 
        //will the newer items be still added.

        [TestMethod]
        public void Add_ToFullArray_WillStillBeAdded()
        {
            // arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 35;
            int actual;
            int num1 = 5;
            int num2 = 10;
            int num3 = 15;
            int num4 = 20;
            int num5 = 25;
            int num6 = 30;
            int num7 = 35;

            // act
            customList.Add(num1);
            customList.Add(num2);
            customList.Add(num3);
            customList.Add(num4);
            customList.Add(num5);
            customList.Add(num6);
            customList.Add(num7);
            actual = customList[6];

            // assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Add_To1FullArray_WillStillBeAdded()
        {
            // arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 8;
            int actual;
            int num1 = 5;
            int num2 = 10;
            int num3 = 15;
            int num4 = 20;
            int num5 = 25;
            int num6 = 30;
            int num7 = 35;

            // act
            customList.Add(num1);
            customList.Add(num2);
            customList.Add(num3);
            customList.Add(num4);
            customList.Add(num5);
            customList.Add(num6);
            customList.Add(num7);
            actual = customList.Capacity;

            // assert
            Assert.AreEqual(expected, actual);
        }


        ////////**Remove Tests**/////////

        //Remove Test 1: to check when item is removed does the count decrement.
        [TestMethod]
        public void Remove_ItemsFromAList_ReturnNewCount()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int num1 = 5;
            int num2 = 10;
            int num3 = 15;
            int num4 = 20;
            int expected = 3;
            int actual;

            //act
            customList.Add(num1);
            customList.Add(num2);
            customList.Add(num3);
            customList.Add(num4);
            customList.Remove(num3);
            actual = customList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        //Remove Test 2: to check when first item is removed do items change postion in the list.
        [TestMethod]
        public void Remove_ItemsFromStartOfList_ReturnNewIndexItem()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            string city1 = "Waukesha";
            string city2 = "Brookfield";
            string city3 = "Milwaukee";
            string city4 = "Pewaukee";
            string expected = "Brookfield";
            string actual;

            //act
            customList.Add(city1);
            customList.Add(city2);
            customList.Add(city3);
            customList.Add(city4);
            customList.Remove(city1);
            actual = customList[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        //Remove Test 3: to check when item is removed from the middle of the list, do the items still change position.
        [TestMethod]
        public void Remove_ItemsFromMiddleOfList_ReturnItemAtIndex()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int num1 = 5;
            int num2 = 10;
            int num3 = 15;
            int num4 = 20;
            int num5 = 25;
            int num6 = 30;
            int expected = 25;
            int actual;

            //act
            customList.Add(num1);
            customList.Add(num2);
            customList.Add(num3);
            customList.Add(num4);
            customList.Add(num5);
            customList.Add(num6);
            customList.Remove(num2);
            customList.Remove(num3);
            actual = customList[2];

            //assert
            Assert.AreEqual(expected, actual);
        }

        //Remove Test 4: to check when item is removed from list, does the capacity change.
        [TestMethod]
        public void Remove_ItemsThatDoesNotExistInList_ReturnCount()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            string city1 = "Waukesha";
            string city2 = "Pewaukee";
            string city3 = "New Berlin";
            string city4 = "Brookfield";
            int expected = 4;
            int actual;

            //act
            customList.Add(city1);
            customList.Add(city2);
            customList.Add(city3);
            customList.Add(city4);
            customList.Remove(city4);
            actual = customList.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }

        //Remove Test 5: to check when some item that does not exist in the list is removed does the count decrement
        [TestMethod]
        public void Remove_ItemNotExistingInList_ReturnIndex()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int num1 = 5;
            int num2 = 10;
            int num3 = 15;
            int num4 = 20;
            int num5 = 25;
            int expected = 4;
            int actual;

            //act
            customList.Add(num1);
            customList.Add(num2);
            customList.Add(num3);
            customList.Add(num4);
            customList.Remove(num5);
            actual = customList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        //Remove Test 6: to check when some item exists multiple times in the list is removed, is the first occurance of it in 
        //the list removed.

        [TestMethod]
        public void Remove_ItemFromTheList_ReturnItemAtIndex()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            string city1 = "Waukesha";
            string city2 = "Milwaukee";
            string city3 = "Brookfield";
            string expected = "Milwaukee";
            string actual;

            //act
            customList.Add(city1);
            customList.Add(city2);
            customList.Add(city1);
            customList.Add(city3);
            customList.Remove(city1);
            actual = customList[0];

            //assert
            Assert.AreEqual(expected, actual);
        }


        /////**String**/////

        // public void a_b
        //CustomList
    }
}

