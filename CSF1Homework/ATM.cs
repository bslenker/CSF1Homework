using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ATM\n");


            //ask for user account number...

            bool isAdmin = false;
            int loginAttempts = 0;
            int pin = 0;
            string accountNumber = "";
            for (int i = 0; i < 3; i++)
            {
                if (loginAttempts < 3 && !isAdmin)//login attempts less than 3 AND isAdmin is equal to false
                {
                    Console.WriteLine("Please enter your account number: \n");
                    accountNumber = Console.ReadLine();
                }//end if
                if (accountNumber != "1234")
                {
                    loginAttempts++;//add by 1 ea time through loop
                    //isAdmin = false;
                    Console.WriteLine("Wrong account number entered...Please try again\n");
                }//end if
                else
                {
                    isAdmin = true;//resetting the value of isAdmin so it won't go back into username if loop
                    if (loginAttempts < 3)
                    {
                        Console.WriteLine("Please enter your PIN:\n");
                        pin = int.Parse(Console.ReadLine());
                    }//end if
                    if (pin != 1234)
                    {
                        loginAttempts++;
                        Console.WriteLine("Wrong PIN entered...Please try again.\n");
                    }//end if
                    else// else I now must equal the correct pin
                    {
                        break;//breaks out of the for loop
                    }//end else
                }//end else


            }//end for 
            if (loginAttempts > 2)//were login attempts greater than 2 = failure
            {
                Console.WriteLine("Login Failure");
            }//end if
            else
            {
                Console.WriteLine("\nLogin Successful");
                decimal balance = 0;
                bool repeat = true;//my counter for loop
                do
                {


                    //menu switch
                    Console.WriteLine("\nPlease choose an option from the menu:\n" +
                        "1) Deposit\n" +
                        "2) Withdrawal\n" +
                        "3) Balance\n" +
                        "4) Exit Menu\n");
                    string userOption = Console.ReadLine().ToUpper();

                    switch (userOption)
                    {
                        case "1":
                        case "D":
                        case "DEPOSIT":
                            Console.WriteLine("What is the amount you wish to deposit(do not use a $ sign): \n");
                           string userDeposit = Console.ReadLine();
                            decimal deposit = decimal.Parse(userDeposit);
                            balance = balance + deposit;
                            Console.WriteLine($"\nNew balance is: {balance:c} after deposit total of {deposit:c}");
                            break;
                        case "2":
                        case "WITHDRAWAL":
                        case "W":
                            Console.WriteLine("\nPlease make a withdrawal (Do not use a $ sign):");
                            decimal withdrawal = decimal.Parse(Console.ReadLine());
                            balance = balance - withdrawal;
                            Console.WriteLine($"\nYour balance is: { balance:c} after the withdrawal of { withdrawal:c}");
                            break;
                        case "3":
                        case "B":
                        case "BALANCE":
                            Console.WriteLine($"Your balance is: {balance:c}");
                            break;
                        case "4":
                        case "E":
                        case "EXIT":
                            Console.WriteLine("Thank you for using the ATM. Goodbye.");
                            repeat = false;//my loop update to exit program
                            break;
                        default:
                            Console.WriteLine("That was not an option. Please try a different option from the menu.");
                            break;

                    }//end switch
                } while (repeat);
            }//end else

           
        }//end Main()
    }//end class
}//end namespace
