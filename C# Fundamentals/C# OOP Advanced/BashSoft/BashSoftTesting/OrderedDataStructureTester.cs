using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BashSoft.Contracts;
using BashSoft.DataStructures;
using System.Collections.Generic;

namespace BashSoftTesting
{
    [TestClass]
    public class OrderedDataStructureTester
    {
        private ISimpleOrderedBag<string> names;
        [TestInitialize]
        public void SetUp()
        {
            this.names = new SimpleSortedList<string>();
        }
        [TestMethod]
        public void TestEmptyCtor()
        {
            Assert.AreEqual(16, this.names.Capacity);
            Assert.AreEqual(0, this.names.Size);
        }
        [TestMethod]
        public void TestCtorWithInitialCapacity()
        {
            this.names = new SimpleSortedList<string>(20);
            Assert.AreEqual(20, this.names.Capacity);
            Assert.AreEqual(0, this.names.Size);
        }
        [TestMethod]
        public void TestCtorWithAllParams()
        {
            this.names = new SimpleSortedList<string>(StringComparer.OrdinalIgnoreCase,30);
            Assert.AreEqual(30, this.names.Capacity);
            Assert.AreEqual(0, this.names.Size);
        }
        [TestMethod]
        public void TestCtorWithInitialComparer()
        {
            this.names = new SimpleSortedList<string>(StringComparer.OrdinalIgnoreCase);
            Assert.AreEqual(16, this.names.Capacity);
            Assert.AreEqual(0, this.names.Size);
        }
        [TestMethod]
        public void TestAddIncrease()
        {
            this.names.Add("Nasko");
            Assert.AreEqual(1, this.names.Size);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAddNullThrowsException()
        {
            this.names.Add(null);
        }
        [TestMethod]
        public void TestAddUnsortedDataIsHeldSorted()
        {
            this.names.Add("Rosen");
            this.names.Add("Georgi");
            this.names.Add("Balkan");
            Assert.AreEqual("Balkan, Georgi, Rosen", string.Join(", ", this.names));
        }
        [TestMethod]
        public void TestAddingMoreThanInitialCapacity()
        {
            for (int i = 0; i < 17; i++)
            {
                this.names.Add("i");
            }
            Assert.AreNotEqual(16, this.names.Capacity);
            Assert.AreEqual(17, this.names.Size);
        }

        [TestMethod]
        public void TestAddingAllFromCollectionIncreasesSize()
        {
            var testList = new List<string>();
            testList.Add("chichati");
            testList.Add("Gosho");
            this.names.AddAll(testList);
            Assert.AreEqual(2, this.names.Size);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAddingAllFromNullThrowsException()
        {
            this.names.AddAll(null);
        }
        [TestMethod]
        public void TestAddAllKeepsSorted()
        {
            var testList = new List<string>();
            testList.Add("Rosen");
            testList.Add("Georgi");
            testList.Add("Balkan"); 
            this.names.AddAll(testList);
            Assert.AreEqual("Balkan, Georgi, Rosen", string.Join(", ", this.names));
        }
        [TestMethod]
        public void TestRemoveValidElementDecreasesSize()
        {
            this.names.Add("Rosen");
            this.names.Add("Georgi");
            this.names.Add("Balkan");
            this.names.Remove("Balkan");
            Assert.AreEqual(2, this.names.Size);
        }
        [TestMethod]
        public void TestRemoveValidElementRemovesSelectedOne()
        {
            this.names.Add("ivan");
            this.names.Add("nasko");
            this.names.Remove("ivan");
            //CollectionAssert.DoesNotContain((ICollection<T>)this.names, "ivan");
            var testList = new List<string>(this.names);
            CollectionAssert.DoesNotContain(testList, "ivan");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRemovingNullThrowsException()
        {
            this.names.Remove(null);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestJoinWithNull()
        {
            this.names.JoinWith(null);
        }
        [TestMethod]
        public void TestJoinWorksFine()
        {
            this.names.Add("ivan");
            this.names.Add("nasko");
            this.names.Add("borko");
            string actual = this.names.JoinWith(", ");
            string expected = string.Join(", ", this.names);
            Assert.AreEqual(expected, actual);
        }
    }
}
