using System;
namespace TaskDZ1
{
    class Program
    {
        public static int NOD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public static int NOD(int a, int b, int c)
        {
            int first_nod = NOD(a, b);
            return NOD(first_nod, c); 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Дз 5.1");
            Console.WriteLine("Введите два числа для подсчета НОД:");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"НОД чисел {x} и {y} = {NOD(x, y)}");

            Console.WriteLine("Введите три числа для подсчета НОД:");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int z1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"НОД чисел {x}, {y} и {z1} = {NOD(x, y, z1)}");
        }
    }    
}

