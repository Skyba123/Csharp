using System;



// Лаба з С++

//1.Запропонуйте користувачеві ввести три числа та знайдіть максимальне.
//2. Запропонуйте користувачеві ввести три числа та знайдіть середнє між ними. 
//Наприклад, для чисел 12, 55, 27 середнім за значенням число є 27.
//3. Ніхто не любить платити податки, але ми зобsов’язані.
//На товар, вартістю до 999 грн. включно – податок 2%.
//Від 1000 грн. до 9999 грн. включно – податок 3%.
//Все, що більше 10000 грн., податок – 5%.
//Необхідно розрахувати суму податку в залежності від вартості.
//4. Напишіть програму для обчислення наступного виразу:
//𝑦 = 6𝑥 − 9, якщо 𝑥 > 0,
//𝑦 = 0, якщо 𝑥 = 0,
//𝑦 = 2 |𝑥| − 1, якщо 𝑥 < 0.
//5.Трикутник існує тільки тоді, коли сума будь-яких двох його сторін більша від 
//третьої. За трьома сторонами a, b і c дізнайтеся, чи існує такий трикутник.
//Наприклад, a = 2, b = 5, c = 6 → true.
// a = 2, b = 5, c = 7 → false.
namespace LB__0
{
	class Program
	{
		
		static void Main(string[] args)
		{
            // ex1
            int x, y, z;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            if (x > y && x > z)
            {
                Console.WriteLine(x);
            }
            else if (y > x && y > z)
            {
                Console.WriteLine(y);
            }
            else if (z > x && z > y)
            {
                Console.WriteLine(z);
            }
            //ex 2
            int x = 12;
            int y = 55;
            int z = 27;
            if (y < x && x < z)
            {
                Console.WriteLine(x);
            }
            else if (z < x && x < y)
            {
                Console.WriteLine(x);
            }
            else if (x < y && y < z)
            {
                Console.WriteLine(y);
            }
            else if (z < y && y < x)
            {
                Console.WriteLine(y);
            }
            else if (x < z && z < y)
            {
                Console.WriteLine(z);
            }
            else if (y < z && z < x)
            {
                Console.WriteLine(z);
            }
            //ex 3
            int n;
            n = int.Parse(Console.ReadLine());

            if (n <= 999)
            {
                Console.WriteLine(n * 0.02);
            }
            else if (n >= 1000 && n <= 9999)
            {
                Console.WriteLine(n * 0.03);
            }
            else if (n >= 10000)
            {
                Console.WriteLine(n * 0.02);
            }
            //ex 4
            int y, x;
            x = int.Parse(Console.ReadLine());
            if (x > 0)
            {
                y = 6 * x - 9;
                Console.WriteLine(y);
            }
            else if (x == 0)
            {
                y = 0;
                int res = y = 6 * x - 9;
                Console.WriteLine(y);
            }
            else if (x < 0)
            {
                y = 2 * Math.Abs(x) - 1;
                Console.WriteLine(y);
            }
            //ex 5
            int x = 2;
            int y = 5;
            int z = 6;
            if (x + y > z)
            {
                Console.WriteLine("True");
            }
            if (x + y < z)
            {
                Console.WriteLine("False");
            }
            if (x + z > y)
            {
                Console.WriteLine("True");
                if (x + z < y)
                {
                    Console.WriteLine("True");
                    if (z + y > x)
                    {
                        Console.WriteLine("True");
                        if (z + y < x)
                        {
                            Console.WriteLine("True");
                        }
                    }
                }
            }
        }
    }
}
