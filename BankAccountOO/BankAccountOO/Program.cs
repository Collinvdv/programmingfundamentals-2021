using System;

namespace BankAccountOO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BankAccount bankaccount1 = new BankAccount("kbc", 5000);
            BankAccount bankaccount2 = new BankAccount("ing", 1000);
            BankAccount bankaccount3 = new BankAccount("fortis");

            BankAccount[] bankAccounts = new BankAccount[]{ bankaccount1, bankaccount2 };
            
            string command = GetCommando();

            while (command != "stop")
            {
                // execute command to bankaccount1
                BankAccount bankaccount = GetBankAccount(bankAccounts);

                // execute bankaccount
                bankaccount.AskCommand(command);

                // ask it again
                command = GetCommando();
            }
        }

        static string GetCommando()
        {
            Console.WriteLine("Commands are ADD, GET, STATUS");
            return Console.ReadLine().ToLower();
        }

        static BankAccount GetBankAccount(BankAccount[] bankAccounts)
        {
            Console.WriteLine("Give me the bank account that you want to change");
            string bankAccountName = Console.ReadLine(); // kbc

            foreach ( BankAccount bankAccount in bankAccounts)
            {
                if (bankAccount.Name == bankAccountName)
                {
                    return bankAccount;
                }
            }

            return null;
        }
    }
}


// bank account 1, name is "BE45 00 00 45 00", initial value is 5000
// bank account 2, name is "BE45 00 00 05 00", initial value is 1000