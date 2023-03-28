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
            int[] bag = new int[1]; //сумка с вместимостью  один.

            int[] tempBag = new int[bag.Length + 1];// увеличиваем массив на +1
            for(int i = 0; i < bag.Length; i++)
            {
                tempBag[i] = bag[i]; //переносим все значения из bag в tembag.
            }
            tempBag[tempBag.Length - 1] = bag[bag.Length - 1] = 15;// на последний элемент назаначаем значение.
            bag = tempBag;
            // теперь наша суммка  сатла на еденицу больше.
            Console.WriteLine(bag.Length);
            Console.ReadKey();
        }
    }
}
