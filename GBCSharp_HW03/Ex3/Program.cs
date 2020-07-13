using System;

namespace Ex3
{
    // Максимов Дмитрий

    // * Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
    // * Добавить свойства типа int для доступа к числителю и знаменателю;
    // * Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
    // ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
    // *** Добавить упрощение дробей.


    class Fraction
    {
        public double a;
        public double b;

        public Fraction Plus (Fraction x2) // Сложение
        {
            double d1 = this.a / this.b;
            double d2 = x2.a / x2.b;
            double d3 = (d1 + d2) * 10;
            Fraction x3 = new Fraction();
            x3.a = d3;
            x3.b = 10;
            return x3;
        }
        public Fraction Minus(Fraction x2) // Вычитание
        {
            double d1 = this.a / this.b;
            double d2 = x2.a / x2.b;
            double d3 = (d1 - d2) * 10;
            Fraction x3 = new Fraction();
            x3.a = d3;
            x3.b = 10;
            return x3;
        }
        public Fraction Multi (Fraction x2) // Умножение
        {
            Fraction x3 = new Fraction();
            x3.a = x2.a * this.a;
            x3.b = x2.b * this.b;
            return x3;
        }
        public Fraction Division (Fraction x2) // Деление
        {
            Fraction x3 = new Fraction();
            x3.a = x2.a * this.b;
            x3.b = x2.b * this.a;
            return x3;
        }
        public string ToString()
        {
            return a + "/" + b;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два дробных числа ");
            Fraction fraction1 = new Fraction();
            Console.WriteLine("\nПервое число ");
            Console.Write("Числитель: ");
            fraction1.a = Convert.ToDouble(Console.ReadLine());        
            Console.Write("Знаменатель: ");
            fraction1.b = Convert.ToInt32(Console.ReadLine());

            Fraction fraction2 = new Fraction();
            Console.WriteLine("\nВторое число");
            Console.Write("Числитель: ");
            fraction2.a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Знаменатель: ");
            fraction2.b = Convert.ToInt32(Console.ReadLine());


            Fraction result = fraction1.Plus(fraction2);
            Console.WriteLine("\nСложение: " + result.ToString());

            result = fraction1.Minus(fraction2);
            Console.WriteLine("Вычитание: " + result.ToString());

            result = fraction1.Multi(fraction2);
            Console.WriteLine("Умножение: " + result.ToString());

            result = fraction1.Division(fraction2);
            Console.WriteLine("Деление: " + result.ToString());


        }
    }
}
