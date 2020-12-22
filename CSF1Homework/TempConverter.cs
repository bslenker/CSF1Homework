using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class TempConverter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter\n");

            //Console.Write("Please enter the temperature in Celsius: ");
            //double celC = double.Parse(Console.ReadLine());
            //double fahC = celC * (9.0 / 5.0) + 32;
            //Console.WriteLine("The temperature is: " + fahC + "\u00B0F." + "\n");

            //Console.Write("Please enter the temperature in Fahrenheit: ");
            //double fahF = double.Parse(Console.ReadLine());
            //double celF = (fahF - 32) / (9.0 / 5.0);
            //Console.WriteLine("The temperature is: " + celF + "\u00B0C." + "\n");
            
            
            

            bool repeat = true;
            do
            {
                Console.WriteLine("Please select Celsius or Fahrenheit converter:");
                Console.WriteLine("C) Celsius\n" +
                    "F) Fahrenheit\n" +
                    "X) Exit\n");
                string userChoice = Console.ReadLine().ToUpper();

                Console.Clear();

                switch(userChoice)
                {
                    case "C":
                    case "Celsius":
                        Console.Write("Please enter the temperature in Celsius: ");
                        double celC = double.Parse(Console.ReadLine());
                        double fahC = celC * (9.0 / 5.0) + 32;
                        Console.WriteLine("The temperature is: " + fahC + "\u00B0F." + "\n");
                        break;
                    case "F":
                    case "FAHRENHEIT":
                        Console.Write("Please enter the temperature in Fahrenheit: ");
                        double fahF = double.Parse(Console.ReadLine());
                        double celF = (fahF - 32) / (9.0 / 5.0);
                        Console.WriteLine("The temperature is: " + celF + "\u00B0C." + "\n");
                        break;
                    case "X":
                    case "EXIT":
                    case "E":
                        Console.WriteLine("Thank you for using our temperature converter! Have nice day!");
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("That was not a valid option, please try again...\n");
                        break;
                }//end switch

            } while (repeat);
        }//end Main()
    }//end class
}//end namespace
