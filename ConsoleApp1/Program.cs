using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********RH BANK************");
            Console.WriteLine("Login Page");

            string userName = null;
            string password = null;

            Console.WriteLine("Username");
            userName = Console.ReadLine();

            if (userName != "")
            {
                Console.WriteLine("Password");
                password = Console.ReadLine();
            }

            if (userName == "system" && password == "manager")
            {
                int mainMenyChoice = -1;

                do
                {

                    Console.WriteLine("1.Customers");
                    Console.WriteLine("2.Accounts");
                    Console.WriteLine("3.Founds Transfer");
                    Console.WriteLine("4. Funds Transfer Statement");
                    Console.WriteLine("5.Account Statement");
                    Console.WriteLine("0.Exit");

                    Console.WriteLine("Enter choice");
                    mainMenyChoice = int.Parse(Console.ReadLine());

                    switch (mainMenyChoice)
                    {
                        case 1:
                            customersMenue();
                            break;
                        case 2:
                            accountMenu();
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                    }
                } while (mainMenyChoice != 0);

            }
            else
            {
                Console.WriteLine("Invalid choice");
            }


        }


        static void customersMenue()
        {
            int coustomerMenuChoice = -1;
            do
            {
                Console.WriteLine("1.Add Customer");
                Console.WriteLine("2.Delete Customer");
                Console.WriteLine("3.Update Customer");
                Console.WriteLine("4. View Customer");
                Console.WriteLine("0.Exit Back to main menu");

                Console.WriteLine("Enter choice");
                coustomerMenuChoice = Convert.ToInt32(Console.ReadLine());


            } while (coustomerMenuChoice != 0);
        }

        static void accountMenu()
        {
            int accountMenuChoice = -1;
            do
            {
                Console.WriteLine("1.Add Account");
                Console.WriteLine("2.Delete Account");
                Console.WriteLine("3.Update Account");
                Console.WriteLine("4. View Account");
                Console.WriteLine("0.Exit Back to main menu");

                Console.WriteLine("Enter choice");
                accountMenuChoice = Convert.ToInt32(Console.ReadLine());

            } while (accountMenuChoice != 0);
        }




    }


}
