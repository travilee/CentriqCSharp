using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Counting Class: Counting1.cs
    1. Display numbers from 1 to 25 on the screen with a loop. 
    2. Display numbers from 25 to 1 on the screen with a loop. 
    3. Counting3: display numbers from 0  to 50 by 2’s with a loop. 
    4. Counting4: display numbers from  1 to 10 by 0.5 with a loop.*/

namespace Counting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Count from 1 to 25 with loop *****");
            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine("****** Count from 25 to 1 with loop *****");
            for (int i = 25; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine("****** Count from 0 to 50 with loop *****");
            for (int i = 0; i <= 50; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine("****** Count from 1 to 10 with loop *****");
            for (double i = 0; i <= 10; i += .5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}
