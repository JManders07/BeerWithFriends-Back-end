using BeerWithFriendsBackend.Controllers;
using BeerWithFriendsBackend.Data;
using BeerWithFriendsBackend.Logic;
using BeerWithFriendsBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace BeerWithFriendsTests
{
    [TestClass]
    public class IntegrationTestBeer
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
        public void GetListOfBeersTest()
        {
            Assert.AreEqual(2, _logic.Beers().Count());
        }

        [TestMethod]
        public void Create2BeersTest()
        {
            var beer3 = new Beer
            {
                Name = "La chouffe",
                Description = "Erg lekker",
                AlcoholPercentage = 6
            };

            var beer4 = new Beer
            {
                Name = "Heineken",
                Description = "Lekker",
                AlcoholPercentage = 5
            };

            _logic.NewBeer(beer3);
            _logic.NewBeer(beer4);

            Assert.AreEqual(4, _logic.Beers().Count);
        }

        [TestMethod]
        public void TryCreate2Beers1Fail1SuccesTest()
        {
            var beer3 = new Beer
            {
                Name = "La chouffe",
                Description = "Erg lekker",
                AlcoholPercentage = -6
            };

            var beer4 = new Beer
            {
                Name = "Heineken",
                Description = "Lekker",
                AlcoholPercentage = 5
            };

            _logic.NewBeer(beer3);
            _logic.NewBeer(beer4);

            Assert.AreEqual(3, _logic.Beers().Count);
        }

    }
}