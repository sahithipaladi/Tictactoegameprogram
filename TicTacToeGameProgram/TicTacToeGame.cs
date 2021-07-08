using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGameProgram
{
    class TicTacToeGame
    {
        public char ChooseLetter()
        {
          while(true)
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
    }
}




        
    


