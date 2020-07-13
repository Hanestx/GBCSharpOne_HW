using System;

namespace Ex1
{
    // Максимов Дмитрий

    // а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
    // б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
    // в) Добавить диалог с использованием switch демонстрирующий работу класса.

        struct Complex
        {
            public double im;
            public double re;
            public Complex Plus(Complex x)
            {
                Complex y;
                y.im = im + x.im;
                y.re = re + x.re;
                return y;
            }
            public Complex Multi(Complex x)
            {
                Complex y;
                y.im = re * x.im + im * x.re;
                y.re = re * x.re - im * x.im;
                return y;
            }
            public string ToString()
            {
                return re + "+" + im + "i";
            }
            
        //ДЗ А)
            public Complex Minus(Complex x)
            {
                Complex y;
                y.im = im - x.im;
                y.re = re - x.re;
                return y;
            }
           
        class Program
        {
            static void Main(string[] args)
            {
                Complex complex1;
                complex1.re = 1;
                complex1.im = 1;

                Complex complex2;
                complex2.re = 2;
                complex2.im = 2;

                Complex result = complex1.Plus(complex2);
                Console.WriteLine("Сумма: " + result.ToString());
                result = complex1.Multi(complex2);
                Console.WriteLine("Умножение: " + result.ToString());
        //
                result = complex2.Minus(complex1);
                Console.WriteLine("Вычитание: " + result.ToString());

            }
        }
    }
}
