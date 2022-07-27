using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name; // Имя пользователя
            int age; // Возраст
            string zodiac;// Знак зодиака
            string job;// Работа

            Console.Write("Как Вас зовут?: ");
            name = Console.ReadLine();
            Console.Write("Сколько Вам лет?: ");
            age=Convert.ToInt32 (Console.ReadLine());
            Console.Write("Какой Ваш знак зодиака?: ");
            zodiac=Console.ReadLine();
            Console.Write("Где Вы работаете?: ");
            job=Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Вас зовут " + name + ", вам " + age + " год, вы " + zodiac + " и работаете " + job);
        }
    }
}



