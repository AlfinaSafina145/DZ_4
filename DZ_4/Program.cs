using System;
namespace Task5_2
{
    class Program
    {
        public static void Change(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 5.2");
            Console.Write("Введите первое число: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"До вызова метода x = {x}, y = {y}");
            Change(ref x, ref y);
            Console.WriteLine($"После вызова метода x = {x}, y = {y}");
        }

    }    
}

