using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcards1
{
    class ManageStacks
    {
        public static void StacksMenu()
        {
            bool closeApp = false;
            while (closeApp == false)
            {
                Console.WriteLine("0 to Exit");
                Console.WriteLine("A to Create Stack");
                Console.WriteLine("B to Delete Stack");
                Console.WriteLine("C to Update Stack");
                Console.WriteLine("D to MainMenu");

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
                        MainMenu.Menu();
                        break;
                    default:
                        Console.WriteLine("Please ensure you enter the letter exactly as seen.");
                        break;
                }


            }
        }
}
