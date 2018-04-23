using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSD_Lab_IsakEriksson;

namespace Unit_Tests_CSD_Lab
{
    class EasyTypeToStore : ISearchable
    {
        private int id;
        public EasyTypeToStore(int id)
        {
            this.id = id;
        }
        public int GetId()
        {
            return this.id;
        }
    }

    [TestClass]
    public class InMemoryStorageTests
    {
        InMemoryStorage<EasyTypeToStore> storage;
        EasyTypeToStore a, b, c;

        [TestInitialize]
        public void Initialize()
        {
            // Arrange for all tests.
            storage = new InMemoryStorage<EasyTypeToStore>();
            
            a = new EasyTypeToStore(1);
            b = new EasyTypeToStore(2);
            c = new EasyTypeToStore(3);
            
            storage.Create(a);
            storage.Create(b);
            storage.Create(c);
        }

        [TestMethod]
        public void Create_IsCalledWithValidObject_StoresObject()
        {
            // Arrange.
            EasyTypeToStore d = new EasyTypeToStore(4);

            // Act.
            storage.Create(d);

            // Assert.
            Assert.AreEqual(storage.Read(4), d);
        }

        [TestMethod]
        public void Update_IsCalledWithValidObjects_StorageContainsNewObject()
        {
            // Arrange.
            EasyTypeToStore d = new EasyTypeToStore(4);

            // Act.
            storage.Update(3, d);

            // Assert.
            Assert.AreEqual(storage.Read(4), d);
        }

        [TestMethod]
        public void Update_IsCalledWithValidObjects_StorageNoLongerContainsOldObject()
        {
            // Arrange.
            EasyTypeToStore d = new EasyTypeToStore(4);

            // Act.
            storage.Update(3, d);

            // Assert.
            Assert.AreNotEqual(storage.Read(3), c);
        }

        [TestMethod]
        public void Delete_IsCalledWithValidObject_NoLongerContainsOldObject()
        {
            // Act.
            storage.Delete(3);

            // Assert.
            Assert.AreNotEqual(storage.Read(3), c);
        }

        [TestMethod]
        public void Delete_IsCalledWithInvalidObject_NothingIsDeleted()
        {
            // Arrange.
            int i = 1;

            // Act.
            storage.Delete(4);

            // Assert.
            foreach(EasyTypeToStore e in storage)
            {
                Assert.AreEqual(storage.Read(i), e);
                i++;
            }
        }
    }
}
