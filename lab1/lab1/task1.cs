using System;

class Task1Program
{
    static void Main1()
    {
        // Вводим координаты первой точки
        Console.Write("Введите a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        // Вводим координаты второй точки
        Console.Write("Введите c: ");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите d: ");
        double d = Convert.ToDouble(Console.ReadLine());

        // Вычисляем расстояние
        double distance = Math.Sqrt(Math.Pow(c - a, 2) + Math.Pow(d - b, 2));

        // Выводим результат
        Console.WriteLine("Расстояние между точками: " + distance);
    }
}