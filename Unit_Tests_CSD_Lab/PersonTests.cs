using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSD_Lab_IsakEriksson;

namespace Unit_Tests_CSD_Lab
{
    /// <summary>
    /// PersonTests tests the very basic functionalities of a Person object.
    /// </summary>
    [TestClass]
    public class PersonTests
    {
        // Arrange.
        Person person;
        Person.PersonFactory pFactory;

        [TestInitialize]
        public void Initialize()
        {
            pFactory = new Person.PersonFactory();
            person = pFactory.CreatePerson("Isak", "Eriksson", "123", new DateTime(1993, 8, 31));
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
