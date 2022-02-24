// include all of the object of the system of c#
using System;

namespace lesson1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // declare a new variable with the name firstName
            Console.WriteLine("Can you give me the firstname:");
            string firstName = Console.ReadLine();    // ask the user for the firstname
            Console.WriteLine("Can you give me the lastname:");
            string lastName = Console.ReadLine();
            string fullName = firstName + " \"The great\" "+ lastName; // we use + to concetanate strings (concat = combination of text )
            int age = 30;

            // c# is case sensitive + end everyline of code with ; 
            Console.WriteLine(fullName + " is " + age + " years old");

        }
    }
}


