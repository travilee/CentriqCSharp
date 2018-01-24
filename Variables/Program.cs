using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    #region Project Requirements
    /*
     * 1. Create a variable of type int and assign a value to it. Display the value of the variable
            a. Do the same for
                i. Char
                ii. String
                iii. Double
                iv. Float
                v. Byte
        2. Create an array of 5 ints and assign different values to each element. Write a for each loop to display all of the values in your array.
            a. Do the same for
                i. Char
                ii. String
                iii. Double
                iv. Float
                v. Byte
        3. Create a program that counts from 0 to 100 by 2’s (displaying onscreen) using a while loop.
            a. Do the same for
                i. A do while loop
                ii. A for loop
     */
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Declaring Variables *****");
            int x = 23;
            char c = 'x';
            string s = "Hello, World!";
            double d = 23.12;
            float f = 56.41f;
            byte b = 25;

            Console.WriteLine($"int variable: {x}\nchar variable: {c}\nstring variable: {s}\ndouble variable: {d}\nfloat variable: {f}\nbyte variable: {b}");
            Console.WriteLine();

            Console.WriteLine("***** Arrays ******");
            int[] iArray = { 1, 2, 3, 4, 5 };
            char[] cArray = { 'a', 'b', 'c', 'd', 'e' };
            string[] sArray = { "Hello, ", "my ", "name ", "is ", "Travis." };
            double[] dArray = { 1.23, 2.34, 3.45, 4.56, 5.67 };
            float[] fArray = { 6.78f, 7.89f, 8.90f, 9.01f, 10.12f };
            byte[] bArray = { 6,7,8,9,10 };
            Console.WriteLine("int Array:");
            foreach (int i in iArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine("char Array:");
            foreach (char ch in cArray)
            {
                Console.WriteLine(ch);
            }
            Console.WriteLine();

            Console.WriteLine("string Array:");
            foreach (string st in sArray)
            {
                Console.Write(st);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("double Array:");
            foreach (double dn in dArray)
            {
                Console.WriteLine(dn);
            }
            Console.WriteLine();

            Console.WriteLine("float Array:");
            foreach (float fl in fArray)
            {
                Console.WriteLine(fl);
            }
            Console.WriteLine();

            Console.WriteLine("byte Array:");
            foreach (byte by in bArray)
            {
                Console.WriteLine(by);
            }
            Console.WriteLine();

            Console.WriteLine("***** Counting ******");
            Console.WriteLine("Counting by 2s with a while loop:");
            int numb = 0;
            while (numb <= 100)
            {
                Console.Write(numb + " ");
                numb += 2;
            }
            Console.WriteLine("\n");

            Console.WriteLine("Counting by 2s with a do-while loop:");
            numb = 0;
            do
            {
                Console.Write(numb + " ");
                numb += 2;
            } while (numb <= 100);
            Console.WriteLine("\n");

            Console.WriteLine("Counting by 2s with a for loop:");
            for (numb = 0; numb <= 100; numb += 2)
            {
                Console.Write(numb + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
