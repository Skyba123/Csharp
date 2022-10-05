using System;

namespace LB__3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, x1, y1, x2, y2;
            bool res = true;
            Console.WriteLine("Введите координаты левой верхней вершины прямоугольника:");
            Console.WriteLine("x1:");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("y1:");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты правой нижней вершины прямоугольника:");
            Console.WriteLine("x2:");
            x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("y2:");
            y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите коорднаты точки:");
            Console.WriteLine("x:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("y:");
            y = int.Parse(Console.ReadLine());
            if ((x > x1) && (x < x2) && (y < y1) && (y > y2))
            {
                res = true;
                Console.WriteLine(res);
            } else
            {
                res = false;
                Console.WriteLine(res);
            }
        }
    }
}
