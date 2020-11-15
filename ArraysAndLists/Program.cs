using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 , 9, 10 };
   
            List<int> evens = new List<int>();
            var odds = new List<int>();

          
            for (int x = 0; x < numbers.Length; x++)
            {
                if (numbers [x] % 2 == 0)
                {
                    
                    evens.Add(numbers [x]);
                   Console.WriteLine(x);
                }
                else
                {
                    
                    odds.Add(numbers[x]);
                   Console.WriteLine(x);
                }
                foreach (var number in evens)
                {
                    Console.WriteLine($"Even numbers");
                    Console.WriteLine($" ");
                    Console.WriteLine($"{number}");
                  
                    }
                    foreach (var number in odds)
                    {
                    {
                        Console.WriteLine($"Odd numbers");
                        Console.WriteLine($" ");
                        Console.WriteLine($"{number}");
                       
                        
                    }

                }










                /* Now using foreach or for loops,
                 * display each List of even and odd numbers
                 *
                 * Try to be creative in your display

                 */


            }


           
        }
    }
}
