using FizzBuzz;
using NUnit.Framework;
using System.Collections.Generic;

namespace FizzBuzzTest
{
    public class Tests
    {
        [TestCase(1, "1")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        public void test_getResponse_inputNumber(int position, string expectedResponse)
        {
            FizzBuzzList fizzBuzz = new FizzBuzzList();
            List<string> list = fizzBuzz.GetList();
            Assert.AreEqual(list[position - 1], expectedResponse);
        }
    }
}