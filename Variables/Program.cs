using System.Security.Principal;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day;
            Console.WriteLine("Здравствуёте! Какой сегодня день недели?");
            day = Console.ReadLine();

            

            switch (day)
            {
                case "Воскресенье":
                case "Понедельник":
                case "Суббота":
                    Console.WriteLine("идём в кино");
                    Console.WriteLine("едим попкорн");
                    break;
                case "Вторник":
                    Console.WriteLine("Пройдём курсы");
                    break;
                case "Среда":
                    Console.WriteLine("Изучаем switch");
                    break;
                case "Четверг":
                    Console.WriteLine("проектируем приложение");
                    break;
                case "Пятница":
                    Console.WriteLine("Чиллл");
                    break;
                default:
                    Console.WriteLine("Я такого дня не знаю");
                    break;
            }
            Console.ReadLine();
        }
    }
}