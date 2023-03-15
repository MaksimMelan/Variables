using System;
using System.Security.Principal;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = 0; 
            

            Console.WriteLine("Ведите сумму вклада: ");
             deposit = Convert.ToDouble(Console.ReadLine());

        M:
            if (deposit < 100)
                deposit += deposit * 0.05;
            else if (deposit <= 200)
                deposit += deposit * 0.07;
            else
                deposit += deposit * 0.1;

            Console.WriteLine($"Сумма вклада после начисления  равна: {deposit + 15}");

            Console.ReadKey();
        }
    }
}
