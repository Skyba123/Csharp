using System;
using System.Linq;
namespace LB5
{
    class Program
    {
        //Дано число k і матриця розміру m *  n . Видалити рядок (стовпчик) матриці з номером k.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк(нажмите enter) и столбцов:\t");
            int[,] arr = new int[int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())];
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(20);
                }
            }
                    for (int i=0;i<arr.GetLength(0);i++)
            {
                for (int j=0;j<arr.GetLength(1);j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Выберите число из матрицы для удаления строки");
            int k = int.Parse(Console.ReadLine());
            int res = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (k == arr[i, j])
                    {
                        res = i;
                    }
                }
            }
            Console.WriteLine("Результат:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i != res)
                    {
                        Console.Write(arr[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
