using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSD_Lab_IsakEriksson;

namespace Unit_Tests_CSD_Lab
{
    [TestClass]
    public class IDIndexerTests
    {
        // Arrange.
        IDIndexer indexer;

        [TestInitialize]
        public void Initialize()
        {
            indexer = new IDIndexer();
        }
        
        [TestMethod]
        public void GetId_IsCalledForTheFirstTime_Returns1()
        {
            // Act.
            int id = indexer.GetId();

            // Assert.
            Assert.AreEqual(1, id);
        }

        [TestMethod]
        public void GetId_IsCalledForTheSecondTime_ReturnsSomethingDifferent()
        {
            // Act.
            int id = indexer.GetId();
            int id2 = indexer.GetId();

            // Assert.
            Assert.AreNotEqual(id, id2);
        }
    }
}
