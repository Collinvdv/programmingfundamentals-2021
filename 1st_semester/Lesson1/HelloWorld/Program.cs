using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int intAge = Convert.ToInt32(age); //convert
            int year = DateTime.Now.Year - intAge;
            Console.WriteLine("Birth year: " + year);
        }
    }
}
