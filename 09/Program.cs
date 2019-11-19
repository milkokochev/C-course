using System;

//Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
//Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.


namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            char simbol = '\u00A9';

            Console.WriteLine("  " + simbol + "  ");
            Console.WriteLine(" " + simbol + "" + simbol + "" + simbol) ;
            Console.WriteLine(simbol + "" + simbol + "" + simbol + "" + simbol + "" + simbol);
        }
    }
}
