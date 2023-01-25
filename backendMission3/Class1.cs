using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace
namespace backendMission3
{

    //class
    class Class1
    {

        //method
        public void printBoard(char[] arr)
        {

            //code for the printing of board
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

        //method to decide winner
        public  int decideWinner(char[] arr)
        {

            //initiate the variables
            int won = 0;
            char winningChar = 'N';

            //Horitzontal win conditions
            if (arr[0] == arr[1] && arr[1] == arr[2])
            {
                winningChar = arr[0];
                won = 1;

            }

            //second row
            else if (arr[3] == arr[4] && arr[4] == arr[5])
            {
                winningChar = arr[3];
                won = 1;
            }

            //third row
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

            //second column
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                winningChar = arr[1];
                won = 1;
            }

            //third column
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                winningChar = arr[2];
                won = 1;
            }

            //diagonals
            else if (arr[0] == arr[4] && arr[4] == arr[8])
            {
                winningChar = arr[0];
                won = 1;
            }

            //other diagonal
            else if (arr[2] == arr[4] && arr[4] == arr[6])
            {
                winningChar = arr[2];
                won = 1;
            }

            // Tie method
            else if (arr[0] != '0' && arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8')
            {
                won = 2;
            }

            //win returns for who won
            if (won == 1)
            {
                Console.WriteLine("The winner is " + winningChar);
            }

            //tie returns the tie
            if (won == 2)
            {
                Console.WriteLine("Its a tie! ");
            }

            //returns the won variable
            return won; 
        }
    }
}
