using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Project Requirements: 
/*WATER LAB INSTRUCTIONS:

Write a program that will:

- Assume that a gallon of water weighs 8.33 pounds
- Prompt the user to enter a number of gallons
- Display the total weight of the water in pounds

* Test with something simple like 2 to start
* */

namespace WaterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an amount of water in gallons to convert to pounds: ");
            decimal waterGallons = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"{waterGallons} gallons of water weighs {waterGallons * 8.33m} pounds.");
        }
    }
}
