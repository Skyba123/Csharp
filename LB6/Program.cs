using System;

namespace LB6
{
    class Program
    {

        static void Main(string[] args)
        {
            string letter = Console.ReadLine();
            int res;
            bool succes = int.TryParse(letter, out res);
             if (succes)
            {
                int number = int.Parse(letter);
                Reverse(number);
            }
            else 
            {
                Reverse(letter);
            }
            Console.WriteLine("Количество элементов массива:\t");
            int elements = int.Parse(Console.ReadLine());
            int[] arr = new int[elements];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"\nЭлемент массива под индексом {i}:\t");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Результат:\t");
            ReverseArray(arr);
            Console.WriteLine(new string ('*',30));
            Resize(ref arr, 10);
            var str = string.Join(" ", arr);
            Console.WriteLine(str);
            
        }
        static void Reverse(int value)
        {
            string values = value.ToString();
            char[] number = values.ToCharArray();
            Array.Reverse(number);
            Console.WriteLine(number);
        }
        static void Reverse(string value)
        {
            char[] letter = value.ToCharArray();
            Array.Reverse(letter);
            Console.WriteLine(letter);
        }
        static void ReverseArray(int[] arrs)
        {
 
            for (int i = arrs.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arrs[i]);
            }
        }
        static void Resize(ref int [] array, int newSize)
        {
            int[] newArr = new int[newSize];
            for (int i=0;i<array.Length && i< newArr.Length;i++)
            {
                newArr[i] = array[i];
                
            }
            array = newArr;
            
        }
    }
}
