using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    /// <summary>
    /// Organizes logic for running a guitar shop game simulation.
    /// </summary>
    public class ShopGame
    {


        public static void Start()
        {
            bool running = true;
            while (running)
            {
                DisplayScreen();
                GetInput();
                MainLogic();

            }

        }

        public static void DisplayScreen()
        {
            Console.WriteLine("Hello, type a number.");
        }

        public static int GetInput()
        {
            bool invalidInput = true;

            while (invalidInput)
            {
                string input = Console.ReadLine();

                int value;
                invalidInput = !int.TryParse(input, out value);

                if (invalidInput)
                {
                    Console.WriteLine("Not a valid input. Try again.");
                }
                else
                {
                    return value;
                }
            }

            return 0;
        }

        public static void MainLogic()
        {

        }

    }
}
