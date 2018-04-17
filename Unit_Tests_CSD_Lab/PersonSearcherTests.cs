﻿using System;
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
        InMemoryStorage<Person> personStorage;
        PersonSearcher searcher;

        [TestInitialize]
        public void Initialize()
        {
            // Create indexer.
            personIndexer = new IDIndexer();

            // Create Person objects.
            Person isak = new Person(personIndexer.GetId(), "Isak", "Eriksson", "123");
            Person juan = new Person(personIndexer.GetId(), "Juan Pablo", "Torres Padilla", "456");
            Person joan = new Person(personIndexer.GetId(), "Joan", "Jonathan", "789");
            Person omar = new Person(personIndexer.GetId(), "Omar", "Salah", "101112");

            // Create storage.
            personStorage = new InMemoryStorage<Person>();

            // Store objects.
            personStorage.Create(isak);
            personStorage.Create(juan);
            personStorage.Create(joan);
            personStorage.Create(omar);

            // Create searcher.
            searcher = new PersonSearcher(personStorage);
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
            results = searcher.NumberSearch("123");

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
            results = searcher.NumberSearch("1");

            // Assert.
            Assert.IsTrue(results.Count > 1);
        }

        [TestMethod]
        public void NumberSearch_IsCalledWithCommonNumber_ReturnsCorrectItems()
        {
            // Arrange.
            List<Person> results = new List<Person>();

            // Act.
            results = searcher.NumberSearch("1");

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
            results = searcher.NumberSearch("J");

            // Assert.
            Assert.IsTrue(results.Count == 0);
        }
    }
}