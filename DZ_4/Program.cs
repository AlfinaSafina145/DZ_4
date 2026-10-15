using System;
namespace TaskDZ2
{
    class Program
    {
        public static int Fibonachi(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Дз 2");
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Ряд Фибоначчи: ");
            for (int i = 1; i <= num; i++)
            {
                Console.Write(Fibonachi(i) + " ");
            }    
        }
    }    
}

