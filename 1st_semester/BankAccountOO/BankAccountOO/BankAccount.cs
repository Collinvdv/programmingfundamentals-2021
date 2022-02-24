using System;
namespace BankAccountOO
{
    public class BankAccount
    {
        // properties are data for you blueprint
        public string Name { get; }
        public double Balance { get; set; }

        // constructor
        public BankAccount(string bankAccountName, double bankAccountBalance)
        {
            Name = bankAccountName;
            Balance = bankAccountBalance;
        }

        public BankAccount(string bankAccountName)
        {
            Name = bankAccountName;
            Balance = 0;
        }

        // methods
        private void AddMoney()
        {
            double money = Convert.ToDouble(Console.ReadLine());
            Balance += money;

            GetStatus();
        }

        private void WithdrawMoney()
        {
            double money = Convert.ToDouble(Console.ReadLine());
            this.Balance -= money;

            GetStatus();
        }

        private void GetStatus()
        {
            Console.WriteLine($"Status of {Name} is {Balance} euro");
        }

        public void AskCommand(string command)
        {
            switch (command)
            {
                case "add":
                    AddMoney();
                    break;
                case "get":
                    WithdrawMoney();
                    break;
                case "status":
                    WithdrawMoney();
                    break;
            }
        }
    }
}
