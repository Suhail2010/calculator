using calc;
using Xunit;
using System;

namespace Calc_Program_Test
{
    public class TestZeroDivision
    {
        [Fact]
        public void CheckDivision()
        {
            double num1 = 4;
            double num2 = 2;
            double expectedResult = 2;


            double result = Program.Dela(num1, num2);

            Assert.Equal(expectedResult, result, 4);
        }
        [Fact]
        public void CheckAddition()
        {
            double num1 = 4;
            double num2 = 2;
            double expectedResult = 6;


            double result = Program.Plus(num1, num2);

            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void CheckSubtraction()
        {
            double num1 = 5;
            double num2 = 2;
            double expectedResult = 3;


            double result = Program.Minus(num1, num2);

            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void CheckMultiplication()
        {
            double num1 = 4;
            double num2 = 2;
            double expectedResult = 8;


            double result = Program.Multi(num1, num2);

            Assert.Equal(expectedResult, result, 4);
        }
        [Fact]
        public void DivideByZero() {
            double num1 = 5;
            double num2 = 0;
            string expectedResult = "Can't Divide by zero ";

            var result = Assert.Throws<DivideByZeroException>(() => Program.Dela(num1, num2));
            
            Assert.Equal(expectedResult, result.Message);


        }
    }
}