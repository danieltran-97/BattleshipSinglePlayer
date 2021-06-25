namespace BattleshipSinglePlayer.Ships
{
    public class Carrier : Ship
    {
        public Carrier()
        {
            Name = "Carrier";
            Width = 5;
            StatusType = StatusType.Carrier;
        }
    }
}