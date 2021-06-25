using System;
using System.Collections.Generic;
using System.Linq;
using BattleshipSinglePlayer.Ships;

namespace BattleshipSinglePlayer
{
    public class Game
    {
        public Player Player1 = new Player("Player 1");
        public static bool GameOver = false;
        public void Play()
        {
            Player1.DisplayBoard();
            var input = GetShipFrom("What ship would you like to deploy");
            Player1.DeployShip(ShipToDeploy(input));
            Player1.DisplayBoard();
            
            while (!GameOver)
            {
                Player1.Attack();
                Player1.DisplayBoard();
                Lose(Board.Squares);
            }

        }

        public string GetShipFrom(string message)
        {
            var success = false;
            var input = string.Empty;

            while (!success)
            {
                Console.WriteLine(message);
                input = Console.ReadLine().ToUpper();
                success = input is "DESTROYER" or "CARRIER" or "CRUISER" or "BATTLESHIP" or "SUBMARINE";

                if (!success)
                {
                    Console.WriteLine("There is no such ship. Please enter a valid ship");
                }
            }

            return input;
        }
        public Ship ShipToDeploy(string input)
        {
            if (input == "DESTROYER")
            {
                return new Destroyer();
            } 
            else if (input == "CARRIER")
            {
                return new Carrier();
            } else if (input == "CRUISER")
            {
                return new Cruiser();
            }
            else if (input == "BATTLESHIP")
            {
                return new Battleship();
            }
            else if (input == "SUBMARINE")
            {
                return new Submarine();
            }
            else
            {
                return new Ship();
            }
        }
        
        private static bool Lose(List<Square> squares)
        {
            var board = squares.Where(s => s.StatusType == StatusType.Empty
                                           || s.StatusType == StatusType.Miss
                                           || s.StatusType == StatusType.Hit).ToList();
            
            var lose = board.Count == 100;
            
            if (lose)
            {
                GameOver = true;
            }

            return lose;
        }
        

    }
}