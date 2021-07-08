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

                
                    char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

                    Console.WriteLine("     |     |      ");

                    Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);

                    Console.WriteLine("_____|_____|_____ ");

                    Console.WriteLine("     |     |      ");

                    Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);

                    Console.WriteLine("_____|_____|_____ ");

                    Console.WriteLine("     |     |      ");

                    Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);

                    Console.WriteLine("     |     |      ");
                }
            }
        }
    






        
    


