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
            result = calc.Add("5");
            //assert
            Assert.AreEqual(5, result);
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
            result = calc.Add("5,7");
            //assert
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void GivenMoreThan2NumberAddsAllOfThem()
        {
            //testing first value
            //act
            int result = calc.Add("8,9,2");
            //assert
            Assert.AreEqual(19, result);

            //testing second value
            //act
            result = calc.Add("1,1,1,1,1,1,1,1,5");
            //assert
            Assert.AreEqual(13, result);

            //testing third value
            //act
            result = calc.Add("4,4,4,4");
            //assert
            Assert.AreEqual(16, result);
        }

        [TestMethod]
        public void AcceptsEntriesWithMultipleLines()
        {
            //testing first value
            //act
            int result = calc.Add("1\n2,3");
            //assert
            Assert.AreEqual(6, result);

            //testing first value
            //act
            result = calc.Add("2\n4\n8\n2");
            //assert
            Assert.AreEqual(16, result);

            //testing first value
            //act
            result = calc.Add("1\n4");
            //assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void AcceptsDifferentDelimitators()
        {
            //testing first value
            //act
            int result = calc.Add("//;\n1;2");
            //assert
            Assert.AreEqual(3, result);

            //testing first value
            //act
            result = calc.Add("//a\n2a3\n5");
            //assert
            Assert.AreEqual(10, result);

            //testing first value
            //act
            result = calc.Add("//poo\n9poo8poo1\n2");
            //assert
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void ThrowsExceptionsWhenNegativeNumbersAreUsed()
        {
            //act
            int result = calc.Add("-5");
        }
    }
}
