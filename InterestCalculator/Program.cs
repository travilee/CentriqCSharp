using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Class: InterestCalc.cs – Write a program that asks the user for a beginning balance, interest rate, and a number of years. Print the amount of money they would have after the specified number of years if the money is compounded annually. For example: 
        Enter the beginning balance: 1000.0 
        Enter the interest rate: 0.05 
        Enter the number of years: 2 
        The amount you will have in 2 years is $1102.5
 */

namespace InterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the beginning balance: ");
            decimal begBal = decimal.Parse(Console.ReadLine());
            Console.Write("Enter the interest rate: ");
            decimal interest = decimal.Parse(Console.ReadLine());
            Console.Write("Enter the number of years: ");
            decimal years = decimal.Parse(Console.ReadLine());
            for (int i = 1; i <= years; i++)
            {
                begBal *= (1 + interest);
            }
            Console.WriteLine($"The amount you will have in {years} years is {begBal:c}");
        }
    }
}
