using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanProjektArbete
{
    public class Menu
    {
        //Startmenu
        public static void StartMenu(string mainMenu)
        {
            Game game = new Game();
            Game.life = 5;
            
            Console.Clear();
            Console.WriteLine("     Welcome to Hangman!");
            Console.WriteLine("    made by Daniel & Huy! \n \n");

            Console.WriteLine("    ######   Meny   ##### \n");
            Console.WriteLine("    ##  1. Start game  ##");
            Console.WriteLine("    ##  2. Quit        ##");
            Console.WriteLine("                    ");
                Console.Write("      Input: ");
            mainMenu = Console.ReadLine();

            switch (mainMenu)
            {
                case "1":
                    game.GameStart();
                    break;

                case "2":
                    Console.WriteLine("You are now quitting...");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Wrong input, write number silly! \n and press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
