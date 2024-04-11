namespace TicTacToe
{
    public class Program
    {
        static char[] gridArray = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int playerChoice;
        static int player = 1;
        static int flag = 0;

        public static void Main(string[] args)
        {

            //TODO  IMPLEMENT WRAPPED LOOP AROUND EXISITING LOOP TO PROMPT PLAYERS TO START GAME AGAIN
            //& IMPLEMENT FIX FOR NON-ASSOCIATIVE VALUES.
            int status;
            do
            {
                Console.Clear();
                Console.WriteLine("Player 1 is X's   and   Player 2 is O's");

                if (player % 2 != 0)
                {
                    Console.WriteLine("Player 1's turn...");
                }
                else
                {
                    Console.WriteLine("Player 2's turn...");
                }

                Grid();
                playerChoice = int.Parse(Console.ReadLine());

                if (gridArray[playerChoice] != 'X' && gridArray[playerChoice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        gridArray[playerChoice] = 'O';
                        player++;
                    }
                    else
                    {
                        gridArray[playerChoice] = 'X';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine($"The spot {playerChoice} is already taken...");
                    Thread.Sleep(500);
                }
                status = WinChecker();
            }
            while (status != 1 && status != -1);

            Console.Clear();
            Grid();

            if (flag == 1)
            {
                Console.WriteLine($"Player {(player % 2) + 1} won!!!");
            }
            else
            {
                Console.WriteLine("It's a tie...");
            }
            Console.ReadLine();
        }

        private static void Grid()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {gridArray[1]}  |  {gridArray[2]}  |  {gridArray[3]}");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {gridArray[4]}  |  {gridArray[5]}  |  {gridArray[6]}");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {gridArray[7]}  |  {gridArray[8]}  |  {gridArray[9]}");
            Console.WriteLine("     |     |      ");
        }

        private static int WinChecker()
        {
            if ((gridArray[1] == gridArray[2] && gridArray[2] == gridArray[3]) ||
                (gridArray[4] == gridArray[5] && gridArray[5] == gridArray[6]) ||
                (gridArray[6] == gridArray[7] && gridArray[7] == gridArray[8]) ||
                (gridArray[1] == gridArray[4] && gridArray[4] == gridArray[7]) ||
                (gridArray[2] == gridArray[5] && gridArray[5] == gridArray[8]) ||
                (gridArray[3] == gridArray[6] && gridArray[6] == gridArray[9]) ||
                (gridArray[1] == gridArray[5] && gridArray[5] == gridArray[9]) ||
                (gridArray[3] == gridArray[5] && gridArray[5] == gridArray[7]))
            {
                return flag = 1;
            }
            else if ((gridArray[1] != '1' && gridArray[2] != '2' && gridArray[3] != '3' && gridArray[4] != '4' && gridArray[5] != '5' && gridArray[6] != '6' && gridArray[7] != '7' && gridArray[8] != '8' && gridArray[9] != '9'))
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}