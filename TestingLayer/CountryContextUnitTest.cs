using NUnit.Framework;
using BusinessLayer;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace TestingLayer
{
    public class CountryContextUnitTest
    {
        private CountryContext countryContext;
        private SnookerCRUDDbContext dbContext;
        DbContextOptionsBuilder builder;

        [SetUp]
        public void Setup()
        {
            builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());

            dbContext = new SnookerCRUDDbContext(builder.Options);
            countryContext = new CountryContext(dbContext);
        }

        [Test]
        public void TestCreateCountry()
        {
            int countriesBefore = countryContext.ReadAll().Count();

            countryContext.Create(new Country("Bulgaria"));

            int countriesAfter = countryContext.ReadAll().Count();

            Assert.IsTrue(countriesBefore != countriesAfter);
        }

        [Test]
        public void TestReadCountry()
        {
            countryContext.Create(new Country("Bulgaria"));

            Country country = countryContext.Read(1);

            Assert.That(country != null, "There is no record with id 1!");
        }

        [Test]
        public void TestUpdateCountry()
        {
            countryContext.Create(new Country("Bulgaria"));

            Country country = countryContext.Read(1);

            country.Name = "Germany";

            countryContext.Update(country);

            Country country1 = countryContext.Read(1);

            Assert.IsTrue(country1.Name == "Germany", "Country Update() does not change name!");
        }

        [Test]
        public void TestDeleteCountry()
        {
            countryContext.Create(new Country("Serbia"));

            int countriesBeforeDeletion = countryContext.ReadAll().Count();

            countryContext.Delete(1);

            int countriesAfterDeletion = countryContext.ReadAll().Count();

            Assert.AreNotEqual(countriesBeforeDeletion, countriesAfterDeletion);
        }
    }
}