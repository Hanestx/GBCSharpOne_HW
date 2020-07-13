using System;
using Ex6;

namespace Ex2
{
    /*
    Максимов Дмитрий

    Ввести вес и рост человека. 
    Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
    где m — масса тела в килограммах, h — рост в метрах.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Рассчёт индекса массы тела (ИМТ) человека \n");

            Console.Write("Введите рост: ");
            float h = float.Parse(Console.ReadLine());

            Console.Write("Введите вес: ");
            float m = float.Parse(Console.ReadLine());

            float I = m / (h * h);
            Console.WriteLine("ИМТ = " + I);
            MyMethod.Pause();
        }
    }
}
