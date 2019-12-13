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


    public class Words
    {
        //const string WordFilePath = @"C:/Users/danie/Documents/#Testning/Projektarbete/WordFile.txt";
        const string WordFilePath = @"WordFile.txt";


        public static string WordsFromText(string wordToCrack)
        {
            List<string> wordList = new List<string>(File.ReadAllLines(WordFilePath));
            Random rnd = new Random();

            int indexwordList = rnd.Next(wordList.Count());

            wordToCrack = wordList[indexwordList];

            return wordToCrack;
        }

        public string theFilePath()
        {
            string filePath = @"WordFile.txt";
            return filePath;
        }

    }
}
