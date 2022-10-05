using System;

namespace LB_2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int nk, nn;
                bool res = false;
                double a = 0;
                do
                {
                    Console.WriteLine("nn:");
                    res = int.TryParse(Console.ReadLine(), out nn);
                } while (nn <= 0 );
                res = false;
                do{
                    Console.WriteLine("nk:");
                    res = int.TryParse(Console.ReadLine(), out nk);
                } while (nk <= nn );
                for (int k = nn; k < nk; k++){
                    a += (Math.Pow(-1, k*k+k+1) * Math.Pow(k,2) / (2 * Math.Pow(k, 2)+ 5));
                }
                Console.WriteLine("a = {0}", a);
            }
        }
    }
}

