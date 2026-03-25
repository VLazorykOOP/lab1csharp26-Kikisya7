using System;

namespace Lab1
{
    public class Task_Formula
    {
        public static void Run()
        {
            Console.WriteLine("Введіть n:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть m:");
            int m = int.Parse(Console.ReadLine());

            // Обчислення за формулою
            double result = (double)(n + 1) / (n * n + m * m + 1)
                            - 1.0 / ((m + 1) * (n + 1));

            Console.WriteLine("Результат: " + result);
        }
    }
}