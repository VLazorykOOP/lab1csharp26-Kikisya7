using System;

namespace Lab1
{
    public class Task_Suit
    {
        public static void Run()
        {
            Console.WriteLine("Введіть номер масті (1-4):");
            int m = int.Parse(Console.ReadLine());

            if (m == 1)
            {
                Console.WriteLine("піки");
            }
            else if (m == 2)
            {
                Console.WriteLine("трефи");
            }
            else if (m == 3)
            {
                Console.WriteLine("бубни");
            }
            else if (m == 4)
            {
                Console.WriteLine("черви");
            }
            else
            {
                Console.WriteLine("Неправильний номер");
            }
        }
    }
}