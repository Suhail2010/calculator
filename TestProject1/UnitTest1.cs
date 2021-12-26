using calc;
using Xunit;
using System;

namespace Calc_Program_Test
{
    public class TestMathResults
    {
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
        public void CheckDivideByZero() {
            double num1 = 5;
            double num2 = 0;
            double nums = num1 / num2;
            double expectedResult = nums;

            var result = Program.Dela(num1, num2);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CheckDivideByZeroThrow()
        {
            double num1 = 5;
            double num2 = 0;
            var result = Assert.Throws<DivideByZeroException>(() => Program.Dela2(num1, num2));

            Assert.Equal("Can't divide by zero ", result.Message);
        }


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
        public void CheckPlusArray()
        {
            double[] nums = new double[] { 15, 30, 5, 50 };

            double expectedResult = 100;

            double result = Program.Plus(nums);

            Assert.Equal(expectedResult, result, 4);
        }

        [Fact]
        public void CheckMinusArray()
        {
            double[] nums = new double[] { 130, 30, 20, 50 };

            double expectedResult = 30;

            double result = Program.Minus(nums);

            Assert.Equal(expectedResult, result, 4);
        }

        [Theory]
        [InlineData(50,4,12.5)]
        [InlineData(0,30,0)]
        [InlineData(175,31,5.6452)]
        [InlineData(2,5,0.4)]
        public void DivideTestExamples(double num1,double num2 ,double expected)
        {
            double result = Program.Dela(num1,num2);
            Assert.Equal(expected, result,4);

        }

        [Theory]
        [InlineData(-55,34,-89)]
        [InlineData(500,300,200)]
        [InlineData(45.65,2.345,43.305)]
        [InlineData(-0.456,0.123,-0.579)]
        public void MinusTestExamples(double num1, double num2, double expected)
        {
            double result = Program.Minus(num1,num2);

            Assert.Equal(expected, result);
        }



    }
}