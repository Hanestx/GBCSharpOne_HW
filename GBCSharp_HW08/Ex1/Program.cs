using System;

namespace Ex1
{
    //Максимов Дмитрий
    //С помощью рефлексии выведите все свойства структуры DateTime

    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();
            Type type = dateTime.GetType();
            Console.WriteLine(type);

            Type myType = typeof(DateTime);
            Console.WriteLine(myType.ToString());
            Console.ReadLine();
        }
    }
}
