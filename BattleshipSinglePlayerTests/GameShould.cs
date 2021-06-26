using System;
using BattleshipSinglePlayer;
using BattleshipSinglePlayer.Ships;
using Xunit;

namespace BattleshipSinglePlayerTests
{
    public class GameShould
    {
        [Fact]
        public void TestGetCarrier()
        {
            var game = new Game();
            var shipToDeploy = game.ShipToDeploy("CARRIER");
            Assert.True(Object.ReferenceEquals(shipToDeploy.GetType(), (new Carrier()).GetType()));
        }
        
        [Fact]
        public void TestGetCruiser()
        {
            var game = new Game();
            var shipToDeploy = game.ShipToDeploy("CRUISER");
            Assert.True(Object.ReferenceEquals(shipToDeploy.GetType(), (new Cruiser()).GetType()));
        }
        [Fact]
        public void TestGetDestroyer()
        {
            var game = new Game();
            var shipToDeploy = game.ShipToDeploy("DESTROYER");
            Assert.True(Object.ReferenceEquals(shipToDeploy.GetType(), (new Destroyer()).GetType()));
        
        }
        [Fact]
        public void TestGetBattleship()
        {
            var game = new Game();
            var shipToDeploy = game.ShipToDeploy("BATTLESHIP");
            Assert.True(Object.ReferenceEquals(shipToDeploy.GetType(), (new Battleship()).GetType()));
        
        }
        [Fact]
        public void TestGetSubmarine()
        {
            var game = new Game();
            var shipToDeploy = game.ShipToDeploy("SUBMARINE");
            Assert.True(Object.ReferenceEquals(shipToDeploy.GetType(), (new Submarine()).GetType()));
        }
    }
}