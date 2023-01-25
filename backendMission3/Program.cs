using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace backendMission3
{
    class Driver
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8' };
        static int playCount = 1;
        static int choice;
        static int won = 0;

        static void Main(string[] args)
        {
            Class1 C1 = new Class1();

            Console.WriteLine("Welcome to Tic Tac Toe!");

            while (true)
            {

                //Console.Clear();
                Console.WriteLine("Player 1 is O, Player 2 is X");
                Console.WriteLine("\n");

                C1.printBoard(arr);
                if (playCount % 2 == 0)
                {
                    Console.WriteLine("Player 2 Enter your choice");
                }

                else
                {
                    Console.WriteLine("Player 1 Enter your choice");

                }

                choice = int.Parse(Console.ReadLine());

                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (playCount % 2 == 0)
                    {
                        arr[choice] = 'X';
                        playCount++;
                    }

                    else
                    {
                        arr[choice] = 'O';
                        playCount++;
                    }
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, space {0} is already marked with {1}", choice, arr[choice]);
                    Console.WriteLine("\n");
                }
                won = C1.decideWinner(arr);

                if (won != 0)
                {
                    break;
                }

            }

        }

    }
}
