using System;
using System.Collections.Generic;
using System.IO;

namespace Ex3
{
    //Максимов Дмитрий

    //Переделать программу Пример использования коллекций для решения следующих задач:
    //а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
    //б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
    //в) отсортировать список по возрасту студента;
    //г) * отсортировать список по курсу и возрасту студента;

    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;
        public Student(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }
    }
    class Program
    {
        static int MyDelegatAge(Student st1, Student st2)
        {
            return String.Compare(st1.age.ToString(), st2.age.ToString());
        }

        static void Main(string[] args)
        {
            int bakalavr = 0;
            int magistr = 0;
            int crs5 = 0;
            int crs6 = 0;
            int ageCount = 0;
            string ageCrs = "";
            List<Student> list = new List<Student>();
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("students.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    if (int.Parse(s[6]) < 5) bakalavr++; else magistr++;

                    //А и Б
                    if (int.Parse(s[6]) == 5) crs5++; else if (int.Parse(s[6]) == 6) crs6++;
                    if (int.Parse(s[5]) >= 18 && int.Parse(s[5]) <= 20) { ageCount++; ageCrs += s[6] + ":";}
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();
            Console.WriteLine("Всего студентов: " + list.Count);

            Console.WriteLine("\n5-й курс: {0}", crs5);
            Console.WriteLine("6-й курс: {0}", crs6);
            Console.WriteLine("\nКоличество студентов от 18 до 22 лет: {0}", ageCount);
            Console.WriteLine("Они обучаются на: {0}", ageCrs + "-х курсах.");

            Console.WriteLine("\nМагистров: {0}", magistr);
            Console.WriteLine("Бакалавров: {0}", bakalavr + "\n");

            // В
            list.Sort(new Comparison<Student>(MyDelegatAge));
            Console.WriteLine("Сортировка студентов по возрасту: ");
            foreach (var v in list) Console.WriteLine(v.age + " " + v.firstName + " " + v.lastName);
            Console.WriteLine();
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }
    }
}

