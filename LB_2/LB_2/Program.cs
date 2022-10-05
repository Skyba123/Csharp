using System;

namespace LB_2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int nk, nn;
                double a = 1;
                bool res = false;
                do
                {
                    Console.WriteLine("nn: ");
                    res = int.TryParse(Console.ReadLine(), out nn);
                } while (nn <= 0 || !res);
                res = false;
                do
                {
                    Console.WriteLine("nk: ");
                    res = int.TryParse(Console.ReadLine(), out nk);
                } while (nk <= nn || !res);
                for (int k = nn; k < nk; k++)
                {
                    a *= (Math.Pow(-1, k*k+k+1) * Math.Pow(k,2) / (2 * Math.Pow(k, 2)+ 5));
                }
                Console.WriteLine("a = {0}", a);
            }
        }
    }
}

