namespace BattleshipSinglePlayer.Ships
{
    public class Ship
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Hits { get; set; }
        public StatusType StatusType { get; set; }
        public bool Sunk => Hits >= Width;
    }
}