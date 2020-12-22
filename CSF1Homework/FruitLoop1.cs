using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fruit Loop #1\n");

            //array built out of 6 fruits declared as a string(text)
            string[] fruits = { "Pomegranate", "Pear", "Peach", "Paw Paw", "Pinapple", "Papaya" };

            //for loop
            for (int i = 0; i < fruits.Length; i++)
            {
                string loopingFruit = fruits[i];
                Console.WriteLine("6 fruit names are: " + loopingFruit );
            }//end for

        }//end Main()
    }//end class
}//end namespace
