using NUnit.Framework;
using BusinessLayer;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;


namespace TestingLayer
{
    public class TournamentContextUnitTest
    {
        private SnookerCRUDDbContext dbContext;
        private TournamentContext tournamentContext;

        DbContextOptionsBuilder builder;

        [SetUp]
        public void Setup()
        {
            builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());

            dbContext = new SnookerCRUDDbContext(builder.Options);
            tournamentContext = new TournamentContext(dbContext);
        }

        [Test]
        public void TestCreateTournament() 
        {
            int tournamentsBefore = tournamentContext.ReadAll().Count();

            tournamentContext.Create(new Tournament("European Masters Qualifiers 1", "Leicester, England", 100000));

            int tournamentsAfter = tournamentContext.ReadAll().Count();

            Assert.IsTrue(tournamentsBefore != tournamentsAfter);
        }

        [Test]
        public void TestReadTournament() 
        {
            tournamentContext.Create(new Tournament("European Masters", "Fuerth, Germany", 1000000));

            Tournament tournament = tournamentContext.Read(1);

            Assert.That(tournament != null, "There is no record with id 1");
        }

        [Test]
        public void TestUpdateTournament() 
        {
            tournamentContext.Create(new Tournament("European Masters", "Fuerth, Germany", 1000000));

            Tournament tournament = tournamentContext.Read(1);

            tournament.PrizePool = 2000000;

            tournamentContext.Update(tournament);

            Tournament tournament1 = tournamentContext.Read(1);

            Assert.IsTrue(tournament1.PrizePool == 2000000, "Tournament Update() does not change the prize pool");
        }

        [Test]
        public void TestDeleteTournament() 
        {
            tournamentContext.Create(new Tournament("Wrong tournament", "Sofia, Bulgaria", 5000));

            int tournamentsBeforeDelete = tournamentContext.ReadAll().Count();
            tournamentContext.Delete(1);
            int tournamentAfterDelete = tournamentContext.ReadAll().Count();

            Assert.AreNotEqual(tournamentsBeforeDelete, tournamentAfterDelete);
        }
    }
}
