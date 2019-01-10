using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingKataProject;

namespace BowlingKata.Tests
{
    [TestClass]
    public class BowlingKataUnitTests
    {

        private Game g;
        public BowlingKataUnitTests() //Array de inicializacao da classe
        {
            g = new Game();
        }

        [TestMethod]
        public void DoesGameExist() //Testa se o objeto game existe
        {
            //arrange
            //act
            //assert
            Assert.IsNotNull(g);
             
        }

        [TestMethod]
        public void GutterGame_Return0() //No pins are knocked down
        {
            //arrange
            //act
            RollMany(20, 0);

            //assert
            Assert.AreEqual(0, g.scoreGame());

        }

        [TestMethod]
        public void SinglePinGame_Return20() //1 pin is knocked down every roll
        {
            //arrange
            //act
            RollMany(20, 1);

            //assert
            Assert.AreEqual(20, g.scoreGame());

        }

        [TestMethod]
        public void OneSpareReturnsAppropriateValue() //1 spare
        {
            //arrange
            g.roll(5);
            g.roll(5); //spare
            g.roll(3);
            
            //act
            RollMany(17, 0);

            //assert
            Assert.AreEqual(16, g.scoreGame()); //16 because is 5 + 5 + 3 (bonus from spare) + 3 + the rest of guttered rolls

        }

        [TestMethod]
        public void OneStrikeReturnsAppropriateValue() //1 spare
        {
            //arrange
            g.roll(10); //strike
            g.roll(3);
            g.roll(4);

            //act
            RollMany(16, 0); //because you skip one roll in the frame you got your strike

            //assert
            Assert.AreEqual(24, g.scoreGame()); //16 because is 5 + 5 + 3 (bonus from spare) + 3 + the rest of guttered rolls

        }

        [TestMethod]
        public void PerfectGame() //1 spare
        {
            //arrange
            
            //act
            RollMany(12, 10); //because you skip one roll in the frame you got your strike

            //assert
            Assert.AreEqual(300, g.scoreGame()); //16 because is 5 + 5 + 3 (bonus from spare) + 3 + the rest of guttered rolls

        }

        public void RollMany(int rolls, int pins) //Simulates the 20 rolls
        {
            for (int i = 0; i < rolls; i++)
            {
                g.roll(pins);
            }
        }
    }
}
