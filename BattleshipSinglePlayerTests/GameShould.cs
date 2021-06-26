using System;
using System.Collections.Generic;
using BattleshipSinglePlayer;
using BattleshipSinglePlayer.Boards;
using BattleshipSinglePlayer.Ships;
using Xunit;

namespace BattleshipSinglePlayerTests
{
    public class GameShould
    {
        // [Fact]
        // public void TestGetCarrier()
        // {
        //     var game = new Game();
        //     var shipToDeploy = game.ShipToDeploy("CARRIER");
        //     Assert.Equal(new Carrier(), shipToDeploy);
        //
        // }
        // [Fact]
        // public void TestGetCruiser()
        // {
        //     var game = new Game();
        //     var shipToDeploy = game.ShipToDeploy("cruiser");
        //     Assert.Equal(new Cruiser(), shipToDeploy);
        //
        // }
        // [Fact]
        // public void TestGetDestroyer()
        // {
        //     var game = new Game();
        //     var shipToDeploy = game.ShipToDeploy("destroyer");
        //     Assert.Equal(new Destroyer(), shipToDeploy);
        //
        // }
        // [Fact]
        // public void TestGetBattleship()
        // {
        //     var game = new Game();
        //     var shipToDeploy = game.ShipToDeploy("battleship");
        //     Assert.Equal(new Battleship(), shipToDeploy);
        //
        // }
        [Fact]
        public void TestGetSubmarine()
        {
            var game = new Game();
            var shipToDeploy = game.ShipToDeploy("SUBMARINE");
            Assert.Equal(new Submarine(), shipToDeploy);

        }
    }
}