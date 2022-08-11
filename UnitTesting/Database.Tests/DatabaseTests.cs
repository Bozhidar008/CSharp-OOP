using NUnit.Framework;
using System.Linq;
using System;

namespace Database.Tests
{
    [TestFixture]
    public class DatabaseTests
    {
        private Database database;

        [SetUp]
        public void Setup()
        {
            this.database = new Database();
        }

        [Test]
        public void ThrowExceptionWhenCapacityExceeded()
        {
            for (int i = 0; i < 16; i++)
            {
                database.Add(i);
            }

            Assert.Throws<InvalidOperationException>(()=>database.Add(17));
        }
        [Test]
        public void Add_IncreaseDataCount_WhenAddIsValidOperation()
        {
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                this.database.Add(i);
            }
            Assert.That(this.database.Count, Is.EqualTo(n));
        }

        [Test]
        public void Add_AddElementToDatabse()
        {
            int element = 12;

            this.database.Add(element);

            int[] elements = this.database.Fetch();

            Assert.IsTrue(elements.Contains(element));
        }

        [Test]
        public void Remove_ThrowException_WhenDatabaseIsEmpty()
        {
            Assert.Throws<InvalidOperationException>(() => this.database.Remove());
        }

        [Test]
        public void Remove_DecreaseDatabaseCount()
        {
            this.database.Add(1);
            this.database.Add(2);
            this.database.Remove();

            int expectedCount = 1;
            Assert.That(() =>this.database.Count, Is.EqualTo(expectedCount));
        }

        [Test]
        public void Remove_LastElementFromDatabase()
        {
            int lastElement = 3;

            this.database.Add(1);
            this.database.Add(2);
            this.database.Add(lastElement);

            this.database.Remove();
            int[] elements = this.database.Fetch();
            Assert.IsFalse(elements.Contains(lastElement));

        }

        [Test]
        public void Fetch_ReturnDatabaseCopyInsteadOfReference()
        {
            this.database.Add(1);
            this.database.Add(2);
            int[] elementsFirst = this.database.Fetch();
            this.database.Add(3);
            int[] elementsSecond = this.database.Fetch();

            Assert.That(elementsFirst, Is.Not.EqualTo(elementsSecond));
        }

        [Test]
        public void Count_ReturnsZero_WhenDatabaseIsEmpty()
        {
            Assert.That(this.database.Count, Is.EqualTo(0));
        }

        [Test]
        public void Ctor_ThrowsException_WhenDatabasecapacityIsExceeded()
        {
            Assert.Throws<InvalidOperationException>(() => this.database = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17));
        }

        [Test]
        public void Ctor_AddElementToDatabase()
        {
            this.database.Add(123);
            int expectedCount = 1;
            Assert.That(this.database.Count, Is.EqualTo(expectedCount));
        }

        [Test]
        public void Ctor_AddsElementToDatabase()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            this.database = new Database(arr);

            Assert.That(this.database.Count, Is.EqualTo(arr.Length));
            Assert.That(this.database.Fetch(), Is.EquivalentTo(arr));
        }
    }
}