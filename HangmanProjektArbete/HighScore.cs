using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows.Documents;

namespace HangmanProjektArbete
{
    public class HighScore
    {
        public const string pathHS = @"C:\Users\danie\Documents\#Testning\Projektarbete\HangmanProjektArbete\HangmanProjektArbete\HangmanProjektArbete\HighScore.txt";

        public static void StoreHighScore()
        {

            Console.WriteLine("Enter your name for the High Score List!!");
            string nameForHighScore = Console.ReadLine();

            File.WriteAllText(pathHS, nameForHighScore);

            File.OpenText(pathHS);

            Console.WriteLine("Namnet borde vara adderat");
            
            //return nameForHighScore;

        }
    }
}
