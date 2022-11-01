using System;

namespace LB4
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 1, s = 0;
            Console.Write("Введите размер массива:\t");
            int N = int.Parse(Console.ReadLine());
            int[] MyArray = new int[N];
            Console.WriteLine("Введите значения:");
            MyArray[0] = int.Parse(Console.ReadLine());
            for (int i = 1; i < MyArray.Length; i++)
            {       
                s = int.Parse(Console.ReadLine());
                if (MyArray[j - 1] == s )
                {
                    continue;
                }
                MyArray[j++] = s;
                Console.WriteLine(s);
                if (MyArray[j] != MyArray[j - 1]) ;
            }
            Console.WriteLine("после изменений : ");
            for (int i = 0; i < j; i++) Console.Write(MyArray[i] + " ");
        }
    }
}

