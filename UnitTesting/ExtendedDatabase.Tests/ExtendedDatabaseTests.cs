namespace DatabaseExtended.Tests
{
    using NUnit.Framework;
    using System.Linq;
    using System;
    using ExtendedDatabase;
    public class ExtendeddatabaseTests
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
                database.Add(new Person(i,$"Username{i}"));
            }

            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(16, "Invalidusername")));
        }
        [Test]
        public void Add_ThrowException_WhenUserNameIsUsed()
        {
            string username = "Gosho";
            this.database.Add(new Person(1, username));

            Assert.Throws<InvalidOperationException>(() => this.database.Add(new Person(2, username)));
        }

        [Test]
        public void Add_ThrowException_WhenUserIdIsUsed()
        {
            long id = 1;

            this.database.Add(new Person(id, "User"));

            Assert.Throws<InvalidOperationException>(() => this.database.Add(new Person(id, "NextUser")));

        }

        [Test]
        public void Add_IncreaseCount_WhenIsValid()
        {
            Person person = new Person(1, "Gosho");
            this.database.Add(person);
            int expectedCount = 1;
            Assert.That(this.database.Count, Is.EqualTo(expectedCount));
        }

        [Test]
        public void Remove_ThrowException_WhenDatabaseIsEmpty()
        {
            Assert.Throws<InvalidOperationException>(() => this.database.Remove());
        }

        [Test]
        public void Remove_RemovesPersonFromDatabase_WhenValid()
        {
            this.database.Add(new Person(1, "Gosho"));
            this.database.Add(new Person(2, "Kiro"));

            this.database.Remove();
            Assert.That(this.database.Count, Is.EqualTo(1));
            Assert.Throws<InvalidOperationException>(() => this.database.FindById(2));
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void FindByUserName_ThrowsException_WhenNotValidUsername(string username)
        {
            Assert.Throws<ArgumentNullException>(()=>this.database.FindByUsername( username));
        }

        [Test]
        [TestCase("username")]
        public void FindByUserName_ThrowsException_WhenUserNameDoesNotExist(string username)
        {
            this.database.Add(new Person(1, "Gosho"));

            Assert.Throws<InvalidOperationException>(() => this.database.FindByUsername(username));
        }

        [Test]
        public void FindByUserName_ReturnExpectedUser_WhenUserExist()
        {
            Person person = new Person(1, "Gosho");
            this.database.Add(person);
            Person dbPerson = this.database.FindByUsername(person.UserName);
            Assert.That(person.UserName, Is.EqualTo(dbPerson.UserName));
        }

        [Test]
        [TestCase(-1)]
        public void FindById_ThrowsException_WhenIdIsLessThatZero(long id)
        {
            Assert.Throws<ArgumentOutOfRangeException>(()=>this.database.FindById(id));
        }

        [Test]
        public void FindById_ThrowException_WhenUserIdDoesNotExist()
        {
            this.database.Add(new Person(1, "Gosho"));

            Assert.Throws<InvalidOperationException>(() => this.database.FindById(2));
        }

        [Test]
        public void FindById_ReturnsExpectedUserId_WhenUserExist()
        {
            Person person = new Person(1, "Gosho");
            this.database.Add(person);
            Person dpPerson = database.FindById(person.Id);
            Assert.That(person, Is.EqualTo(dpPerson));
        }
        [Test]
        public void Ctor_ThrowException_WhenCapacityExceed()
        {
            Person[] people = new Person[17];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(i, $"Username{i}");
            }

            Assert.Throws<ArgumentException>(() => this.database = new Database(people));
        }

        [Test]
        public void Ctor_AddPersonsToDatabase()
        {
            Person[] people = new Person[6];

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(i, $"Username{i}");
            }

            this.database = new Database(people);
            Assert.That(this.database.Count, Is.EqualTo(people.Length));

            foreach (var person in people)
            {
                Person dpPerson = this.database.FindById(person.Id);
                Assert.That(person, Is.EqualTo(dpPerson));
            }
        }

    }
    
}