using System;
using System.Security.Principal;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // массив int-ов под названием array с небольшим количеством элмементов.
            //запомнить сумму всех элементов массива
            int[] array = { 1, 4, 6, 2, 8, 10 };
            int sum = 0;// изначально должна быть равна нулю, для этого нужно
                        // инициализировать переменную с 0, иначе там даже нуля не будет.

            for (int i = 0; i < array.Length; i++) // от нуля, до тех пор пока i будет
                                                   // меньше чем array.Length; i увеличиваем на единицу.
            {
               sum += array[i];//вывод "Console.WriteLine" убираем, нам нужна только
                               //ячейка. Мы обращаемся к ячейке и её к себе записываем.
               Console.WriteLine(sum);//выводим результат каждого сложения для контроля.
            }
            Console.WriteLine(sum);


            Console.ReadKey();
        }
    }
}