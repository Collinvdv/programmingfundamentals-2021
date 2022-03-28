using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson7_exception
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // array
            //int[] gradebook2 = new int[5];

            //gradebook2[0] = 10;
            //gradebook2[1] = 13;
            //gradebook2[2] = 15;
            //gradebook2[3] = 8;
            //gradebook2[4] = 6;

            List<int> gradebook = new List<int>();

            gradebook.Add(20);
            gradebook.Add(10); // .Add() -> add item as last item
            gradebook.Add(13);
            gradebook.Add(15);
            gradebook.Add(8);
            gradebook.Add(6);
            gradebook.Add(20);

            gradebook.Insert(1, 20); // .Insert(index, item) -> add item at specific location index

            gradebook.Remove(20); // .Remove(item) -> remove the first occurence of a list
            gradebook.RemoveAt(2); // .RemoveAt(item) -> remove an item at a specific item 

            //Console.WriteLine(String.Join(",",gradebook));

            //Console.WriteLine(gradebook.Contains(21));

            //Console.WriteLine(gradebook.IndexOf(20));
            //Console.WriteLine(gradebook.LastIndexOf(20));
            //Console.WriteLine(gradebook.Count);


            //// FOR LOOP for gradebook
            //for (int index = 0; index < gradebook.Count; index++) {
            //    Console.WriteLine(gradebook[index]);
            //}

            //// FOREACH for gradebook
            //foreach (int item in gradebook)
            //{
            //    Console.WriteLine(item);
            //}


            int[] gradebook2 = { 5, 3 };

            List<int> convertedGradebook2 = gradebook2.ToList();
            int[] gradebook2Converted = convertedGradebook2.ToArray();
            Console.WriteLine(String.Join(",", gradebook));

        }
    }
}
