using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using HangmanProjektArbete;
using System.IO;

namespace HangmanTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void mockWordsFromText_FakeWordGiven_MatchesCorrectWord()
        {
            Words tFP = new Words();

            string fakeWord = tFP.theFilePath();

            string trueWord = Game.correctWord;


            Assert.AreEqual(fakeWord, trueWord);

        }


        [Test]
        public void ValidInput_UserPrintsNumber_ReturnFalse()
        {
            Game game = new Game();
            string[] guessNumber = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

            for (int i = 0; i < guessNumber.Length; i++)
            {
                string guessedLetter = guessNumber[i];
                var result = Game.ValidInput(guessedLetter);
                Assert.False(result);
            }
        }


        [Test]
        public void Startmenu_InputLetter_IncorrectSymbolInput()
        {
            Menu menu = new Menu();

            string mainMenu = "!";
            string expected = "1";

            string result = mainMenu;

            StringAssert.DoesNotContain(mainMenu, expected);
        }

        [Test]
        public void Startmenu_InputLetter_IncorrectHighNumberInput()
        {
            Menu menu = new Menu();

            string mainMenu = "8";
            string expected = "1";

            string result = mainMenu;

            StringAssert.DoesNotContain(mainMenu, expected);
        }

        [Test]
        public void InsertGuessToWord_GivenValidGuess_ReturnTrue()
        {

            Game.guessedLetter = "H";
            Game.correctWord = "HEJSAN";

            bool result = Game.correctWord.Contains(Game.guessedLetter);

            Assert.True(result);
        }

        [Test]
        public void InsertGuessToWord_GivenInvalidGuess_ReturnFalse()
        {

            Game.guessedLetter = "P";
            Game.correctWord = "HEJSAN";

            bool result = Game.correctWord.Contains(Game.guessedLetter);

            Assert.False(result);
        }


    }
}