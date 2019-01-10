using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciProject;

namespace FibonacciProject.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Fib_Given0_Return0() //Testa se retorna 0 caso o numero de entrada for 0 (Primeiro numero da sequencia de fibonacci, definido)
        {
            //arrange
            int n = 0;

            //act
            int result = Fibonacci.Fib(n);

            //assert - Compara o resultado esperado com o resultado obtido
            Assert.AreEqual(0, result);
        }

        [TestMethod] //eh preciso identificar que o metodo criado eh um TestMethod
        public void Fib_Given1_Return1()
        {
            //arrange
            int n = 1;

            //act
            int result = Fibonacci.Fib(n);

            //assert
            Assert.AreEqual(1, result);
        }

        [TestMethod] //eh preciso identificar que o metodo criado eh um TestMethod
        public void Fib_Given2_Return1()
        {
            //arrange
            int n = 2;

            //act
            int result = Fibonacci.Fib(n);

            //assert
            Assert.AreEqual(1, result);
        }

        [TestMethod] //eh preciso identificar que o metodo criado eh um TestMethod
        public void Fib_Given3_Return2()
        {
            //arrange
            int n = 3;

            //act
            int result = Fibonacci.Fib(n);

            //assert
            Assert.AreEqual(2, result);
        }

        [TestMethod] //eh preciso identificar que o metodo criado eh um TestMethod
        public void Fib_Given4_Return3()
        {
            //arrange
            int n = 4;

            //act
            int result = Fibonacci.Fib(n);

            //assert
            Assert.AreEqual(3, result);
        }

        [TestMethod] //eh preciso identificar que o metodo criado eh um TestMethod
        public void Fib_Given11_Return89()
        {
            //arrange
            int n = 11;

            //act
            int result = Fibonacci.Fib(n);

            //assert
            Assert.AreEqual(89, result);
        }
    }
}
