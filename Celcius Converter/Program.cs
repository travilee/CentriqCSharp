using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Class: TempConverter.cs – Write a program that asks the user for a temperature in Celsius and converts it to Fahrenheit. The conversion is done by multiplying by 9.0/5.0 and then adding 32. (fah = cel * (9.0/5.0) +32). When testing your program, 100 degrees Celsius should be 212 degrees Fahrenheit.
 */

namespace Celcius_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a temperature in Celsius: ");
            double cTemp = double.Parse(Console.ReadLine());
            Console.WriteLine($"{cTemp} degrees Celsius is {(cTemp * 9.0 / 5.0) + 32} degrees Fahrenheit.");
        }
    }
}
