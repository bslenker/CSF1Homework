using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Powers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Powers Lab");

            /*
             * Using a FOR loop, display the powers of 2 from 1 to 50.
             * (2 to the 1st power through 2 to the 50th power). Use a long variable to store your results.
             * Ex: 2 to the 4th power is 2x2x2x2.
             */
             

            for (double i = 1; i <= 50; i++)
            {
                
                long answer = (long)Math.Pow(i,2);
               
                Console.WriteLine(answer);
                
            }//end for

        }//end main
    }//end class
}//end namespace
