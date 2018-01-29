using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Class: MadLib1.cs – Create a “mad lib” that asks the user for various strings that you will then use to “output” a story.
 */

namespace MadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some information below to do this Mad Lib.\nUnless otherwise specified, verbs should be in the standard present tense (i.e. 'swim', 'run').\nAdverbs are words modifying verbs (like 'soon', or often ending in 'ly', like 'swiftly'.\nAdjectives are words that describe nouns (like 'green' or 'descriptive'.");
            Console.WriteLine();
            Console.Write("Noun: ");
            string noun1 = Console.ReadLine();
            Console.Write("Verb: ");
            string verb1 = Console.ReadLine();
            Console.Write("Adjective: ");
            string adjective1 = Console.ReadLine();
            Console.Write("Noun: ");
            string noun2 = Console.ReadLine();
            Console.Write("Verb ending in '-ing': ");
            string verbing = Console.ReadLine();
            Console.Write("Adjective: ");
            string adjective2 = Console.ReadLine();
            Console.Write("Adverb: ");
            string adverb = Console.ReadLine();
            Console.Write("Exclamation: ");
            string exclamation = Console.ReadLine();
            Console.Write("City: ");
            string city = Console.ReadLine();
            Console.Write("A Time: ");
            string time = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"One day there was a {noun1} that didn't want to {verb1} anymore.\nAnd so, like any good {adjective1} {noun2}, the {noun1} decided to go {verbing}.\nBut sometimes the universe is a {adjective2} mistress, and destiny {adverb} called.\nAfter that, the {noun1} exclaimed '{exclamation}', and they heard it all the way in {city}!\nAnd the {noun1} vowed not to return until {time}.");
        }
    }
}
