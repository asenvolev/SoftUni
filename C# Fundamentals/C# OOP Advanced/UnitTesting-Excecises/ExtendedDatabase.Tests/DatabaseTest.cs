using System;
using NUnit.Framework;

namespace ExtendedDatabase.Tests
{
    [TestFixture]
    public class DatabaseTest
    {
        [Test]
        public void ConstructorTest()
        {
            Database data = new Database(new Person(1,"chichaTiPesho"), new Person(2,"bratTiStamat"));
            Person actual = data.FindById(2);
            Assert.AreEqual("bratTiStamat", actual.Username);
        }
        [Test]
        public void AddPersonToDatabase()
        {
            Database data = new Database(new Person(1, "chichaTiPesho"));
            data.Add(new Person(2, "bratTiStamat"));
            Person actual = data.FindById(2);
            Assert.AreEqual("bratTiStamat", actual.Username);
        }

    }
}
