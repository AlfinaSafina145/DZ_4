using System;
namespace Task5_1
{
    class Program
    {
        public static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int num2 = int.Parse(Console.ReadLine());
            int result = GetMax(num1, num2);
            Console.WriteLine($"Наибольшее число из {num1} и {num2} равно: {result}");
            Console.ReadKey();
        }
    }    
}

