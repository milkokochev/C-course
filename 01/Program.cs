using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort num1 = 52130;
            sbyte num2 = -115;
            int num3 = 4825932;
            byte num4 = 97;
            short num5 = -10000;

            Console.WriteLine(num1 + " = " + num1.GetType());
            Console.WriteLine(num2 + " = " + num2.GetType());
            Console.WriteLine(num3 + " = " + num3.GetType());
            Console.WriteLine(num4 + " = " + num4.GetType());
            Console.WriteLine(num5 + " = " + num5.GetType());
        }
    }
}
