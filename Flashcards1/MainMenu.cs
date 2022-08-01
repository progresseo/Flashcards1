using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcards1
{
    class MainMenu
    {
        public static void Menu()
        {
            bool closeApp= false;
        while(closeApp == false)
            {
                Console.WriteLine("0 to Exit");
                Console.WriteLine("A to Manage Stacks");
                Console.WriteLine("B to Manage Flashcards");
                Console.WriteLine("C to Study");
                Console.WriteLine("D to View Study Sessions");

                string optionSelected = Console.ReadLine();

                switch (optionSelected)
                {
                    case "0":
                        closeApp = true;
                        break;
                    case "A":
                        Console.WriteLine("test");
                        break;
                    case "B":
                        Console.WriteLine("test");
                        break;
                    case "C":
                        Console.WriteLine("test");
                        break;
                    case "D":
                        Console.WriteLine("test");
                        break;
                    default:
                        Console.WriteLine("Please ensure you enter the letter exactly as seen.");
                        break;
                }


            }

        }

    }
}






