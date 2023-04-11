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
            int fixedAppointmentTime = 10;
            int minutesInHours = 60;

            int personInQueue;
            int wholeHours;
            int remainingMinutes;
            int quantityMinutes;

            Console.WriteLine("Здравствуйте!\nВведите число человек в очереди");
            personInQueue = Convert.ToInt32(Console.ReadLine());

            quantityMinutes = personInQueue * fixedAppointmentTime;
            wholeHours = quantityMinutes / minutesInHours;
            remainingMinutes = quantityMinutes % minutesInHours;

            Console.WriteLine($"Время ожидания в очереди составит часов {wholeHours} и {remainingMinutes} минут.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
