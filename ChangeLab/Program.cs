using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#region Instructions
/*
 * CHANGE LAB INSTRUCTIONS:

Write a program that will:

- Prompt the user to enter an amount of dollars and cents. For example 1.18
- Display the number of quarters, dimes, nickels, and pennies to make that amount

Ex. If they entered 1.18 it should say:
4 quarters, 1 dimes, 1 nickels, 3 pennies

Ex. If they entered 1.02 it should say:
4 quarters, 0 dimes, 0 nickels, 2 pennies
 */
#endregion

namespace ChangeLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an amount of money, including dollars and cents separated by a decimal point: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            int pennies =  (int)(amount * 100);
            int quarters = pennies / 25;
            pennies %= 25;
            int dimes = pennies / 10;
            pennies %= 10;
            int nickels = pennies / 5;
            pennies %= 5;

            Console.WriteLine($"From {amount:c}, you will have:\n{quarters} quarters, \n{dimes} dimes, \n{nickels} nickels and \n{pennies} pennies");
        }
    }
}
