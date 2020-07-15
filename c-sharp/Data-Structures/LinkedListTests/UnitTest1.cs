using System;
using Xunit;
using LLLibrary;
using System.Net;
using System.Collections.Generic;

namespace LinkedListTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateEmptyLinkedList()
        {
            LinkedList list = new LinkedList();
            Assert.Null(list.Head);
        }

        [Fact]
        public void CanInsertIntoLinkedList()
        {
            // insert means add to the front
            //Arrange
            LinkedList list = new LinkedList();
            list.Insert(4);
            Assert.Equal(4, list.Head.Value);
        }

        [Fact]
        public void CanInsertMultipleNodesInLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            Assert.Equal(42, list.Head.Value);

        }

        [Fact]
        public void CanFindValueInList()
        {
            // arrange
            LinkedList list = new LinkedList();

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            // Act 
            int searchForValue = 15;
            bool exists = list.Includes(searchForValue);

            // Assert
            Assert.True(exists);

        }

        [Fact]
        public void CannotFindValueInLinkedList()
        {
            // arrange
            LinkedList list = new LinkedList();

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            // Act 
            int searchForValue = 100;
            bool exists = list.Includes(searchForValue);

            // Assert
            Assert.False(exists);

        }

        [Fact]
        public void CanReturnAllValuesInLinkedList()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            // Act
            string value = list.ToString();

            string expected = "42 -> 23 -> 16 -> 15 -> 8 -> 4 -> NULL";
            // Assert
            Assert.Equal(expected, value);

        }

        [Fact]
        public void CanAddNodeToEndOfLinkedList()
        {
            //Arrange
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);

            //Act
            list.Append(23);

            //Assert
            string expected = "16 -> 15 -> 8 -> 4 -> 23 -> NULL";
            string answer = list.ToString();

            Assert.Equal(expected, answer);
        }

        [Fact]
        public void CanAddMultipleNodesToAnEnd()
        {
            //Arrange
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(58);
            list.Append(10);
            list.Insert(12);
            list.Insert(254);
            list.Append(11);
            list.Append(88);


            string expected = "254 -> 12 -> 58 -> 4 -> 10 -> 11 -> 88->NULL";

            //Assert
            Assert.Equal(expected, list.ToString());
        }


        [Fact]
        public void CanInsertNodeBeforeMiddleOfLinkedList()
        {
            //Arrange
            LinkedList list = new LinkedList();

            //Act
            list.Insert(23);
            list.Insert(16);
            list.Insert(15);
            list.Insert(8);
            list.Insert(4);

            list.InsertBefore(15, 42);
            //Assert
            string expected = "4 -> 8 -> 42 -> 15 -> 16 -> 23 -> NULL";
            Assert.Equal(expected, ToString());
            
        }

        [Fact]
        public CanInsertNodeBeforefirstNode()
        {
            LinkedList list = new LinkedList();

            list.Insert(4);
            list.Insert(5);
            list.Insert(6);

            list.InsertBefore(6, 7);

            string expected = " 7 -> 6 -> 5 -> 4 -> NULL";

            Assert.Equal(expected, list.ToString());
        }

        public CaninsertNodeafterANode()
        {
            LinkedList list = new LinkedList();

            ll.Insert(4);
            ll.Insert(8);
            ll.Insert(15);
            ll.Insert(16);

        }
    }
}