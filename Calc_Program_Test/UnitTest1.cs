using Microsoft.VisualStudio.TestPlatform.TestHost;
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
            string errorMessage = "Divide By Zero Error";

            double result = Program.Dela(num1, num2)
            {

            }

        }
    }
}
