using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backendMission3
{
    class Class1
    {
        public void printBoard(char[] arr)
        {

            Console.WriteLine("     |     |    ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", arr[0], arr[1], arr[2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |    ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", arr[3], arr[4], arr[5]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |    ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", arr[6], arr[7], arr[8]);
            Console.WriteLine("     |     |    ");
            Console.WriteLine();
        }
        public  int decideWinner(char[] arr)
        {
            int won = 0;
            char winningChar = 'N';
            //Horitzontal win conditions
            if (arr[0] == arr[1] && arr[1] == arr[2])
            {
                winningChar = arr[0];
                won = 1;

            }
            else if (arr[3] == arr[4] && arr[4] == arr[5])
            {
                winningChar = arr[3];
                won = 1;
            }
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                winningChar = arr[6];
                won = 1;
            }


            //Vertical Win conditions
            else if (arr[0] == arr[3] && arr[3] == arr[6])
            {
                winningChar = arr[0];
                won = 1;
            }
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                winningChar = arr[1];
                won = 1;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                winningChar = arr[2];
                won = 1;
            }

            //Horizontal Win conditions
            else if (arr[0] == arr[4] && arr[4] == arr[8])
            {
                winningChar = arr[0];
                won = 1;
            }
            else if (arr[2] == arr[4] && arr[4] == arr[6])
            {
                winningChar = arr[2];
                won = 1;
            }
            else if (arr[0] != '1' && arr[1] != '2' && arr[2] != '3' && arr[3] != '4' && arr[4] != '5' && arr[5] != '6' && arr[6] != '7' && arr[7] != '8' && arr[8] != '9')
            {

                won = 2;
            }
            if (won == 1)
            {
                Console.WriteLine("The winner is " + winningChar);
            }
            if (won == 2)
            {
                Console.WriteLine("Its a tie! ");
            }
            return won; 
        }
    }
}
