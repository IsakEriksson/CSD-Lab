using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSD_Lab_IsakEriksson;

namespace Unit_Tests_CSD_Lab
{
    [TestClass]
    public class OrganizationSearcherTests
    {
        // Arrange.
        IDIndexer orgIndexer;
        InMemoryStorage<Organization> orgStorage;
        OrganizationSearcher searcher;

        [TestInitialize]
        public void Initialize()
        {
            // Create indexer.
            orgIndexer = new IDIndexer();

            // Create Person objects.
            Organization uu = new Organization(orgIndexer.GetId(), "Uppsala universitet", "S:T Olofsgatan 10B", "Uppsala", "0184710000", new DateTime(1477, 2, 27));
            Organization oj = new Organization(orgIndexer.GetId(), "Oscar Jacobson", "Vevgatan 1", "Borås", "+4633233300", new DateTime(1903, 1, 1));

            // Create storage.
            orgStorage = new InMemoryStorage<Organization>();

            // Store objects.
            orgStorage.Create(uu);
            orgStorage.Create(oj);

            // Create searcher.
            searcher = new OrganizationSearcher(orgStorage);
        }
        
        [TestMethod]
        public void FoundingDateSearch_IsCalledWithValidDate_ReturnsCorrectList()
        {
            // Act.
            List<Organization> results = searcher.FoundingDateSearch(new DateTime(1903, 1, 1));

            // Assert.
            Assert.AreEqual(results[0], oj);
        }
    }
}
