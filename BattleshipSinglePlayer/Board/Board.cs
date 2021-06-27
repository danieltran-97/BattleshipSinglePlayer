using System;
using System.Collections.Generic;

namespace BattleshipSinglePlayer
{
    public class Board
    {
        public List<Square> Squares { get; }

        public static readonly char[] RowLetters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J'};

        public  Board()
        {
            Squares = new List<Square>();
            
            for (var i = 0; i < 10; i++)
            {
                for (var j = 0; j < 10; j++)
                {
                    Squares.Add(new Square(i,j));
                }
            }
        }

        public void PrintBoard(List<Square> boardSlots)
        {
            var columnNumber = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"};

            Console.Write("   ");
            
            foreach (var number in columnNumber)
            {
                Console.Write("{0} ", number);
            }
            
            Console.WriteLine("\n   ___________________");
            
            for (var i = 0; i < 10; i++)
            {
                Console.Write("{0} |", RowLetters[i]);
                for (var j = 0; j < 10; j++)
                {
                    Console.Write("{0} ", boardSlots.At(i, j).Status);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
    }
}