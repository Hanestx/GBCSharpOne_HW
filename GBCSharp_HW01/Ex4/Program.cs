using System;
using Ex6;

namespace Ex4
{
    /*
    Максимов Дмитрий

    Написать программу обмена значениями двух переменных:
    а) с использованием третьей переменной;
	б) *без использования третьей переменной.
    */
    class Program
    {
        static void Main(string[] args)
        {
            //Способ А
            int x, y, z;
            x = 5;
            y = 7;
            Console.WriteLine("Способ А было: \nx = " + x + "\ny = " + y);
            Console.WriteLine();

            z = x;
            x = y;
            y = z;

            Console.WriteLine("Способ А стало: \nx = " + x + "\ny = " + y);
            Console.WriteLine();

            //Способ Б
            x = 10;
            y = 6;
            Console.WriteLine("Способ Б было: \nx = " + x + "\ny = " + y);
            Console.WriteLine();

            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("Способ Б стало: \nx = " + x + "\ny = " + y);
            MyMethod.Pause();



        }
    }
}