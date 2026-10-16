using System;
namespace Project
{   // Для пункта 4
    public enum GrumpyLevel
    {
        Low = 1,
        Medium = 2,
        High = 3, 
        Extreme = 4
    }
    public struct Ded
    {
        public string Name;
        public GrumpyLevel Grumpy;
        public string[] Phrases;
        public int BadWordsCount;

        public Ded(string name, GrumpyLevel grumpy, string[] phrases)
        {
            Name = name;
            Grumpy = grumpy;
            Phrases = phrases;
            BadWordsCount = 0;
        }
        public int CountBadWords(params string[] badwords)
        {
            int badwords_count = 0;
            foreach (string phrases in Phrases)
            {
                foreach (string bad in badwords)
                {
                    if (phrases == bad)
                    {
                        badwords_count++;
                    }
                }
            }
            BadWordsCount = badwords_count;
            return badwords_count;
        }
    }
    class Program
    {   //Для номера 2
        public static int Process(out double average, ref int product, params int[] array)
        {
            int sum = 0;
            product = 1;

            foreach (int m in array)
            {
                sum += m;
                product *= m;
            }
            average = (double)sum / array.Length;
            return sum;
        }
        // Для номера 3
        public static void DrawNum(int num)
        {
            string[] patterns =
            {
                "###\n# #\n# #\n# #\n###", // 0
                "  #\n  #\n  #\n  #\n  #", // 1
                "###\n  #\n###\n#  \n###", // 2
                "###\n  #\n###\n  #\n###", // 3
                "# #\n# #\n###\n  #\n  #", // 4
                "###\n#  \n###\n  #\n###", // 5
                "###\n#  \n###\n# #\n###", // 6
                "###\n  #\n  #\n  #\n  #", // 7
                "###\n# #\n###\n# #\n###", // 8
                "###\n# #\n###\n  #\n###"  // 9
            };
            Console.WriteLine(patterns[num]);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Пункт 1");
            Random rnd = new Random();
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 100);
            }
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Введите первое число для замены:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число для замены:");
            int num2 = int.Parse(Console.ReadLine());

            int index1 = -1;
            int index2 = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num1) index1 = i;
                if (array[i] == num2) index2 = i;
            }
            if (index1 == -1 || index2 == -1)
            {
                Console.WriteLine("Ошибка: одно или оба числа не найдены в массиве!");
            }
            else
            {
                int temp = array[index1];
                array[index1] = array[index2];
                array[index2] = temp;
                Console.WriteLine("Массив мосле замены: ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }
            Console.WriteLine("Пункт 2");
            double avg;
            int prod = 1;
            int sum = Process(out avg, ref prod, 2, 5, 6, 7, 8);
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {prod}");
            Console.WriteLine($"Среднее арифметическое: {avg}");

            Console.WriteLine("Пункт 3");
            Console.WriteLine("Вводите числа от 0 до 9.");
            Console.WriteLine("Для выхода введите 'exit' или 'закрыть'");
            while (true)
            {
                Console.WriteLine("Введите число: ");
                string input = Console.ReadLine();
                if (input == "exit" || input == "закрыть")
                {
                    Console.WriteLine("Выход из программы");
                    break;
                }
                int number = int.Parse(input);
                if (number >= 0 && number <= 9)
                {
                    DrawNum(number);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка: число {number} должно быть от 0 до 9!");
                    Thread.Sleep(3000);
                    Console.ResetColor();
                }
            }
            Console.WriteLine("Пункт 4");
            Ded ded1 = new Ded("Лёша", GrumpyLevel.Low, new string[] { "Уроды!", "Сволочи!", "Гады!" });
            Ded ded2 = new Ded("Виталя", GrumpyLevel.Medium, new string[] { "Проститутки!", "Барбосы!", "Гуманоиды!", "Гады!" });
            Ded ded3 = new Ded("Амир", GrumpyLevel.High, new string[] { "Гады!", "Безобразие!", "Болваны!" });
            Ded ded4 = new Ded("Илья", GrumpyLevel.Medium, new string[] { "Проститутки!" });
            Ded ded5 = new Ded("Артур", GrumpyLevel.Extreme, new string[] { "Дурак!", "Проститутки!", "Бестолочи!", "Негодники!", "Гады" });
            string[] badwords = { "Проститутки!", "Гады!" };
            Console.WriteLine("Проверка дедов:\n");
            int fines1 = ded1.CountBadWords(badwords);
            Console.WriteLine($"Дед {ded1.Name} (ворчливость: {ded1.Grumpy} {fines1} фингалов");
            int fines2 = ded2.CountBadWords(badwords);
            Console.WriteLine($"Дед {ded2.Name} (ворчливость: {ded2.Grumpy} {fines2} фингалов");
            int fines3 = ded3.CountBadWords(badwords);
            Console.WriteLine($"Дед {ded3.Name} (ворчливость: {ded3.Grumpy} {fines3} фингалов");
            int fines4 = ded4.CountBadWords(badwords);
            Console.WriteLine($"Дед {ded4.Name} (ворчливость: {ded4.Grumpy} {fines4} фингалов");
            int fines5 = ded5.CountBadWords(badwords);
            Console.WriteLine($"Дед {ded5.Name} (ворчливость: {ded5.Grumpy} {fines5} фингалов");
        }
    }    
}

