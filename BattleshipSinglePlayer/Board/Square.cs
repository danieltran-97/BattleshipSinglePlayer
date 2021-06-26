namespace BattleshipSinglePlayer.Board
{
    public class Square
    {
        public StatusType StatusType { get; set; }
        public Coordinate Coordinate { get; }
        
        public bool IsOccupied =>
            StatusType is StatusType.Battleship or StatusType.Carrier or StatusType.Cruiser or StatusType.Destroyer or StatusType.Submarine;

        public bool RandomSlotAvailable =>
            (Coordinate.Row % 2 == 0 && Coordinate.Column % 2 == 0)
            || (Coordinate.Row % 2 == 1 && Coordinate.Column % 2 == 1);

        public char Status => (char) StatusType;

        public Square(int row, int column)
        {
            Coordinate = new Coordinate(row, column);
            StatusType = StatusType.Empty;
        }
    }
}