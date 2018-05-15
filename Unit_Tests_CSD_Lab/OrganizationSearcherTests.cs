using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSD_Lab_IsakEriksson;

namespace Unit_Tests_CSD_Lab
{
    [TestClass]
    public class OrganizationSearcherTests
    {
        // Arrange.
        InMemoryStorage<Organization> orgStorage;
        OrganizationSearcher searcher;
        Organization.OrganizationFactory orgFactory;

        [TestInitialize]
        public void Initialize()
        {
            // Create Factory.
            orgFactory = new Organization.OrganizationFactory();

            // Create Organization objects.
            Organization uu = orgFactory.CreateOrganization("Uppsala universitet", "S:T Olofsgatan 10B", "Uppsala", "0184710000", new DateTime(1477, 2, 27));
            Organization oj = orgFactory.CreateOrganization("Oscar Jacobson", "Vevgatan 1", "Borås", "+4633233300", new DateTime(1903, 1, 1));

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
            // Arrange.
            Organization oj = orgFactory.CreateOrganization("Oscar Jacobson", "Vevgatan 1", "Borås", "+4633233300", new DateTime(1903, 1, 1));

            // Act.
            List<Organization> results = searcher.FoundingDateSearch(new DateTime(1903, 1, 1));

            // Assert.
            Assert.AreEqual(results[0].GetFoundingDate(), oj.GetFoundingDate());
        }
    }
}
