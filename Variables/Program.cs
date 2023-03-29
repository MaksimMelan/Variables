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
            int books = 52;
            int inOneRow = 3;
            int numberOfRows = books / inOneRow;
            int remainderOfNumber = books % inOneRow;
            Console.WriteLine("Количесвто книг: " + books);
            Console.WriteLine("Сколько картин в ряд: " + inOneRow);
            Console.WriteLine("Сколько полсностью заполненных рядов: " + numberOfRows);
            Console.WriteLine("Картинок сверх меры: " + remainderOfNumber);
            Console.ReadKey();
        }
    }
}
