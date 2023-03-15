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
            

            Console.WriteLine("Ведите первое число: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 > 5 && num1 < 10)
                Console.WriteLine("Число больше 5 и меньше 10");
            else
                Console.WriteLine("Неизвестное число!");
            Console.ReadKey();
        }
    }
}
