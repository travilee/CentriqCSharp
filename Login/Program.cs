using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Class: Login1.cs –              
 * 1) Ask the user for their username              
 * 2) If it matches your one hard-coded, acceptable username, tell them they have access.              
 * 3) If not, tell them they have been denied access. 
 
Class: Login2.cs – 
1) Same as Login1, but use the other branching mechanism (switch if you were doing IF, or IF if you were doing a switch). 
2) What is the benefit of one vs. the other? 
 
Class: Login3.cs – 
1) Ask the user for their username 
2) Compare uppercase version to an uppercase version of the hard-coded username (because youre username security won’t be case-sensitive in this version). 
3) If it matches, tell them they have access.   
4) If not, tell them they have been denied access. 
 
Class: Login4.cs – 
1) Ask the user for their username. 
2) Ask the user for their password. 
3) Test their username input vs. your hard-coded username. 
    a) If their username matches your one hard-coded, acceptable username, then test to see if the password matches the hard-coded one. 
    b) If the username doesn't match, tell them no access.
4) Test their password input vs. your hard-coded password. 
    a) If the password test succeeds, tell them they get access. 
    b) If the password test fails, tell them no access. 
 
Class: Login5.cs – 
1. If username =  “Gary” then tell them they have access to lunch codes. 
    a. Later, add password requirement with password “P@ssw0rd” 
2. If username = "Administrator", then tell them they have access to launch codes. 
    a. Later, add password “fuzzybubbles” 
3. Set up username and password matching… If either fails, then “not granted access”. 
 */

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Login 1 *****");
            Console.Write("Enter your username: ");
            string userName = Console.ReadLine().ToLower();
            if (userName == "spongebob")
            {
                Console.WriteLine("You have access.");
            }
            else
            {
                Console.WriteLine("Access denied.");
            }
            Console.WriteLine();

            Console.WriteLine("***** Login 2 *****");
            Console.Write("Enter your username: ");
            userName = Console.ReadLine().ToLower();
            switch (userName)
            {
                case "spongebob":
                    Console.WriteLine("You have access.");
                    break;
                default:
                    Console.WriteLine("Access denied.");
                    break;
            }
            Console.WriteLine();

            Console.WriteLine("***** Login 3 *****");
            Console.Write("Enter your username: ");
            userName = Console.ReadLine().ToUpper();
            if (userName == "SPONGEBOB")
            {
                Console.WriteLine("You have access.");
            }
            else
            {
                Console.WriteLine("Access denied.");
            }
            Console.WriteLine();

            Console.WriteLine("***** Login 4 *****");
            Console.Write("Enter your username: ");
            userName = Console.ReadLine().ToLower();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
            if (userName == "spongebob" && password == "P@ssw0rd")
            { 
                Console.WriteLine("You have access.");
            }
            else
            {
                Console.WriteLine("Access denied.");
            }
            Console.WriteLine();

            Console.WriteLine("***** Login 5 *****");
            Console.Write("Enter your username: ");
            userName = Console.ReadLine().ToLower();
            Console.Write("Enter your password: ");
            password = Console.ReadLine();
            if (userName == "gary" && password == "P@ssw0rd")
            {
                Console.WriteLine("You have access to lunch codes.");
            }
            else if (userName == "administrator" && password=="fuzzybubbles")
            {
                Console.WriteLine("You have access to launch codes.");
            }
            else
            {
                Console.WriteLine("Access denied.");
            }
            Console.WriteLine();
        }
    }
}
