using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;

namespace HangmanProjektArbete
{
    public class Game
    {
        Random random = new Random(); //  använder oss av randomFunction
        public bool deadHandler;
        public bool winHandler;
        public static int life = 5;
        public static bool correctInput = false;
        public static string guessedLetter; // Guess är det vi skriver in för att gissa på ordet
        public static string correctWord = Words.WordsFromText(wordToCrack:"").ToUpper(); // det rätta ordet som vi tar in från en txt-fil
        public int revealedLetters = 0; // antalet bokstäver som skrivs ut 
        public static List<string> usedLetters = new List<string>();
        public static StringBuilder displayString;

        public bool checkIfWin()
        {
            if (revealedLetters == correctWord.Length)
            {
                return true;
            }
            if (guessedLetter == correctWord)
            {
                return true;
            }
            return false;
        }
        public bool checkIfDead()
        {
            if (life == 0)
            {
            return true;
            }
            return false;
        }

        public void winAction()
        {
            winHandler = checkIfWin();
            if (winHandler == true)
            {
                Console.Clear();
                Console.WriteLine("YOU WON!");
                Console.ReadKey();
                Menu.StartMenu(mainMenu: "");
            }

        }
        public void deadAction()
        {
            if (deadHandler == true)
            {
                Console.WriteLine("DED!");
                Console.ReadKey();
                Menu.StartMenu(mainMenu: "");
            }
        }

        public void wordDisplayHandle()
        {
            displayString = new StringBuilder(correctWord.Length); // Stringbuilder visar antalet bokstäver som finns med som "_" och skriver ut de bokstäver som gissats rätt
           
            Words.WordsFromText(wordToCrack:"");
            for (int i = 0; i < correctWord.Length; i++)
                displayString.Append("_");
        }

        public bool InsertGuessToWord()
        {
            try
            {
                if (correctWord.Contains(guessedLetter))
                {
                    for (int i = 0; i < correctWord.Length; i++)
                    {
                        if (correctWord[i] == guessedLetter[0])
                        {

                            displayString[i] = correctWord[i];
                            revealedLetters++;
                        }
                    }

                }
            }
            catch (Exception)
            {
             
            }
           
            return true;
        }

        public static bool ValidInput(string guessedLetter)
        {
            if (correctInput = Regex.IsMatch(guessedLetter, @"^[a-zA-Z]+$"))
            {
                return true;
            }
            return false;
        }

        public bool validGuess()
        {
            if (correctInput == true && guessedLetter.Length == 1 && !usedLetters.Contains(guessedLetter))
            {
                if (correctWord.Contains(guessedLetter))
                {
                    Console.WriteLine("                   CORRECT!");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("                     Nope!");
                    life--;
                    Thread.Sleep(1000);
                    usedLetters.Add(guessedLetter);
                }
                return true;
            }
            if (correctInput == false)
            {
                Console.WriteLine("Please enter a correct letter");
                Thread.Sleep(1000);
            }
            return false;
        }

        public void GameStart()
        {
            wordDisplayHandle();
            do
            {
                checkIfDead();
                checkIfWin();
                deadAction();
                winAction();
                TextHandler.hangedMan();
                InsertGuessToWord();
                ValidInput(guessedLetter);
                validGuess();
            } while (checkIfDead() == false || checkIfWin() == true) ;
        }
    }
}
