using System;

namespace Lab1
{
    public class Program
    {
        public static void Main()  
        {
            Run();
        }

        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("Введіть координату x:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть координату y:");
            double y = double.Parse(Console.ReadLine());

            double d2 = x * x + y * y;

            bool onOuterSemicircle = (d2 == 100 && y >= 0);
            bool onInnerSemicircle = (d2 == 25 && y >= 0);
            bool onBottomStraightEdges = (y == 0 && d2 >= 25 && d2 <= 100);

            if (onOuterSemicircle || onInnerSemicircle || onBottomStraightEdges)
            {
                Console.WriteLine("На межі");
            }
            else if (d2 > 25 && d2 < 100 && y > 0)
            {
                Console.WriteLine("Так");
            }
            else
            {
                Console.WriteLine("Ні");
            }
        }
    }
}
