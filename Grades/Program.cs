using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Class: GradesLoop.cs – Write a program that asks the user for scores and then displays the total number of scores, and the total number of scores given for each grade (A = 90+, B = 89-80, C = 70-79, D = 60-69, F = below 60). The program should stop asking for more scores when the user enters a negative score. For example: 

    Enter a score: 95 Enter a score: 81 Enter a score: 38 Enter a score: 91 Enter a score: 69 Enter a score: -1 
 
    The total number of grades is: 5. Number of A’s: 2 Number of B’s: 1 Number of C’s: 0 Number of D’s: 1 Number of F’s: 1 
 */

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double score = 0;
            int scoreTotal = 0;
            int aScores = 0;
            int bScores = 0;
            int cScores = 0;
            int dScores = 0;
            int fScores = 0;

            while (score >= 0)
            {
                Console.Write("Enter a score: ");
                score = double.Parse(Console.ReadLine());
                if (score >= 90)
                {
                    aScores++;
                    scoreTotal++;
                }
                else if (score >= 80)
                {
                    bScores++;
                    scoreTotal++;
                }
                else if (score >= 70)
                {
                    cScores++;
                    scoreTotal++;
                }
                else if (score >= 60)
                {
                    dScores++;
                    scoreTotal++;
                }
                else if (score >= 0)
                {
                    fScores++;
                    scoreTotal++;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"The total number of grades is: {scoreTotal}.\nNumber of As: {aScores}\nNumber of Bs: {bScores}\n Number of Cs: {cScores}\nNumber of Ds: {dScores}\nNumber of Fs: {fScores}");
                }
            }
        }
    }
}
