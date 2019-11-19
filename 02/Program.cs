using System;
//Which of the following values can be assigned to a variable of type float and which to a variable 
//of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 34.567839023;
            float num2 = 12.345f;
            double num3 = 8923.1234857;
            double num4 = 3456.091;
                       
            Console.WriteLine(num1 + " = " + num1.GetType());
            Console.WriteLine(num2 + " = " + num2.GetType());
            Console.WriteLine(num3 + " = " + num3.GetType());
            Console.WriteLine(num4 + " = " + num4.GetType());
        }
    }
}
