﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSD_Lab_IsakEriksson;

namespace Unit_Tests_CSD_Lab
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class PersonTests
    {
        // Arrange.
        IDIndexer indexer = new IDIndexer();
        Person person;

        [TestInitialize]
        public void Initialize()
        {
            person = new Person(indexer.GetId(), "Isak", "Eriksson", "123");
        }

        [TestMethod]
        public void GetId_IsCalledOnValidObject_ReturnsId()
        {
            // Act.
            int id = person.GetId();

            // Assert.
            Assert.AreEqual(1, id);
        }

        [TestMethod]
        public void GetFirstName_IsCalledOnValidObject_ReturnsFirstName()
        {
            // Act.
            string firstName = person.GetFirstName();

            // Assert.
            Assert.AreEqual("Isak", firstName);
        }

        [TestMethod]
        public void GetLastName_IsCalledOnValidObject_ReturnsLastName()
        {
            // Act.
            string lastName = person.GetLastName();

            // Assert.
            Assert.AreEqual("Eriksson", lastName);
        }

        [TestMethod]
        public void GetPhoneNumber_IsCalledOnValidObject_ReturnsPhoneNumber()
        {
            // Act.
            string phoneNumber = person.GetPhoneNumber();

            // Assert.
            Assert.AreEqual("123", phoneNumber);
        }
    }
}