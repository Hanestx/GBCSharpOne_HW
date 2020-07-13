using System;

namespace Ex2
{
    // Максимов Дмитрий

    // а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
    // Требуется подсчитать сумму всех нечётных положительных чисел.Сами числа и сумму вывести на экран, используя tryParse.

    class Program
    {
        static void Main(string[] args)
        {
            int ch = 1;
            int i = 0;
            int result = 0;
            int[] numbers = new int[1];

            
            Console.WriteLine("Вводите по очереди целые числа. Чтобы закончить ввод - введите ноль.");
            while (ch != 0)
            {
                string value = Console.ReadLine();
                bool success = Int32.TryParse(value, out ch);
                if (success && ch > 0 && ch % 2 != 0)
                {
                    if (ch > 0 && ch % 2 != 0)
                    {
                        result += ch;
                        numbers[i] = ch;
                        i++;
                        Array.Resize(ref numbers, numbers.Length + 1);
                    }
                }      
                else
                {
                    Console.WriteLine("Введите целое число"); 
                }

            }

            Console.Write("\nВаши нечётные числа: ");
            foreach (int numb in numbers) Console.Write(numb + " ");
            Console.WriteLine("\nСумма нечётных чисел: " + result);
        }

    }
}