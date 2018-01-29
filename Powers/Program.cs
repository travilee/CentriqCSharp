using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Class: Powers.cs – Use a FOR loop to display the powers of 2 from 1 to 50. (2 to the 1st power through 2 to the 50th power). Use a long variable to store your results and do not use methods from the Math class.
 */

namespace Powers
{
    class Program
    {
        static void Main(string[] args)
        {
            long result = 1;
            for (long i = 1; i <= 50; i++)
            {
                result *= 2;
                Console.WriteLine(result);
            }
        }
    }
}
