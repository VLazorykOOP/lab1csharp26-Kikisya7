using System;

class Task2Program
{
    static void Main()
    {
        // Вводимо число
        Console.WriteLine();
        Console.Write("Введите целое число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Перевіряємо, чи число непарне
        if (number % 2 != 0)
        {
            Console.WriteLine("Число непарное.");
        }
        else
        {
            Console.WriteLine("Число парное.");
        }
    }
}
