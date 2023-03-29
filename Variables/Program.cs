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
            int paintings = 52;
            int inRowPaintings = 3;
            int countOfRows = paintings / inRowPaintings;
            int remainderOfPaintings = paintings % inRowPaintings;
            Console.WriteLine("Количесвто книг: " + paintings);
            Console.WriteLine("Сколько картин в ряд: " + inRowPaintings);
            Console.WriteLine("Сколько полсностью заполненных рядов: " + countOfRows);
            Console.WriteLine("Картинок сверх меры: " + remainderOfPaintings);
            Console.ReadKey();
        }
    }
}
