using System;

//Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 5;
            int secondNumber = 10;

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine();

            int thirdNimber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = thirdNimber;

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
        }
    }
}
