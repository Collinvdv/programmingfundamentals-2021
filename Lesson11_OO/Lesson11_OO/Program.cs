using System;

namespace Lesson11_OO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BankAccount kbc = new BankAccount();
            Console.WriteLine(kbc.Amount);
        }
    }
}
