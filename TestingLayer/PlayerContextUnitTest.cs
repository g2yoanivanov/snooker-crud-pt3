using NUnit.Framework;
using BusinessLayer;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;


namespace TestingLayer
{
    public class PlayerContextUnitTest
    {
        private SnookerCRUDDbContext dbContext;
        private PlayerContext playerContext;
        private CountryContext countryContext;
        DbContextOptionsBuilder builder;

        [SetUp]
        public void Setup()
        {
            builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());

            dbContext = new SnookerCRUDDbContext(builder.Options);
            playerContext = new PlayerContext(dbContext);

        }

        [Test]
        public void TestCreatePlayer()
        {
            int playersBefore = playerContext.ReadAll().Count();

            Country country = countryContext.Read(1);
            
            playerContext.Create(new Player("Victor", "Ivanov", 18, country, 127, 1));

            int playersAfter = playerContext.ReadAll().Count();

            Assert.IsTrue(playersBefore != playersAfter);
        }

        [Test]
        public void TestReadPlayer()
        {
            Country country = countryContext.Read(1);
            playerContext.Create(new Player("Yoan", "Ivanov", 17, country, 0, 0));

            Player player = playerContext.Read(1);

            Assert.That(player != null, "There is no record with id 1");
        }

        [Test]
        public void TestUpdatePlayer()
        {
            Country country = countryContext.Read(1);
            playerContext.Create(new Player("Yoan", "Ivanov", 17, country, 0, 0));

            Player player = playerContext.Read(1);

            player.Age = 18;
            player.MatchesPlayed = 1;

            playerContext.Update(player);
            Player player1 = playerContext.Read(1);

            Assert.IsTrue(player1.Age == 18 && player1.MatchesPlayed == 1, "Player Update() does not change the age and the played matches");
        }

        [Test]
        public void TestDeletePlayer()
        {
            Country country = countryContext.Read(1);
            playerContext.Create(new Player("Iztrit", "Iztritko", 21, country, 0, 0));

            int playersBeforeDelete = playerContext.ReadAll().Count();

            playerContext.Delete(1);

            int playersAfterDelete = playerContext.ReadAll().Count();

            Assert.AreNotEqual(playersBeforeDelete, playersAfterDelete);
        }
    }
}
