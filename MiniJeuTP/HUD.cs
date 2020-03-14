using System;
using System.Collections.Generic;
using System.Windows;

namespace MiniJeuTP
{
    static class HUD
    {
        public static void Menu(List<string> choices, ref uint pointer)
        {
            Console.WriteLine("First RPG !");
            Console.WriteLine("");

            foreach (string choice in choices)
            {
                if (choices.IndexOf(choice) == pointer % choices.Count)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write(choice);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("   ");

            }

            bool check = false;
 
            while (!check)
            {
                ConsoleKey press = Console.ReadKey(true).Key;

                if (press == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    pointer--;
                    Menu(choices, ref pointer);
                    check = true;
                }

                else if (press == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    ++pointer;
                    Menu(choices, ref pointer);
                    check = true;
                }

                else if (press == ConsoleKey.Enter)
                {
                    check= true;
                }
            }

            if (choices.IndexOf("Quitter") == pointer % choices.Count)
                Environment.Exit(0);

        }

        public static void Run(ref int[] result)
        {

        }
    }
}
