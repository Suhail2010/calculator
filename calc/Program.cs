using System;
using static System.Console;

namespace calc
{
   
    class Program
    { 
        static double num1, num2;
        static void Main(string[] args)
        {
             
            bool run = true;
            while (run)
            {
                WriteLine(
                    "1. Plus            + \n" +
                    "2. Minus           - \n" +
                    "3. Multiplicera    * \n" +
                    "4. Dela upp        ÷ \n" +
                    "0. Stäng Programmet  \n"
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
                    case 0:
                        Clear();
                        WriteLine("\nVill du stänga programmet tryck y");
                        if (ReadLine() == "y") run = false;
                        break;
                }
                Clear();                
            }
            
        }

        static int Menue()
        {
            bool check = int.TryParse(ReadLine(), out int input);
            return check && input > -1 && input < 5 ? input : Menue();
        }

        static double GetNumber()
        {
            bool check = double.TryParse(ReadLine(), out double input);
            return check ? input : GetNumber();
        }

        static void Plus(double num1,double num2)
        {
            WriteLine($"\n{num1} + {num2} = {num1 + num2}");
            ReadLine();
        }
        static void Minus(double num1, double num2)
        {
            WriteLine($"\n{num1} - {num2} = {num1 - num2}");
            ReadLine();
        }
        static void Multi(double num1, double num2)
        {
            WriteLine($"\n{num1} * {num2} = {num1 * num2}");
            ReadLine();
        }
        static void Dela(double num1, double num2)
        {
            if (num2 != 0)
                WriteLine($"\n{ num1 } ÷ { num2 } = { num1 / num2 }");
            else
            {
                WriteLine("Error Divide by zero "); 
            }
            ReadLine();
        }
    }
}
