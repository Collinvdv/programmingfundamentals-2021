using System;
using System.Collections.Generic;

namespace Lesson10
{
    class MainClass
    {
        static int[] numbers = { 4, 3, 5, 6, 8 };

        public static void Main(string[] args)
        {
            // loop over them print them out
            ListArray(numbers);

            // Sort them
            Console.WriteLine("Sorting magico");
            Array.Sort(numbers);

            // loop over them print them out
            ListArray(numbers);

            //
            Console.WriteLine("Seconds loop with a new array");
            int[] numbers2 = { 10, 5, 20 };
            ListArray(numbers2);

            double[] numbers3 = { 10.5, 5, 20 };
            ListArray(numbers3);
        }

        // listArray function, loop over a function and output it
        static void ListArray(int[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine($"{index} : {array[index]}");
            }
        }

        static void ListArray(double[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine($"{index} : {array[index]}");
            }
        }
    }
}













