using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanProjektArbete
{
   public class TextHandler
    {

        public static void hangedMan()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Clear();
            if (Game.life == 5)
            {
                Console.WriteLine($"   The Hangman Game    HP: 	♥♥♥♥♥  {Game.life}                       ");
                Console.WriteLine("-------------------------------------------------                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("             " + Game.displayString + "              ");


                Console.WriteLine("-------------------------------------------------                   ");
                Console.WriteLine("                  Used letters                                      ");

            }
            if (Game.life == 4)
            {
                Console.WriteLine($"   The Hangman Game    HP: 	♥♥♥♥   {Game.life}                        ");
                Console.WriteLine("-------------------------------------------------                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                     |                         |                   ");
                Console.WriteLine("|                     |                         |                   ");
                Console.WriteLine("|                     |                         |                   ");
                Console.WriteLine("|                     |                         |                   ");
                Console.WriteLine("|             ________|_______                  |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("             " + Game.displayString + "              ");
                Console.WriteLine("-------------------------------------------------                   ");
                Console.WriteLine("                  Used letters                                      ");

            }
            if (Game.life == 3)
            {
                Console.WriteLine($"   The Hangman Game    HP: 	♥♥♥    {Game.life}                  ");
                Console.WriteLine("-------------------------------------------------                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                      ____________             |                   ");
                Console.WriteLine("|                     |                         |                   ");
                Console.WriteLine("|                     |                         |                   ");
                Console.WriteLine("|                     |                         |                   ");
                Console.WriteLine("|                     |                         |                   ");
                Console.WriteLine("|             ________|_______                  |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("             " + Game.displayString + "              ");
                Console.WriteLine("-------------------------------------------------                   ");
                Console.WriteLine("                  Used letters                                      ");
            }
            if (Game.life == 2)
            {
                Console.WriteLine($"   The Hangman Game    HP: 	♥♥     {Game.life}                    ");

                Console.WriteLine("-------------------------------------------------                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                      ____________             |                   ");
                Console.WriteLine("|                     |           o             |                   ");
                Console.WriteLine(@"|                     |          /O\            |                   ");
                Console.WriteLine("|                     |                         |                   ");
                Console.WriteLine("|                     |                         |                   ");
                Console.WriteLine("|             ________|_______                  |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("             " + Game.displayString + "              ");
                Console.WriteLine("-------------------------------------------------                   ");
                Console.WriteLine("                  Used letters                                      ");

            }
            if (Game.life == 1)
            {
                Console.WriteLine($"   The Hangman Game    HP: 	♥      {Game.life}                  ");
                Console.WriteLine("-------------------------------------------------                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                      ____________             |                   ");
                Console.WriteLine("|                     |           o             |                   ");
                Console.WriteLine(@"|                     |          /O\            |                   ");
                Console.WriteLine(@"|                     |           |             |                   ");
                Console.WriteLine("|                     |                         |                   ");
                Console.WriteLine("|             ________|_______                  |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("             " + Game.displayString + "              ");
                Console.WriteLine("-------------------------------------------------                   ");
                Console.WriteLine("                  Used letters                                      ");
            }
            if (Game.life == 0)
            {
                Console.WriteLine($"   The Hangman Game    HP: 	     {Game.life}               ");
                Console.WriteLine("-------------------------------------------------                   ");
                Console.WriteLine("|                 RIP                           |                   ");
                Console.WriteLine("|            U DED OK?                          |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("|                      ____________             |                   ");
                Console.WriteLine("|                     |           o             |                   ");
                Console.WriteLine(@"|                     |          /O\            |                   ");
                Console.WriteLine(@"|                     |          /|\            |                   ");
                Console.WriteLine("|                     |                         |                   ");
                Console.WriteLine("|             ________|_______                  |                   ");
                Console.WriteLine("|                                               |                   ");
                Console.WriteLine("             " + Game.displayString + "              ");
                Console.WriteLine("-------------------------------------------------                   ");
                Console.WriteLine("                  Used letters                                      ");
            }
            foreach (var item in Game.usedLetters)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------                   ");
            Console.WriteLine("                 Guess a letter                                       ");

            Console.WriteLine(Game.correctWord);

            Game.guessedLetter = Console.ReadLine().ToUpper();


        }

    }
}
