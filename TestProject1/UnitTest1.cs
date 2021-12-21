using calc;
using Xunit;

namespace Calc_Program_Test
{
    public class TestZeroDivision
    {
        [Fact]
        public void CheckDivision()
        {
            double num1 = 1;
            double num2 = 0;
            double expectedResult = 0;


            double result = Program.Dela(num1, num2);

            Assert.Equal(expectedResult, result);
        }
    }
}