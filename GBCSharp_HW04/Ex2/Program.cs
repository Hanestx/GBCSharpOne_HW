using Ex2Class;
using System;
using System.IO;
using System.Threading;

namespace Ex2Class
{
    //Максимов Дмитрий

    //Реализуйте задачу 1 в виде статического класса StaticClass;
    //а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
    //б) * Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
    //в)** Добавьте обработку ситуации отсутствия файла на диске.

    public static class StaticClass
    {
        //A
        public static int Pairs(int[] mas)
        {
            int count = 0;
            for (int i = 0; i < mas.Length - 2; i++) // -2 чтобы не учитывал 21-й элемент массива, и не выходил за приделы
            {
                if (mas[i] % 3 == 0 && mas[i + 1] % 3 != 0) count++;
                else if (mas[i] % 3 != 0 && mas[i + 1] % 3 == 0) count++;
            }

            return count;
        }

        //Б
        public static int[] TextMas(string filename)
        {
            string[] readText = File.ReadAllLines(filename);
            int[] arrT = new int[readText.Length];
            int i = 0;

            foreach (string s in readText)
            {
                arrT[i] = int.Parse(s);
                i++;
            }
            return arrT;
        }



    }

}

class Program
{
    static void Main(string[] args)
    {
        #region Заполнение массива рандомными числами
        int[] rMas = new int[21]; // 21 вместо 20, чтобы при выходе за пределы не было ошибки
        int q;
        Random rnd = new Random();

        for (int i = 0; i < rMas.Length - 1; i++) // заполняем только 20
            rMas[i] = rnd.Next(-10000, 10000);
        #endregion

        #region Запись массива в текстовый файл и проверка на его наличие
        string path = "data.txt";
        Console.WriteLine("Проверка наличия файла с массивом.");

        if (!File.Exists(path))
        {
            Console.WriteLine("Файл не найден. Создаётся файл... \n");
            FileStream file = new FileStream(path, FileMode.Append);
            StreamWriter stream = new StreamWriter(file);
            foreach (int arr in rMas) stream.WriteLine(arr.ToString());
            stream.Dispose();
            file.Close();
        }
        else
        {
            Console.WriteLine("Такой файл уже существует. Перезаписываем...\n");
            File.Delete(path);
            FileStream file = new FileStream(path, FileMode.Append);
            StreamWriter stream = new StreamWriter(file);
            foreach (int arr in rMas) stream.WriteLine(arr.ToString());
            stream.Dispose();
            file.Close();
        }

        #endregion

        #region Вывод А
        q = StaticClass.Pairs(rMas);
        Console.WriteLine("Количество пар: " + q);
        Console.WriteLine();
        #endregion

        #region Вывод Б
        int[] bMas = StaticClass.TextMas(path);
        Console.WriteLine("Числа массива из текстового файла: ");
        foreach (int b in bMas) Console.WriteLine(b);
        #endregion

        Console.ReadKey();
    }
}




