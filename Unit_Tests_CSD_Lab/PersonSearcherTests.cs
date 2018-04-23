using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSD_Lab_IsakEriksson;


namespace Unit_Tests_CSD_Lab
{
    [TestClass]
    public class PersonSearcherTests
    {
        // Arrange.
        IDIndexer personIndexer;
        InMemoryStorage<Person> pStorage;
        PersonSearcher searcher;

        [TestInitialize]
        public void Initialize()
        {
            // Create indexer.
            personIndexer = new IDIndexer();

            // Create Person objects.
            Person isak = new Person(personIndexer.GetId(), "Isak", "Eriksson", "123", new DateTime(1993, 08, 31));
            Person juan = new Person(personIndexer.GetId(), "Juan Pablo", "Torres Padilla", "456", new DateTime(1992, 09, 22));
            Person joan = new Person(personIndexer.GetId(), "Joan", "Jonathan", "789", new DateTime(1990, 4, 4));
            Person omar = new Person(personIndexer.GetId(), "Omar", "Salah", "101112", new DateTime(1994, 2, 1));

            // Create storage.
            pStorage = new InMemoryStorage<Person>();

            // Store objects.
            pStorage.Create(isak);
            pStorage.Create(juan);
            pStorage.Create(joan);
            pStorage.Create(omar);

            // Create searcher.
            searcher = new PersonSearcher(pStorage);
        }

        [TestMethod]
        public void FirstNameSearch_IsCalledWithRegisteredFirstName_ReturnsCorrectItems()
        {
            // Arrange.
            List<Person> results = new List<Person>();

            // Act.
            results = searcher.FirstNameSearch("Isak");

            // Assert.
            foreach(Person p in results)
            {
                Assert.IsTrue(p.GetFirstName().Contains("Isak"));
            }
        }

        [TestMethod]
        public void FirstNameSearch_IsCalledWithCommonLetter_ReturnsListOfMultipleObjects()
        {
            // Arrange.
            List<Person> results = new List<Person>();

            // Act.
            results = searcher.FirstNameSearch("J");

            // Assert.
            Assert.IsTrue(results.Count > 1);
        }

        [TestMethod]
        public void FirstNameSearch_IsCalledWithCommonLetter_ReturnsCorrectItems()
        {
            // Arrange.
            List<Person> results = new List<Person>();

            // Act.
            results = searcher.FirstNameSearch("J");

            // Assert.
            foreach (Person p in results)
            {
                Assert.IsTrue(p.GetFirstName().Contains("J"));
            }
        }

        [TestMethod]
        public void LastNameSearch_IsCalledWithRegisteredLastName_ReturnsCorrectItems()
        {
            // Arrange.
            List<Person> results = new List<Person>();

            // Act.
            results = searcher.LastNameSearch("Eriksson");

            // Assert.
            foreach (Person p in results)
            {
                Assert.IsTrue(p.GetLastName().Contains("Eriksson"));
            }
        }

        [TestMethod]
        public void LastNameSearch_IsCalledWithCommonLetter_ReturnsListOfMultipleObjects()
        {
            // Arrange.
            List<Person> results = new List<Person>();

            // Act.
            results = searcher.FirstNameSearch("o");

            // Assert.
            Assert.IsTrue(results.Count > 1);
        }

        [TestMethod]
        public void LastNameSearch_IsCalledWithCommonLetter_ReturnsCorrectItems()
        {
            // Arrange.
            List<Person> results = new List<Person>();

            // Act.
            results = searcher.LastNameSearch("o");

            // Assert.
            foreach (Person p in results)
            {
                Assert.IsTrue(p.GetLastName().Contains("o"));
            }
        }

        [TestMethod]
        public void NumberSearch_IsCalledWithRegisteredPhoneNumber_ReturnsCorrectItems()
        {
            // Arrange.
            List<Person> results = new List<Person>();

            // Act.
            results = searcher.PhoneNumberSearch("123");

            // Assert.
            foreach (Person p in results)
            {
                Assert.IsTrue(p.GetPhoneNumber().Contains("123"));
            }
        }

        [TestMethod]
        public void NumberSearch_IsCalledWithCommonNumber_ReturnsListOfMultipleObjects()
        {
            // Arrange.
            List<Person> results = new List<Person>();

            // Act.
            results = searcher.PhoneNumberSearch("1");

            // Assert.
            Assert.IsTrue(results.Count > 1);
        }

        [TestMethod]
        public void NumberSearch_IsCalledWithCommonNumber_ReturnsCorrectItems()
        {
            // Arrange.
            List<Person> results = new List<Person>();

            // Act.
            results = searcher.PhoneNumberSearch("1");

            // Assert.
            foreach (Person p in results)
            {
                Assert.IsTrue(p.GetPhoneNumber().Contains("1"));
            }
        }

        [TestMethod]
        public void NumberSearch_IsCalledWithLetter_ReturnsEmptyList()
        {
            // Arrange.
            List<Person> results = new List<Person>();

            // Act.
            results = searcher.PhoneNumberSearch("J");

            // Assert.
            Assert.IsTrue(results.Count == 0);
        }

        [TestMethod]
        public void BirthDateSearch_IsCalledWithRegisteredBirthDate_ReturnsCorrectItems()
        {
            // Arrange.
            List<Person> results = new List<Person>();
            DateTime searchDate = new DateTime(1993, 8, 31);

            // Act.
            results = searcher.BirthDateSearch(searchDate);

            // Assert.
            foreach(Person p in results)
            {
                Assert.IsTrue(p.GetBirthDate() == searchDate);
            }
        }

        [TestMethod]
        public void BirthDateSearch_IsCalledWithUnregisteredBirthDate_ReturnsEmptyList()
        {
            // Arrange.
            List<Person> results = new List<Person>();
            DateTime searchDate = new DateTime(1993, 8, 30);

            // Act.
            results = searcher.BirthDateSearch(searchDate);

            // Assert.
            Assert.IsTrue(results.Count == 0);
        }
    }
}