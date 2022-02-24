using System;

namespace BankAccount
{
    class MainClass
    {
        static double balance = 0;

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome in the bank!");
            string command = GetCommand();

            while (command != "stop")
            {
                ExecuteCommand(command);

                // Ask the command
                command = GetCommand();
            }
        }

        static void ExecuteCommand(string command)
        {
            switch (command)
            {
                case "get":
                    GetMoney();
                    break;
                case "add":
                    AddMoney();
                    break;
                case "add money":
                    AddMoney();
                    break;
                case "status":
                    GetStatus();
                    break;
            }
        }

        static void GetStatus()
        {
            Console.WriteLine($"Status of your account is {balance} euro");
        }

        static void AddMoney()
        {
            // ask for an input
            Console.WriteLine("How much cash do you want to add account?");
            double amount = Convert.ToDouble(Console.ReadLine()); // 1000

            // change your balance
            balance += amount;

            // output the current status
            GetStatus();
        }

        static void GetMoney()
        {
            // ask for an input
            Console.WriteLine("How much cash do you want to get from your account?");
            double amount = Convert.ToDouble(Console.ReadLine()); // 100

            // change your balance
            balance -= amount;

            // output the current status
            GetStatus();
        }

        static string GetCommand()
        {
            Console.WriteLine("COMMANDS: [STATUS, ADD, GET, STOP]");
            return Console.ReadLine().ToLower(); ;
        }
    }
}


//**Exercise1.1 * *

//Bankaccounts
//Balance = Start with 0
//Use methods!!
//COMMANDS: [STATUS, ADD, GET, STOP]

//// O: Welcome in the bank!
//// O: Commands [STATUS, ADD, GET]

//// I: ADD
//// O: How much cash do you want to add account?
//// I: 1000
//// O: Status of your account is 1000 euro

//// I: GET
//// O: How much cash do you get from your account ?
//// I: 100
//// I: Status of your account is 900 euro
///
//// I: STATUS
//// I: Status of your account is 900 euro