using System;

namespace Lesson5_Files
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double height = Convert.ToDouble(Console.ReadLine()); // 1.2
            double weight = Convert.ToDouble(Console.ReadLine()); // 90
            double bmi = weight / Math.Pow(height, 2);
            Console.WriteLine(bmi);
        }
    }
}
