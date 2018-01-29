using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Class: ATM.cs – 
 * 1. Write a program that will: 
 *      a. Ask the user to enter an account number for their account 
 *          i. Continue to ask the user for this number until they get it right (the correct account number will be hard coded in your code. See Login section for an example). You can also lock them out after a certain number of failures. 
 *      b. Once they get the correct account number, ask them for a pin number. Just as you did for their account number, continue to prompt the user for their pin until they get it correct. (The correct value will be hard coded just as it was for the account number) 
 *      c. Once the user has successfully given their account and pin number, ask them if they want to do a deposit, a withdraw, or exit. 
 *      d. If they choose to do a deposit, ask them for the amount to deposit, and display the amount deposited. 
 *          i. “$500.00 has been deposited into account number 12345” for example. 
 *      e. If they choose to withdraw money, ask them for the amount to withdraw. 
 *          i.  Then display “$500.00 has been withdrawn from account number 12345” for example. 
 *      f. After each transaction, ask the user again if they want to do a deposit, withdraw, or exit. 
 *      g. Thank the user for their business when they choose exit. 
 
Additional Optional Features:  
- Keep a running tally of the account balance, assuming that the account starts at $0. 
- Every time they deposit or withdraw from the account, the balance should be updated and displayed.  
- Add a feature where the user can also make a balance request to display their current balance without making a deposit or withdrawal. 
 */

namespace ATMApplication
{
    class ATM
    {
        static void Main(string[] args)
        {
            bool needAccount = true;
            bool moveToPin = false;
            bool moveToMenu = false;
            bool isLockedOut = false;
            string account;

            if (needAccount)
            {
                for (int attempt = 1; attempt <= 5; attempt++)
                {
                    Console.Write("Enter your account number: ");
                    account = Console.ReadLine();

                    if (account == "1234")
                    {
                        needAccount = false;
                        moveToPin = true;
                        attempt = 6;
                    }

                    else
                    {
                        if (attempt < 5)
                        {
                            Console.WriteLine("Incorrect account number. You may try {0} more times.",
                            5 - attempt);
                        }
                        else
                        {
                            needAccount = false;
                            isLockedOut = true;
                        }
                    }
                }
            }//end if needAccount

            if (moveToPin)
            {
                for (int attempt = 1; attempt <= 5; attempt++)
                {
                    Console.Write("Enter your PIN number: ");
                    string pin = Console.ReadLine();

                    if (pin == "1234")
                    {
                        moveToPin = false;
                        moveToMenu = true;
                        attempt = 6;
                    }

                    else
                    {
                        if (attempt < 5)
                        {
                            Console.WriteLine("Incorrect PIN number. You may try {0} more times.",
                            5 - attempt);
                        }
                        else
                        {
                            moveToPin = false;
                            isLockedOut = true;
                        }
                    }
                }
            }//end if moveToPin

            if (isLockedOut)
            {
                Console.WriteLine("You have been locked out.");
            }//end if isLockedOut

            if (moveToMenu)
            {
                Console.Clear();
                bool cont = true;
                bool displayMenu = true;
                decimal balance = 0.00m;

                while (cont)
                {
                    if (displayMenu)
                    {
                        Console.WriteLine("\nWelcome to the Best Bank Ever!\n\n" +
                            "Choose an option: \n" +
                            "(B) Balance\n" +
                            "(D) Deposit\n" +
                            "(W) Withdrawal\n" +
                            "(X) Exit\n" +
                            "\nYour Choice: ");
                        string choice = Console.ReadLine().ToUpper();
                        Console.Clear();

                        switch (choice)
                        {
                            case "B":
                                Console.WriteLine("Your balance is: {0:c}.", balance);
                                break;
                            case "D":
                                Console.Write("Enter deposit amount: ");
                                decimal deposit = decimal.Parse(Console.ReadLine());
                                balance += deposit;
                                Console.WriteLine("You have deposited {0:c} into your account. " +
                                    "Your balance is now {1:c}.",
                                    deposit, balance);
                                break;
                            case "W":
                                Console.Write("Enter withdrawal amount: ");
                                decimal withdrawal = decimal.Parse(Console.ReadLine());
                                if (balance < withdrawal)
                                {
                                    Console.WriteLine("Insufficient funds.");
                                }
                                else
                                {
                                    balance -= withdrawal;
                                    Console.WriteLine("You have withdrawn {0:c} from your account. " +
                                        "Your balance is now {1:c}.", withdrawal, balance);
                                }
                                break;
                            case "X":
                            case "E":
                                Console.WriteLine("Thank you for banking with us. Have a great day!");
                                displayMenu = false;
                                cont = false;
                                break;
                            default:
                                Console.WriteLine("Invalid Choice.");
                                break;
                        }
                    }
                }
            }//end if moveToMenu
        }//end Main()
    }//end class ATM
}//end namespace
