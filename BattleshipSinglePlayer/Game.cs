using System;
using System.Collections.Generic;
using System.Linq;
using BattleshipSinglePlayer.Board;
using BattleshipSinglePlayer.Ships;

namespace BattleshipSinglePlayer
{
    public class Game
    {
        public readonly Player Player1 = new Player("Player 1");
        private static bool _gameOver = false;
        
        public void Play()
        {
            Console.WriteLine("Welcome to Battleship single player!\n");
            Player1.DisplayBoard();
            var input = GetShipFrom("What ship would you like to deploy?    Please enter any of the following; (Carrier, Cruiser, Battleship, Destroyer, Submarine)");
            Player1.DeployShip(ShipToDeploy(input));
            Player1.DisplayBoard();
            
            while (!_gameOver)
            {
                Player1.Attack();
                Player1.DisplayBoard();
                IsShipDestroyed(Player1.Board.Squares); //Checks if the ship is destroyed
            }

            Console.WriteLine("All your ships have been sunk, you have lost");
        }

        private string GetShipFrom(string message)
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
            switch (input)
            {
                case "DESTROYER":
                    return new Destroyer();
                case "CARRIER":
                    return new Carrier();
                case "CRUISER":
                    return new Cruiser();
                case "BATTLESHIP":
                    return new Battleship();
                case "SUBMARINE":
                    return new Submarine();
                default:
                    return new Ship();
            }
        }
        
        private static void IsShipDestroyed(List<Square> squares)
        {
            var board = squares.Where(s => s.StatusType == StatusType.Empty
                                           || s.StatusType == StatusType.Miss
                                           || s.StatusType == StatusType.Hit).ToList();
            
            var lose = board.Count == 100;
            
            if (lose)
            {
                _gameOver = true;
            }
        }

    }
}