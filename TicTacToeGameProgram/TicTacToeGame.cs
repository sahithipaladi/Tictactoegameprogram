﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGameProgram
{
    class TicTacToeGame
    {
        public  void CreateBoard()

        {
            char[] arr = {  '1', '2', '3', '4', '5', '6', '7', '8', '9', };

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {1}  |  {2}  |  {3}", arr[1], arr[2], arr[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {1}  |  {2}  |  {3}", arr[4], arr[5], arr[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {1}  |  {2}  |  {3}", arr[7], arr[8], arr[9]);

            Console.WriteLine("     |     |      ");



        }
    }
}
