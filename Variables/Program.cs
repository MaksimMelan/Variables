using System;
using System.Drawing;
using System.Globalization;
using System.Security.Principal;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeOne = 10;
            int minutesInHours = 60;

            int personQueue = 0;
            int hours = 0;
            int minutes = 0;

            while (true)
            { 
                Console.WriteLine("Здравствуйте!\nВведите число человек в очереди");
                personQueue = Convert.ToInt32(Console.ReadLine());

                hours = (personQueue * timeOne) / minutesInHours;
                minutes = (personQueue * timeOne) % minutesInHours;

                Console.WriteLine($"Время ожидания в очереди составит часов {hours} и {minutes} минут.");
                Console.ReadKey();
                Console.Clear();
            }   
        }
    }
}
