using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fruit Loop #2\n");

            //array built out of 6 fruits declared as a string(text)
            string[] fruits = { "Pomegranate", "Pear", "Peach", "Paw Paw", "Pinapple", "Papaya", };
            //array built for the dots
            string[] dots = { ".", "..", "...", "....", ".....", "......" };


            //for loop
            for (int timesRan = 0; timesRan < fruits.Length; timesRan++)// timesRan is # of times ran through a loop, fruits.length = the lenth of the array
            {

                string loopingFruit = fruits[timesRan];
                Console.WriteLine("Fruits starting with a P: {0},\n{1} ", fruits[timesRan], dots[timesRan]);//outputing fruits through the loop {0}, with a return inbetween dots output.
                
            }//end for
        }//end Main()
    }//end class
}//end namespace
