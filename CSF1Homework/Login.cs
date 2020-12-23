using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Login
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Login\n");

            bool isAdmin = false;
            int loginAttempts = 0;
            string password = "";
            string username = "";
            for (int i = 0; i < 3; i++)
            {
                if (loginAttempts < 3 && !isAdmin)//login attempts less than 3 AND isAdmin is equal to false
                {
                    Console.WriteLine("Enter username\n");
                    username = Console.ReadLine();
                }//end if
                if (username != "BEN")
                {
                    loginAttempts++;//add by 1 ea time through loop
                    //isAdmin = false;
                    Console.WriteLine("Wrong username\n");
                }//end if
                else
                {
                    isAdmin = true;//resetting the value of isAdmin so it won't go back into username if loop
                    if (loginAttempts < 3)
                    {
                        Console.WriteLine("Enter Password:\n");
                        password = Console.ReadLine();
                    }//end if
                    if (password != "Pass1")
                    {
                        loginAttempts++;
                        Console.WriteLine("Wrong password\n");
                    }//end if
                    else// else I now must equal Pass1
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
                Console.WriteLine("Login Successful");
            }//end else

        }//end Main()
    }//end class
}//end namespace
