using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KentBeckMoneyExample.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void cloningFunctionIsWorking()
        {
            //arrange
            Dollar five = new Dollar(5);
            Dollar testDollar = (Dollar)five.Clone();
            //act
            testDollar.amount = 100;
            //assert
            Assert.AreEqual(5, five.amount);
            
        }

        [TestMethod]
        public void testMultiplication()
        {
            //first test
            //arrange
            Dollar five = new Dollar(5);
            Dollar product = (Dollar)five.Clone();
            //act
            product.times(2);
            //assert
            Assert.AreEqual(10, product.amount);

            //second test
            //arrange
            product = (Dollar)five.Clone(); ;
            //act
            product.times(3);
            //assert
            Assert.AreEqual(15, product.amount);
        }
    }
}
