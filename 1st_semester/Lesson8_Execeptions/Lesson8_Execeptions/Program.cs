using System;
using System.IO;

namespace Lesson8_Execeptions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // TryParse => false or true AND will save the value to a out variabe
            //Console.WriteLine("Give me a number");
            //string inputNumber = Console.ReadLine();
            //int number;

            //Boolean checkIfNumber = Int32.TryParse(inputNumber, out number);

            //while (checkIfNumber == false)
            //{
            //    inputNumber = Console.ReadLine();
            //    checkIfNumber = Int32.TryParse(inputNumber, out number);
            //}

            //int squareNumber = number * number;
            //Console.WriteLine(squareNumber);

            //try
            //{
                // try some code
                int inputNumber = Convert.ToInt32(Console.ReadLine());
                int result = inputNumber * inputNumber;

                Console.WriteLine(result);
            //}
            //catch (Exception e)
            //{
            //    // whenever an expection or a runtime is triggered go to catch
            //    Console.WriteLine(e.Message);
            //}

        }
    }
}
