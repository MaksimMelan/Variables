using System;
using System.Security.Principal;
using System.Xml.Linq;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // найти наибольшее число в массиве.
            int[] array = { 1, 5, 3, 4, 8, 16, 28 };
            int maxElement = int.MinValue;// создаём переменную - максимальный элемент.
                               // Переменной 0 может не быть и не существоивать,или другие проблемы...
                               // в место нуля можно поставить константу типа int (или другого типа данных)
                               // - минимально возмножную или максимально возможную для этого типа 
                               // в звависичиости от условий. пишем "int." и выбираем константу.

            
            for (int i = 0; i < array.Length; i++)// начинаем перебирать эемементы массива.
            {
                // ели максЭлемент меньше элмемента массива - значит максЭлмент равняется Элмемент равняется элементу массива.
                if(maxElement < array[i])
                {
                    maxElement = array[i];
                    Console.WriteLine(maxElement);
                }
                else
                {
                    Console.WriteLine(maxElement);
                }
            }
            Console.WriteLine("наибольшее число в массиве: " + maxElement);
            Console.ReadKey();
        }
    }
}