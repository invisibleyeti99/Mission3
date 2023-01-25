using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace
namespace backendMission3
{

    //class
    class Driver
    {

        //initiate variables--array, play count for player, choice for their input, won to measure game
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8' };
        static int playCount = 1;
        static int choice;
        static int won = 0;
        static char[] playAgain = { 'n' };

        //first method
        static void Main(string[] args)
        {

            //import the class from other page
            Class1 C1 = new Class1();

            //welcome message
            Console.WriteLine("Welcome to Tic Tac Toe!");

            //while handler to run the game until it ends
            while (true)
            {

                //write the instructions
                Console.WriteLine("Player 1 is O, Player 2 is X");
                Console.WriteLine("\n");

                //print the board
                C1.printBoard(arr);

                //determine which player's turn it is
                if (playCount % 2 == 0)
                {
                    Console.WriteLine("Player 2 Enter your choice");
                }

                //else for player 1
                else
                {
                    Console.WriteLine("Player 1 Enter your choice");
                }

                //try loop to catch errors. Originally used for when the input from the user isn't in the array of choices
                try
                {
                    //parse the user input to an int
                    choice = int.Parse(Console.ReadLine());

                    //check if the user has already chosen that slot
                    if (arr[choice] != 'X' && arr[choice] != 'O')
                    {

                        //if not already chosen, replace it with an X
                        if (playCount % 2 == 0)
                        {
                            arr[choice] = 'X';
                            playCount++;
                        }

                        //else loop for the O player
                        else
                        {
                            arr[choice] = 'O';
                            playCount++;
                        }

                        //clear console to beautify
                        Console.Clear();
                    }

                    //else handler if the space has already been chosen--returns back a message to the user
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry, space {0} is already marked with {1}", choice, arr[choice]);
                        Console.WriteLine("\n");
                    }

                    //call the winning method which returns won as a variable
                    won = C1.decideWinner(arr);

                    //if it isn't = 0 then the game is over
                    if (won != 0)
                    {

                        //break the loop
                        break;
                    }
                }

                //catch handler for if the player enters something not in the array
                //returns an error message and resets to top of the try loop
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please enter a number between 0 and 8.");
                    continue;
                }
            }

            //print board only used when the game is done so that you can see the end result of the board
            C1.printBoard(arr);
            Console.ReadLine();
        }
    }
}
