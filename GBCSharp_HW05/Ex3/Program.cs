using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ex3
{
    //Максимов Дмитрий

    //* Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
    //Например:
    //badc являются перестановкой abcd.

    class Program
    {
        static void Main(string[] args)
        {
            void Anagramm(string aWord, string aWord2)
            {
                aWord = aWord.ToLower().Replace(",", "").Replace(".","").Replace("!","");
                aWord2 = aWord2.ToLower().Replace(",", "").Replace(".", "").Replace("!", ""); ;

                char[] charArray = aWord.ToCharArray();
                char[] charArray2 = aWord2.ToCharArray();
                Array.Sort(charArray);
                Array.Sort(charArray2);

                String s = new String(charArray);
                String s2 = new string(charArray2);

                if (Equals(s, s2)) Console.WriteLine("Строка 2, является анаграммой строки 1.");
                else Console.WriteLine("Строка 2, НЕ является анаграммой строки 1.");
            }

            string word = "abcd!!.,";
            Console.WriteLine("Строка 1: " + word);

            string word2 = "cdba";
            Console.WriteLine("Строка 2: " + word2 + "\n");

            Anagramm(word, word2);
            Console.ReadLine();

        }
    }
}
