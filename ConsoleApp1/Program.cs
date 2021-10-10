using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to identify whether the output is even or odd

            int number = 0;
            Console.Write("Enter a number: ");
            string numberText = Console.ReadLine();

            number = int.Parse(numberText);


            if (number %  2 == 0)
            {
                Console.WriteLine($"Number {number} is even.");
            }
            else 
            {
                Console.WriteLine($"Number {number} is odd.");
            }
            
            
            
            Console.ReadLine();
        }
    }
}