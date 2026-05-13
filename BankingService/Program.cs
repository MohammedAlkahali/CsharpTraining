using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BankingService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            int accountNumber = 112233;

            string holderName = "Mohammed Alkahali";

            double balance = 1000.000;

            bool isActive = true;

            char accountType = 'A';

            bool isEmployed = true;

            double MonthlySalary = 350.000;

            int CreditScore = 0;

            int Age = 24;

            double deposit = 0.000;

            double withdrawal = 0.000;

            double annualRate = 0.000;

            double avgBalance = 0.000;




            Console.WriteLine("""
                        --- Account Profile ---
             1) Account Number (int) current: 0
             2) Holder Name (string) current: [not set]
             3) Balance (double) current: 0.000 OMR
             4) Account Active? (bool) current: false [enter 1=yes / 0=no]
             5) Account Type (char) current: - [enter S / C / F]

                        --- Customer Profile ---
             6) Employed? (bool) current: false [enter 1=yes / 0=no]
             7) Monthly Salary (double) current: 0.000 OMR
             8) Credit Score (int) current: 0
             9) Age (int) current: 0

                        --- Transaction Data ---
             10) Last Deposit Amount (double) current: 0.000 OMR
             11) Last Withdrawal (double) current: 0.000 OMR
             12) Annual Interest Rate (double) current: 0.000 OMR  [e.g. 0.035 = 3.5%]
             13) Avg Monthly Balance (double) current: 0.000 OMR

             0) Setup complete — launch Main Menu

             
             """);
            //int back = Convert.ToInt32(Console.ReadLine());
            Console.Write("Choose an Option: ");
            int setupMenu = Convert.ToInt32(Console.ReadLine());
            switch (setupMenu)
            {

                case 0:
                    Console.WriteLine("Setup complete. Launching Main Menu...");
                    break;

                case 1:
                    Console.WriteLine("enter account number: ");
                    accountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Account number :  {accountNumber}"); //I used $ to let me use the variable inside the WriteLine
                    break;

                case 2:
                    Console.WriteLine("enter holder name");
                    holderName = Console.ReadLine();
                    Console.WriteLine($"holder name :  {holderName}");
                    break;

                case 3:
                    Console.WriteLine("enter current balance");
                    balance = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"current balance :  {balance}");
                    break;

                case 4:
                    Console.WriteLine("enter 1=active / 0=inactive");
                    isActive = Convert.ToBoolean(Console.ReadLine());
                    Console.WriteLine($"account active :  {isActive}");
                    break;

                case 5:
                    Console.WriteLine("enter S / C / F");
                    accountType = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine($"account type :  {accountType}");
                    break;

                case 6:
                    Console.WriteLine("enter 1=employed / 0=not");
                    isEmployed = Convert.ToBoolean(Console.ReadLine());
                    Console.WriteLine($"Employee status :  {isEmployed}");
                    break;

                case 7:
                    Console.WriteLine("enter monthly salary");
                    MonthlySalary = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Salary :  {MonthlySalary}");
                    break;

                case 8:
                    Console.WriteLine("enter credit score");
                    CreditScore = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Credit score :  {CreditScore}");
                    break;

                case 9:
                    Console.WriteLine("enter customer age");
                    Age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Age :  {Age}");
                    break;

                case 10:
                    Console.WriteLine("enter last deposit amount");
                    deposit = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"deposit :  {deposit}");
                    break;

                case 11:
                    Console.WriteLine("enter last withdrawal");
                    withdrawal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"withdrawal :  {withdrawal}");
                    break;

                case 12:
                    Console.WriteLine("enter annual interest rate");
                    annualRate = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"annual rate :  {annualRate}");
                    break;

                case 13:
                    Console.WriteLine("enter avg monthly balance");
                    avgBalance = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Average :  {avgBalance}");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose 1–13 or 0 to finish.");
                    break;
            }

            //Task 2  
            //Display the name of the bank + Main menu
            Console.WriteLine("===NATIONAL BANK OF OMAN — Unified Banking System===");
            Console.WriteLine("===MAIN MENU===");
            Console.WriteLine("1) ATM Services");
            Console.WriteLine("2) Account Management - Available Soon");
            Console.WriteLine("3) Loan Services - Available Soon");
            Console.WriteLine("4) Currency Exchange - Available Soon");
            Console.WriteLine("5) Credit Card Portal - Available Soon");
            Console.WriteLine("6) Branch Services - Available Soon");
            Console.WriteLine("7) Reports & Admin - Available Soon");
            Console.WriteLine("8)[BONUS] Full Terminal - Available Soon");
            Console.WriteLine("0) Exit");

            Console.Write("Choose an Option: ");
            int MainMenuOption = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("=== ATM SERVICES ===");
            Console.WriteLine("1) ATM Welcome & Display");
            Console.WriteLine("2) Account Data Viewer");
            Console.WriteLine("3) ATM PIN Validation");
            Console.WriteLine("4) ATM Receipt Printer");

            Console.Write("Select A Service: ");
            int ATMserviceOption = Convert.ToInt32(Console.ReadLine());

            switch (ATMserviceOption)
            {

                case 1: //This case to show the menu when the customer select 1) ATM Welcome & Display
                    Console.WriteLine("=== SERVICES ===");
                    Console.WriteLine("1) Bank Info");
                    Console.WriteLine("2) Branch Info");
                    Console.WriteLine("3) Opening Hours");
                    Console.WriteLine("0) Back to Main Menu");
                    Console.Write("Select: ");
                    int ATMselection = Convert.ToInt32(Console.ReadLine());
                    switch (ATMselection)
                    {
                        //If the user choose number 1, it will desplay the information about the bank.
                        case 1:
                            Console.WriteLine("===NATIONAL BANK OF OMAN INFORMATION===");
                            Console.WriteLine("Bank Name: National Bank Of Oman");
                            Console.WriteLine("Tagline: Your trusted financial partner");
                            Console.WriteLine("founding year: 1973");
                            break;

                        //If the user choose number 2, it will display an information about the branch.
                        case 2:
                            Console.WriteLine("===BRANCH INFORMATION===");
                            Console.WriteLine("branch name: Sohar branch");
                            Console.WriteLine("city: Sohar");
                            Console.WriteLine("address: North Albatinah, Sohar");
                            break;

                        //If the user choose number 3, it will display the working hours of the bank.
                        case 3:
                            Console.WriteLine("===WORKING HOURS===");
                            Console.WriteLine("weekday hours : 8:00 AM - 2:00 pm");
                            Console.WriteLine("weekend hours: Closed");
                            break;

                        //If the user choose number 0, it display a returning to main menu.
                        case 0:
                            Console.WriteLine("Returning to Main Menu...");
                            break;

                        default:
                            Console.WriteLine("Invalid selection, Please try again.");
                            break;
                    }
                    break;

                    //This is task 3
                case 2: //This case to view the account data for a customer
                    Console.WriteLine("=== VIEW ACCOUNT DATA ===");
                    Console.WriteLine($"Account Number : {accountNumber}");
                    Console.WriteLine($"Holder Name : {holderName}");
                    Console.WriteLine($"Balance : {balance}");
                    Console.WriteLine($"Account Status : {isActive}");
                    Console.WriteLine($"Account Type : {accountType}");
                    break;


                    //This is for task 4
                case 3: //This case to show the menu to select from when the customer select 3) ATM PIN Validation
                    Console.WriteLine("=== AUTHENTICATION ===");
                    Console.WriteLine("1) Enter PIN");
                    Console.WriteLine("2) Forgot PIN");
                    Console.WriteLine("0) Back");
                    Console.Write("Select: ");
                    int AUTHselection = Convert.ToInt32(Console.ReadLine());
                    const int CORRECT_PIN = 4821, MAX_ATTEMPTS = 3; //Declare the correct PIN and the max attempt, and I used const so it can't be changed
                    switch (AUTHselection)
                    {
                        case 1:
                            Console.WriteLine("Enter PIN");
                            int PIN = Convert.ToInt32(Console.ReadLine());
                            if (PIN == CORRECT_PIN)  //If the PIN the customer enter is matching the correct PIN ,he will get a message
                            {
                                Console.WriteLine($"Access granted. Welcome, {holderName}");
                            }
                            else if (PIN != CORRECT_PIN) // This means if PIN is not equal to the correct PIN
                            {
                                Console.WriteLine("Incorrect PIN");
                            }
                            else
                            {
                                Console.WriteLine("Invalid PIN format");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Please visit the nearest branch with your National ID.");
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine("=== PRINT RECEIPT ===");
                    break;

                    default:
                    Console.WriteLine("Invalid option. ");
                    break;
            }

            
        }
    }
}