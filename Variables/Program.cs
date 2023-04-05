using System;
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
            int gold = 0;
            int crystalsCount = 0;
            int crystalPrice = 70;

            Console.WriteLine("Добро пожаловать в магазин кристалов!\n" +
                $"Сегодня кристалы по {crystalPrice} золотых манет.");
            Console.WriteLine("Сколько у вас золота?");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько кристалов Вам нужно:");
            crystalsCount = Convert.ToInt32(Console.ReadLine());

            gold -= crystalsCount * crystalPrice;

            Console.WriteLine($"У в {gold} золота и {crystalsCount} кристалов ");
            Console.ReadKey();
        }
    }
}
