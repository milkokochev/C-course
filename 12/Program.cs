using System;
using System.Text;

//Find online more information about ASCII (American Standard Code for Information Interchange) 
//and write a program that prints the entire ASCII table of characters on the console.

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BufferHeight = 256;
            Console.OutputEncoding = Encoding.Unicode;

            for (int i = 0; i < 256; i++)
            {
                Console.Write((char)i);
            }
        }
    }
}
