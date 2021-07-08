using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGameProgram
{
    class TicTacToeGame
    {
        
                   

        public char[] board;
        public char[] CreateBoard()
        {
            board = new char[10];
            for (int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;

        }
    }
}
