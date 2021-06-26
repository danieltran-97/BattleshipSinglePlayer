using System.Collections.Generic;
using System.Linq;

namespace BattleshipSinglePlayer.Board
{
    public static class SquareExtensions
    {   
        public static Square At(this List<Square> squares, int row, int column)
        {
            return squares.First(x => x.Coordinate.Row == row && x.Coordinate.Column == column);
        }
        public static List<Square> Range(this List<Square> squares, int rowStart, int columnStart, int rowEnd, int columnEnd)
        {
            return squares.Where(s => s.Coordinate.Row >= rowStart
                               && s.Coordinate.Column >= columnStart
                               && s.Coordinate.Row <= rowEnd
                               && s.Coordinate.Column <= columnEnd).ToList();
        }
    }
}