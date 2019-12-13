using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using HangmanProjektArbete;
using System.IO;


namespace HangmanTest
{
   public class UnitTest2
    {

        [Test]
        public void StartGame_Startinglife_IsFull()
        {
            Game game = new Game();
         
            int FullLifeExpected = 5;

            int realLifeValue = game.life;

            Assert.AreEqual(FullLifeExpected, realLifeValue);

        }

        [Test] //Det ska returna False eftersom koden är skriven att man endast är död om man life har värdet 0
        public void CheckIfDead_NegativeLife_ReturnsFalse()
        {
            Game game = new Game();

            game.life = -1;

            bool result = game.checkIfDead();

            Assert.False(result);
        }

        [Test]
        public void StartGame_DecreaseLife_ReturnsFour() 
        {   Game game = new Game();


            game.life--;


            int expectedLifeValue = 4;

            Assert.AreEqual(expectedLifeValue, game.life);
        }

        [Test]
        public void StartGame_WrongType_ReturnsAreNotEqual()
        {
            Game game = new Game();
            string doubleLife = "5";

            int realLifeValue = game.life;

            Assert.AreNotEqual(doubleLife, realLifeValue);
        }

        [Test]
        public void CheckIfDead_AreWeDead_ReturnFalse()
        {
            
            Game game = new Game();
            game.life = 1;

            bool result = game.checkIfDead();

            Assert.False(result);

        }


        [Test]
        public void CheckIfDead_AreWeDead_ReturnTrue()
        {

            Game game = new Game();
           
            game.life = 0;
            bool result = game.checkIfDead();

            Assert.True(result);

        }
        [Test]
        public void CheckIfWin_InputWholeWord_ReturnTrue()
        {
            Game game = new Game();

            Game.guessedLetter = "WIN";
            Game.correctWord = "WIN";


            bool result = game.checkIfWin();

            Assert.True(result);
        }

        [Test]
        public void CheckIfWin_InputTwoLetters_ReturnFalse()
        {
            Game game = new Game();
            Game.guessedLetter = "WI";
            Game.correctWord = "WIN";

            bool result = game.checkIfWin();

            Assert.False(result);
        }

        [Test]
        public void CheckIfWin_LettersRevealedValueIsWin_ReturnTrue()
        {
            Game game = new Game();

            game.revealedLetters = Game.correctWord.Length;

            bool result = game.checkIfWin();

            Assert.True(result);

        }
        public void CheckIfWin_LettersRevealedValueIsNotWin_ReturnFalse()
        {
            Game game = new Game();

            game.revealedLetters = 1;

            bool result = game.checkIfWin() ;

            Assert.False(result);


        }

        [Test]
        public void ValidInput_InputTwoLetters_ReturnFalse()
        {
            Game game = new Game();
            Game.guessedLetter = "WI";
            Game.correctWord = "WIN";

            bool result = game.validGuess();

            Assert.False(result);
        }

        [Test]
        public void ValidInput_InputLowerCase_ReturnTrue()
        {


            Game.guessedLetter = "w";
            Game.correctWord = "WIN";

            bool result = Game.ValidInput(Game.guessedLetter);

            Assert.True(result);

        }
        
       
       
    }
}
