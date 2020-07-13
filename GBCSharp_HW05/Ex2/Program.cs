using Ex2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    //Максимов Дмитрий

    //Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
    //а) Вывести только те слова сообщения,  которые содержат не более n букв.
    //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    //в) Найти самое длинное слово сообщения.
    //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    //д) *** Создать метод, который производит частотный анализ текста.
    //      в качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает 
    //      сколько раз каждое из слов массива входит в этот текст.Здесь требуется использовать класс Dictionary.

    static class Message
    {
        // А
        public static string charCount(string[] usText, int n)
        {
            string wordPlus = "Слова которые содержат не более " + n + " букв: \n";
            foreach (string s in usText)
            {
                if (s.Length < n) wordPlus += s + " ";
            }
            return wordPlus;
        }

        //Б
        public static string charDel(string[] usText)
        {
            string wordPlus = "Мы удалили все слова которые оканчиваются на букву \"a\": \n";
            for (int i = 0; i < usText.Length; i++)
            {
                if (!usText[i].EndsWith("а"))
                    wordPlus += usText[i] + " ";
            }
            return wordPlus;
        }

        //В
        public static string charLong(string[] usText)
        {
            int max = 0;
            string memWord = "";

            foreach (string word in usText)
                if (word.Length > max)
                {
                    max = word.Length;
                    memWord = word;
                }

            string wordPlus = "Самое длинное слово в сообщение: \n" + memWord;
            return wordPlus;
        }

        //Г
        public static string charBuild(string[] usText)
        {
            int max = 8;
            StringBuilder sb = new StringBuilder();

            foreach (string word in usText)
                if (word.Length > max)
                {
                    sb.Append(word + " ");
                }

            string wordPlus = "Самые длинные слова в сообщении: \n" + sb;
            return wordPlus;
        }

        //Д
        public static string charAnalise(string[] usText, string text)
        {
            string slova = "";
            Dictionary<string, int> vacabulary = new Dictionary<string, int>();

            foreach (string word in usText)
            {
                if (vacabulary.ContainsKey(word)) vacabulary[word]++;
                else vacabulary.Add(word, 1);
            }
            foreach (KeyValuePair<string, int> pair in vacabulary)
            {         
                slova += "\nСлово: " + pair.Key + "\nПовтор: " + pair.Value + "\n";  
            }
            return slova;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение из нескольких слов: ");
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("\n" + Message.charCount(words, 5));
            Console.WriteLine("\n" + Message.charDel(words));
            Console.WriteLine("\n" + Message.charLong(words));
            Console.WriteLine("\n" + Message.charBuild(words));
            Console.WriteLine(Message.charAnalise(words, text));
            Console.ReadLine();
        }
    }
}

