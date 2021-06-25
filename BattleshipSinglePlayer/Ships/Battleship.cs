namespace BattleshipSinglePlayer.Ships
{
    public class Battleship : Ship
    {
        public Battleship()
        {
            Name = "Battleship";
            Width = 4;
            StatusType = StatusType.Battleship;
        }
    }
}