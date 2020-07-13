using System;
using Ex6;

namespace Ex3
{
    /*
    Максимов Дмитрий

    а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
    по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
    Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);

    б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

    */

    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2;

            Console.WriteLine("Узнать расстояние между точками \n");

            Console.WriteLine("Введите координаты 1-й точки: (используйте \',\' для дробных значений)");
            Console.Write("x = ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Введите координаты 2-й точки:");
            Console.Write("x = ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            // Способ А
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние между точками = " + "{0:0.00}", r);

            //Cпособ Б
            double dist = Distance(x1, y1, x2, y2);
            Console.WriteLine("Расстояние между точками = " + "{0:0.00}", dist);
            MyMethod.Pause();

            //Метод
            double Distance(double x1, double y1, double x2, double y2)
            {
                return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            }
        }
    }
}