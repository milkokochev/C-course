using System;

//Declare two string variables and assign them with following value:
//"The "use" of quotations causes difficulties."
//Do the above in two different ways: with and without using quoted strings

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "The \"use\" of quotations causes difficulties.";
            string secondString = @"The ""use"" of quotations causes difficulties.";

            Console.WriteLine(firstString);
            Console.WriteLine(secondString);
        }
    }
}
