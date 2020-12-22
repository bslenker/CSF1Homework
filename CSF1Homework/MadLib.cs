using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MadLib
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mad Lib\n");

            Console.WriteLine("Plase enter some information below to do this MAd Lib. Unless otherwise specificed, verbs should be in standard present tense <i.e. 'swim', 'run'>. Adverbs are words modifying verbs <like 'soon', or often ending in 'ly', like 'swiftly'>. Adjectives are words that describe nouns <like 'green' or 'descriptive'>\n");
            Console.Write("Enter a NOUN: \n");
            string noun = Console.ReadLine();
            Console.Write("Enter a VERB: \n");
            string verb = Console.ReadLine();
            Console.Write("Enter a ADJECTIVE: \n");
            string adjective = Console.ReadLine();
            Console.Write("Enter a VERB: \n");
            string verbA = Console.ReadLine();
            Console.Write("Enter a NOUN: \n");
            string nounA = Console.ReadLine();
            Console.Write("Enter a ADVERB: \n");
            string verbLy = Console.ReadLine();
            Console.Write("Enter a ADJECTIVE: \n");
            string adjectiveA = Console.ReadLine();
            Console.Write("Enter a ADJECTIVE: \n");
            string adjectiveB = Console.ReadLine();



            Console.WriteLine("\n");
            Console.WriteLine($"There are many kinds of {adjective} animals that {verb} on a farm. For example, {adjectiveA} goats, and {noun} spend their {adjectiveB} time being farm-raised.  Sometimes the {nounA} and other animals decide to go {verbLy}. The farmer sometimes likes to {verbA} with the {noun} before he quits for the day.");
        }//end Main()
    }//end class
}//end namespace
