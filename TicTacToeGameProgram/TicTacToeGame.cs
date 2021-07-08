﻿using System;
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
        public char ChooseLetter()
        {
            while (true)
            {
                Console.Write("Choose a Letter among 'X' or 'O' : ");
                char letter = Convert.ToChar(Console.ReadLine());
                if (letter == 'X' || letter == 'O' || letter == 'x' || letter == 'o')
                {
                    return letter;
                }
                else
                {
                    Console.WriteLine(" Try Again - Invalid Input");
                }
            }
        }
            public void DisplayBoard()
             { 

                
                    

                    Console.WriteLine("     |     |      ");

                    Console.WriteLine("  {0}  |  {1}  |  {2}", board[1], board[2], board[3]);

                    Console.WriteLine("_____|_____|_____ ");

                    Console.WriteLine("     |     |      ");

                    Console.WriteLine("  {0}  |  {1}  |  {2}", board[4], board[5], board[6]);

                    Console.WriteLine("_____|_____|_____ ");

                    Console.WriteLine("     |     |      ");

                    Console.WriteLine("  {0}  |  {1}  |  {2}", board[7], board[8], board[9]);

                    Console.WriteLine("     |     |      ");
                }
            }
        }
    






        
    


