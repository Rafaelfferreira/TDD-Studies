using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculatorKata;

namespace StringCalculatorKata.Test
{
    [TestClass]
    public class StringCalculatorTests
    {
        Calculator calc = new Calculator(); //initializing a calculator object to be tested on the individual unit tests.

        [TestMethod]
        public void DoesCalcExist()
        {
            //arrange
            //act
            //assert
            Assert.IsNotNull(calc);
        }

        [TestMethod]
        public void GivenEmptyStringReturns0()
        {
            //arrange
            //act
            int result = calc.Add("");
            //assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void GivenANumberReturnTheEntry()
        {
            //testing first value
            //act
            int result = calc.Add("13");
            //assert
            Assert.AreEqual(13, result);

            //testing second value
            //act
            result = calc.Add("456186135");
            //assert
            Assert.AreEqual(456186135, result);

            //testing third value
            //act
            result = calc.Add("-5");
            //assert
            Assert.AreEqual(-5, result);
        }

        [TestMethod]
        public void Given2NumbersReturnTheSum()
        {
            //testing first value
            //act
            int result = calc.Add("5,7");
            //assert
            Assert.AreEqual(12, result);

            //testing first value
            //act
            result = calc.Add("456125,4847");
            //assert
            Assert.AreEqual(460972, result);

            //testing first value
            //act
            result = calc.Add("-5,7");
            //assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void GivenMoreThan2NumbersOnlyAddsTheFirstTwo()
        {
            //testing first value
            //act
            int result = calc.Add("3,4,6");
            //assert
            Assert.AreEqual(7, result);

            //testing first value
            //act
            result = calc.Add("453,4818,1516");
            //assert
            Assert.AreEqual(5271, result);

            //testing first value
            //act
            result = calc.Add("3,-4,6");
            //assert
            Assert.AreEqual(-1, result);
        }
    }
}
