using System.Security.Principal;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // массив int-ов под названием array с небольшим количеством элмементов.
            int[] array = { 1, 4, 6, 2, 8, 10 };

            for (int i = 0; i < array.Length; i++) // от нуля, до тех пор пока i будет меньше чем array.Length; i увеличиваем на единицу.
            {
                Console.WriteLine(array[i]);//в цикле выводим наши элементы поэтапно.
            }

            //запомнить сумму всех элементов массива
            Console.ReadKey();
        }
    }
}