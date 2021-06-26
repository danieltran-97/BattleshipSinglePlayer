using System;
using System.Collections.Generic;
using System.Linq;
using BattleshipSinglePlayer.Boards;
using BattleshipSinglePlayer.Ships;

namespace BattleshipSinglePlayer
{
    public class Game
    {
        private readonly Player _player1 = new Player("Player 1");
        private static bool _gameOver = false;
        public void Play()
        {
            Console.WriteLine("Welcome to Battleship single player!\n");
            _player1.DisplayBoard();
            var input = GetShipFrom("What ship would you like to deploy");
            _player1.DeployShip(ShipToDeploy(input));
            _player1.DisplayBoard();
            
            while (!_gameOver)
            {
                _player1.Attack();
                _player1.DisplayBoard();
                IsShipDestroyed(_player1.Board.Squares); //Checks if the ship is destroyed
            }

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

        private Ship ShipToDeploy(string input)
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
        
        private static bool IsShipDestroyed(List<Square> squares)
        {
            var board = squares.Where(s => s.StatusType == StatusType.Empty
                                           || s.StatusType == StatusType.Miss
                                           || s.StatusType == StatusType.Hit).ToList();
            
            var lose = board.Count == 100;
            
            if (lose)
            {
                _gameOver = true;
            }

            return lose;
        }
        

    }
}