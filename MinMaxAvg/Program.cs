using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Class: MinMaxAvg.cs – Write a program that asks the user for 5 numbers and outputs the lowest number, the highest number, and the average number. Be sure to test with a case where all numbers input are negative. 
 */

namespace MinMaxAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter number {i+1}:");
                numbers[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The smallest number you entered was: {numbers.Min()}");
            Console.WriteLine($"The highest number you entered was: {numbers.Max()}");
            Console.WriteLine($"The average of the numbers you entered was: {numbers.Average()}");
        }
    }
}
