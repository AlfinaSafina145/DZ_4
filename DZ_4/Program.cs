using System;
namespace Task5_4
{
    class Program
    {
        public static int Factorial(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }
            return num * Factorial(num - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            long res = Factorial(n);
            Console.WriteLine($"Факториал {n} равен {res}");
        }
    }    
}

