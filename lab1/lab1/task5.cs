using System;

namespace Lab1
{
    public class Task_Multiply
    {
        // Функція обчислення добутку двох цілих чисел
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static void Run()
        {
            Console.WriteLine("Введіть перше число:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть друге число:");
            int b = int.Parse(Console.ReadLine());

            int result = Multiply(a, b);

            Console.WriteLine("Добуток: " + result);
        }
    }
}