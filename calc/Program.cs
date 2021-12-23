using System;
using static System.Console;

namespace calc
{

    public static class Program
    {

        public static double num1, num2;
        public static double[] num3, num4, nums;
        public static void Main(string[] args)
        {
             
            bool run = true;
            while (run)
            {
                WriteLine(
                    "\n1. Plus            + \n" +
                    "\n2. Minus           - \n" +
                    "\n3. Multiplicera    * \n" +
                    "\n4. Dela upp        ÷ \n" +
                    "\n5. Array Tillägg   + \n" +
                    "\n6. Array Tillägg   - \n" +
                    "\n\n0. Stäng Programmet  \n"
                    );
                WriteLine("Välja en matematisk operation");
                int menue = Menue();
                Clear();
                WriteLine("\nAnge ett nummer");
                switch (menue)
                {
                    case 1:
                        num1 = GetNumber();
                        WriteLine(" +");
                        num2 = GetNumber();
                        Plus(num1,num2);
                        break;
                    case 2:
                        num1 = GetNumber();
                        WriteLine(" -");
                        num2 = GetNumber();
                        Minus(num1, num2);
                        break;
                    case 3:
                        num1 = GetNumber();
                        WriteLine(" *");
                        num2 = GetNumber();
                        Multi(num1, num2);
                        break;
                    case 4:
                        num1 = GetNumber();
                        WriteLine(" ÷");
                        num2 = GetNumber();
                        Dela(num1, num2);
                        break;
                    case 5:
                        Plus(new double[] {23,55,76,543,345});
                        break;
                    case 6:
                        Minus(new double[] {23, 55, 76, 543, 345 });
                        break;

                    case 0:
                        Clear();
                        WriteLine("\nVill du stänga programmet tryck y");
                        if (ReadLine() == "y") run = false;
                        break;
                }
                ReadLine();
                Clear();                
            }
            
        }

        public static int Menue()
        {
            bool check = int.TryParse(ReadLine(), out int input);
            return check && input > -1 && input < 7 ? input : Menue();
        }

        public static double GetNumber()
        {
            bool check = double.TryParse(ReadLine(), out double input);
            return check ? input : GetNumber();
        }

        public static double Plus(double num1,double num2)
        {
            WriteLine($"\n{num1} + {num2} = {num1 + num2}");
            return num1 + num2;
        }
        public static double Minus(double num1, double num2)
        {
            WriteLine($"\n{num1} - {num2} = {num1 - num2}");
            return num1 - num2;
        }
        public static double Multi(double num1, double num2)
        {
            WriteLine($"\n{num1} * {num2} = {num1 * num2}");
            return num1 * num2;
        }
        public static double Dela(double num1, double num2)
        {
            try
            {
                if (num2 != 0)
                    WriteLine($"\n{ num1 } ÷ { num2 } = { num1 / num2 }");
                else
                {
                    throw new DivideByZeroException("Can't Divide by zero ");
                }
                

            }
            catch(DivideByZeroException e)
            {
                WriteLine(e.Message);
            }
            return num1 / num2;
        }

        public static void Plus(double[] nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
                WriteLine($"\n{sum-nums[i]} + {nums[i]} = {sum}");
            }

        }
        public static void Minus(double[] nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum - nums[i];
                WriteLine($"\n{sum + nums[i]} - {nums[i]} = {sum}");
            }
        }

    }
}
