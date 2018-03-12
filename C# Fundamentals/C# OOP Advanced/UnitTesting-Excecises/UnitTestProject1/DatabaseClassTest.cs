using System;
using NUnit.Framework;
using Database;

namespace Database.Test
{
    [TestFixture]
    public class DatabaseClassTest
    {
        [Test]
        public void ConstructorTest()
        {
            Database data = new Database(10, 15, 20);
            CollectionAssert.AreEqual(new int[] { 10, 15, 20 }, data.Fletch());
        }
        [Test]
        public void AddMethodTest()
        {
            Database data = new Database(10, 15, 20);
            data.Add(30);
            CollectionAssert.AreEqual(new int[] { 10, 15, 20, 30 }, data.Fletch());
        }
        [Test]
        public void AddMethodThrowException()
        {
            Database data = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => data.Add(30));
            Assert.AreEqual("It is full", ex.Message);
        }
        [Test]
        public void RemoveMethodThrowException()
        {
            Database data = new Database();

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => data.Remove());
            Assert.AreEqual("It is empty", ex.Message);
        }
        [Test]
        public void RemoveMethodTest()
        {
            Database data = new Database(10, 15, 20);
            data.Remove();
            CollectionAssert.AreEqual(new int[] { 10, 15 }, data.Fletch());
        }
    }
}
