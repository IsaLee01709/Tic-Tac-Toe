using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;

namespace Tic_Tac_Toe
{
    class program
    {
        //Making the array of spots on the grid, and the 'choice' of position made by the specified user.
        static char[] gridArray = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int playerChoice;
        static int player = 1;


        //Grid method, creates the grid.
        private static void Grid()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {gridArray[1]}  |  {gridArray[2]}  |  {gridArray[3]}";
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {gridArray[4]}  |  {gridArray[5]}  |  {gridArray[6]}";
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {gridArray[7]}  |  {gridArray[8]}  |  {gridArray[9]}";
            Console.WriteLine("     |     |      ");
        }

    }
}
