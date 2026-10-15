using System;
namespace Task5_3
{
    class Program
    {
        public static bool CalculateFactorial(int n, out long result)
        {
            result = 1;
            try
            {
                checked
                {
                    for (int i = 1; i <= n; i++)
                    {
                        result *= i;
                    }
                }
                return true;
            }
            catch (OverflowException)
            {
                result = 0;
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 3\nВведите число:");
            int num = int.Parse(Console.ReadLine());
            bool fact = CalculateFactorial(num, out long result);
            if (fact)
            {
                Console.WriteLine($"Факториал {num} равен {result}");
            }
            else
            {
                Console.WriteLine("Ошибка: Переполнение типа long!");
            }
        }
    }    
}

