using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using BattleshipSinglePlayer.Ships;

namespace BattleshipSinglePlayer
{
    public class Player
    {
        private string Name { get; set; }
        private Board _board = new Board();
        public List<Ship> Ships;

        public Player(string name)
        {
            Name = name;
            Ships = new List<Ship>() 
            {
                new Battleship(),
                new Carrier(), 
                new Cruiser(),
                new Destroyer(),
                new Submarine()
            };
        }

        public void DisplayBoard()
        {
            Console.WriteLine($"{Name}'s current board:");
            _board.PrintBoard(Board.Squares);
        }

        public void DeployShip(Ship ship)
        {
 
            bool open = true;

            while (open)
            {
                var input = GetOrientationFromConsole("Please enter 'V' (vertical) or 'H' (horizontal) to choose the orientation of your ship placement");
                var orientation = input == "V" ? 0 : 1; // 0 = horizontal
                var coord = GetCoordinatesFromConsole("Please enter coordinates of where you would like to place your ship");
                var rowStart = Array.IndexOf(Board.RowLetters,coord[0]);
                var columnStart = int.Parse(coord.Substring(1,coord.Length - 1)) - 1;
                int rowEnd = rowStart, columnEnd = columnStart;

                if (orientation == 0)
                {
                    for (var i = 1; i < ship.Width; i++)
                    {
                        rowEnd++;
                    }
                }
                else
                {
                    for (var i = 1; i < ship.Width; i++)
                    {
                        columnEnd++;
                    }
                }

                if (rowEnd > 10 || columnEnd > 10)
                {
                    open = true;
                    continue;
                }

                var affectedSquares = Board.Squares.Range(rowStart, columnStart, rowEnd, columnEnd);
                if (affectedSquares.Any(x => x.Occupied))
                {
                    open = true;
                    continue;
                }

                foreach (var square in affectedSquares)
                {
                    square.StatusType = ship.StatusType;
                }
                open = false;
            }
        }

        public void Attack()
        {
            var coord = GetCoordinatesFromConsole("Please enter coordinates of where you would like attack");
            var row = Array.IndexOf(Board.RowLetters,coord[0]);
            var column = int.Parse(coord.Substring(1,coord.Length - 1)) - 1;

            var target = Board.Squares.At(row, column);

            target.StatusType = target.StatusType == StatusType.Empty ? StatusType.Miss : StatusType.Hit;

            Console.WriteLine($"{(target.StatusType == StatusType.Miss ? "You missed!" : "Direct hit!")}");
        }

        public string GetOrientationFromConsole(string message)
        {
            var success = false;
            var input = string.Empty;

            while (!success)
            {
                Console.WriteLine(message);
                input = Console.ReadLine().ToUpper();
                success = input == "V" || input == "H";

                if (!success)
                {
                    Console.WriteLine("Input is invalid please try again");
                }
            }

            return input;
        }

        public string GetCoordinatesFromConsole(string message)
        {
            var success = false;
            var input = string.Empty;
            var reg = new Regex("^[A-J][0-9](?:[0])?");

            while (!success)
            {
                Console.WriteLine(message);
                input = Console.ReadLine().ToUpper();
                success = reg.IsMatch(input);

                if (!success)
                {
                    Console.WriteLine("Input is invalid please try again");
                }
            }

            return input;
        }
        
    }
}