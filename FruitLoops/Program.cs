using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//FruitLoops 
//Class: FruitLoop1.cs – Declare, and initialize an array of fruit names. Set up a standard WHILE loop and iterate through them (displaying each value in the console.) 
//Class: FruitLoop2.cs – Repeat the previous exercise to use a FOR loop.
//Class: FruitLoop3.cs – Repeat the previous exercise with the FOR loop, but for each of the fruit names that you display above, display on the next line a number of periods that is equal to the number of the index of the array.

namespace FruitLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** FruitLoop1 - While Loop *****");
            string[] fruits = { "banana", "cherry", "pineapple", "grape", "apple", "orange", "kiwi" };
            int i = 0;
            while (i < fruits.Length)
            {
                Console.WriteLine(fruits[i]);
                i++;
            }
            Console.WriteLine();

            Console.WriteLine("****** FruitLoop2 - For Loop *****");
            for (i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }
            Console.WriteLine();

            Console.WriteLine("****** FruitLoop3 - For Loop With Dots *****");
            
            for (i = 0; i < fruits.Length; i++)
            {
                string dots = "";
                for (int d = 1; d <= i; d++)
                {
                    dots += ". "; 
                }
                Console.WriteLine(fruits[i]);
                Console.WriteLine(dots);
            }
            Console.WriteLine();
        }


    }
}
