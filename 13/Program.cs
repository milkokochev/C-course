using System;

//Create a program that assigns null values to an integer and to double variables.
//Try to print them on the console, try to add some values or the null literal to them and see the result.


namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
           //Nullable<int> intNum = null;
           //Nullable<double> doubleNum = null;

           int? intNum = null;
           double? doubleNum = null;

           intNum = intNum + 5;
           doubleNum += 0.5;

            //intNum += null;
           //doubleNum += null;

            Console.WriteLine(intNum + "; " + doubleNum);
        }
    }
}
