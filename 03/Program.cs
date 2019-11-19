using System;

//Write a program that safely compares floating-point numbers with precision of 0.000001. 
//Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true


namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number:");
            float num1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter the second number:");
            float num2 = Convert.ToSingle(Console.ReadLine());

            bool equalChek = num1 == num2;

            Console.WriteLine("Are they equal? - "+ equalChek);
        }
    }
}
