using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            var numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };  // Create an int Array and populate numbers 1-10

            var evens = new List<int>();  // Create two Lists of type int.
            var odds = new List<int>();   // Name one List "evens"
                                          // Name the other List "odds"

            foreach(var evenNumbers in numbers)          // Using either a foreach or for loop,
            {                                            // nest an if statement to check to see
                if (evenNumbers %2==0)                   // if a number is even or odd.
                {                                        // Then add those numbers to either the evens List
                    evens.Add(evenNumbers);
                }
            }

            foreach(var oddNumbers in numbers)
            {
                if (oddNumbers % 2 == 1)
                {
                    odds.Add(oddNumbers);
                }
            }

           foreach(var allNumbers in evens)
            {
                Console.WriteLine($"The following number is even: {allNumbers}");   // Now using foeach or for loops,
            }                                                       // display each List of even and odd numbers

            foreach (var allNumbers in odds)                        // Try to be creative in your display
            {
                Console.WriteLine($"The following number is odd: {allNumbers}");
            }
        }
    }
}
