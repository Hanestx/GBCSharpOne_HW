using System;
using Ex6;

namespace Ex1
{
    /*
    Максимов Дмитрий

    Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
    В результате вся информация выводится в одну строчку:
    а) используя  склеивание;
	б) используя форматированный вывод;
	в) используя вывод со знаком $.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            string surName = Console.ReadLine();

            Console.Write("Сколько вам полных лет: ");
            byte age = Convert.ToByte(Console.ReadLine());

            Console.Write("Ваш рост: ");
            float h = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ваш вес: ");
            float w = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Имя:" + name + " Фамилия:" + surName + " Возраст:" + age + " Рост:" + h + " Вес:" + w + "\n");

            string output = String.Format("Имя: {0} \nФамилия: {1} \nВозраст: {2} \nРост: {3} \nВес: {4} \n", name, surName, age, h, w);
            Console.WriteLine(output);

            Console.WriteLine($"Имя: {name} \nФамилия: {surName} \nВозраст: {age} \nРост: {h} \nВес: {w}");
            MyMethod.Pause();
        }
    }
}