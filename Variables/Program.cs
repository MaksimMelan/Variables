using System;
using System.Security.Principal;
using System.Xml.Linq;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Ведите первое число: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Число " + num1 + " равно числу два " + num2);
            }
            else if (num1 > num2)
            {
                Console.WriteLine("Первое число " + num1 + " больше чем второе число " + num2);
            }
            else
            {
                Console.WriteLine("Первое число " + num1 + " меньше второго числа " + num2);
            }
            Console.ReadKey();
        }
    }
}
