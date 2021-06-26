using BattleshipSinglePlayer.Board;
using Xunit;

namespace BattleshipSinglePlayerTests
{
    public class BoardShould
    {
        [Fact]
        public void TestNewBoard()
        {
            Assert.NotNull(new Board());
        }
        
        [Fact]
        public void TestBoardSize()
        {
            var board = new Board();
            Assert.Equal(100, board.Squares.Count);
        }
    }
}