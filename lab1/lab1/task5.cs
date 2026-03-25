using System;

namespace Lab1
{
    public class Program  // Класс Program вместо Main
    {
        // Функція обчислення добутку двох цілих чисел
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        // Точка входу програми
        public static void Main()
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
