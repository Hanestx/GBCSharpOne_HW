using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Ex1
{
    //Максимов Дмитрий

    //Создать программу, которая будет проверять корректность ввода логина.
    //Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, 
    //при этом цифра не может быть первой:
    //а) без использования регулярных выражений;
    //б) ** с использованием регулярных выражений.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввод логина. Используйте [A-Z, 0-9] [2-10 символов] \nЛогин не может начинаться с цифры.\n");
            bool correct = false;

            #region Способ А
            Console.WriteLine("Без использования регулярных выражений");

            while (correct != true)
            {
                Console.Write("Login: ");
                string login = Console.ReadLine();

                if (login.Length < 2 || login.Length > 10 || Char.IsDigit(login[0]))
                {
                    Console.WriteLine("Логин некорректен\n");
                }
                else
                {
                    for (int i = 0; i < login.Length; i++)
                    {
                        if (!Char.IsLetterOrDigit(login[i]))
                        {
                            Console.WriteLine("Логин некорректен\n");
                            correct = false;
                            break;
                        }
                        else correct = true;
                    }
                }   
            }

            Console.WriteLine("Логин корректен\n");
            #endregion

            #region Способ Б
            Console.WriteLine("C использованием регулярных выражений:");
            Regex loginRg = new Regex("^[a-zA-Zа-яА-Я][a-zA-Zа-яА-Я0-9]{1,9}$");
            correct = false;

            while (correct == false)
            {
                string login2 = Console.ReadLine();

                if (loginRg.Match(login2).Success)
                {
                    Console.WriteLine("Корректно");
                    correct = true;
                }
                else Console.WriteLine("Некорректно\n");
            }
            #endregion
            
            Console.ReadLine();
        }
    }
}
