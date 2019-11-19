using System;

//Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isFemale = new bool();

            Console.Write("Are you a female?:");

            string answer = Console.ReadLine();

            if (answer == "yes" | answer == "YES" | answer == "Yes")
                isFemale = true;

            Console.WriteLine(isFemale);
        }
    }
}
