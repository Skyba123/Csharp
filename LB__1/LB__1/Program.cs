using System;

namespace LB_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double h, v, g, t;
            g = 10;
            t = 0;
            Console.WriteLine("Введiть висоту(за системою SI):");
            string H = Console.ReadLine();
            h = Convert.ToInt32(H);
            Console.WriteLine("Введiть початкову швидкiсть(за системою SI):");
            string V = Console.ReadLine();
            v = Convert.ToInt32(V);
            t = (-v + Math.Sqrt(Math.Pow(v, 2) + 2 * g * h)) / g;
            double Hight = v * t + ((g * Math.Pow(t, 2)) / 2);
            Console.WriteLine("Time:" + t + "с");
            Console.WriteLine("Hight(перевiрка):" + Hight);
        }
    }
}

