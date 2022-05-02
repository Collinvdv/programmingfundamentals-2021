using System;

namespace lesson10_theory_part2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number1 = 25;

            Console.WriteLine(number1);
            Console.WriteLine(AddTen(number1));


            int[] numbers = { 1, 2, 3 };
            PrintList(numbers);
            ChangeSecondNumber(numbers);
            PrintList(numbers);



            int number2 = 25;
            Console.WriteLine(number2);
            AddFive(ref number2);
            Console.WriteLine(number2);
        }

        static void PrintList(int[] items)
        {
            Console.WriteLine(String.Join(",", items));
        }

        static void AddFive(ref int number)
        {
            number += 5;
        }

        static int AddTen(int number)
        {
            return number += 10;
        }

       static void ChangeSecondNumber(int[] numbersOriginal)
        {
            int[] numbersCopy = MakeCopy(numbersOriginal);

            numbersCopy[1] = 1000;
        }

        static int[] MakeCopy(int[] numbersOriginal)
        {
            int[] numbersCopy = new int[numbersOriginal.Length];

            for (int i = 0; i < numbersOriginal.Length; i++)
            {
                numbersCopy[i] = numbersOriginal[i];
            }

            return numbersCopy;
        }
    }
}
