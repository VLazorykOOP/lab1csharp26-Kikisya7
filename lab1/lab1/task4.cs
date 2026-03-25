using System;

namespace Lab1
{
    public class Program  
    {
        // Точка входа программы
        public static void Main()
        {
            Console.WriteLine("Введіть номер масті (1-4):");
            
            int m;
            // Безопасный ввод числа
            if (!int.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("Неправильний ввід");
                return;
            }

            // Проверяем значение
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
