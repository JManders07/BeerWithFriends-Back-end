using BeerWithFriendsBackend.Data;
using BeerWithFriendsBackend.Logic;
using BeerWithFriendsBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerWithFriendsTests
{
    [TestClass]
    public class UnitTestBeer
    {
        private BeerWithFriendsBackendContext _context;
        private BeerLogic _logic;

        [TestInitialize]
        public void Setup()
        {
            var dbContextOptions =
                new DbContextOptionsBuilder<BeerWithFriendsBackendContext>().UseInMemoryDatabase("TestDb");
            _context = new BeerWithFriendsBackendContext(dbContextOptions.Options);
            _context.Database.EnsureCreated();

            var beerData = new BeerData(_context);

            _logic = new BeerLogic(beerData);

            var beer1 = new Beer
            {
                Name = "La chouffe",
                Description = "Erg lekker",
                AlcoholPercentage = 6
            };

            var beer2 = new Beer
            {
                Name = "Heineken",
                Description = "Lekker",
                AlcoholPercentage = 5
            };

            _logic.NewBeer(beer1);
            _logic.NewBeer(beer2);
        }

        [TestCleanup]
        public void TearDown()
        {
            _context.Database.EnsureDeleted();
        }

        [TestMethod]
        public void TryCreate1BeerTest()
        {
            var beer3 = new Beer
            {
                Name = "La chouffe",
                Description = "Erg lekker",
                AlcoholPercentage = 6
            };


            var text = _logic.NewBeer(beer3);

            Assert.AreEqual("Succes", text);
        }
    }
}
