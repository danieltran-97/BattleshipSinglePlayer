using System;
using System.Collections.Generic;
using BattleshipSinglePlayer;
using BattleshipSinglePlayer.Boards;
using Xunit;

namespace BattleshipSinglePlayerTests
{
    public class GameShould
    {
        [Fact]
        public void IsShipDestroyedTest()
        {
            var game = new Game();
            
            game.IsShipDestroyed()
        }
    }
}