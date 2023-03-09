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
            int maxElement =0;// создаём переменную - максимальный элемент.
            
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