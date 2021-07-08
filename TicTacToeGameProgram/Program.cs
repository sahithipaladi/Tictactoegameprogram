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
            char userLetter = game.ChooseLetter();
            char computerLetter;
            if (userLetter == 'X' || userLetter == 'x')
                computerLetter = 'O';
            else
                computerLetter = 'X';
            Console.WriteLine("User Letter : " + userLetter + "\t Computer Letter : " + computerLetter);

            game.DisplayBoard();
            game.MakeMove(userLetter, game.board);
            game.DisplayBoard();
        }
    }
    }



