using System;

namespace TicTacToeGameProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe game");
            TicTacToeGame game = new TicTacToeGame();
            game.CreateBoard();
        }
    }
}
