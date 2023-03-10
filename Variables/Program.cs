using System;
using System.Security.Principal;
using System.Xml.Linq;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // система брони столов. мой вариант бронирования case 2.
            bool isOpen = true;
            int[] tables = {1, 2, 3, 4, 5, 6, 7, 8, 9 }; // указан не номер стола, а количесвто место за столом.
            int userInput;
            int userInput2;
            // чтоб система не заканчивалась как, кто-то всё забронирует, создадим вечный цикл while
            while (true) // пока кто-то работает - мы делаем. 
            {
               
                // вступление
                Console.WriteLine("1 - вывесит список столов.\n2 - забронировать место.\n3 - выход из программы");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        for (int i = 0; i < tables.Length; i++)//Сначала выведем все столы
                        {
                            Console.WriteLine("За столом - " + (i + 1) + " свободно " + tables[i] + " мест.");
                            // i + 1 делаем для того чтоб нумерация стовлов показывалась как удобно пользователю - не с 0, а с 1.
                        }
                        break;
                    case 2:
                        Console.WriteLine("Введите номер стола: ");
                        userInput = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Выбран стол №" + userInput);
                        Console.WriteLine("Введите количество бронируемых мест: ");
                        userInput2 = Convert.ToInt32(Console.ReadLine());
                        tables[(userInput -1)] = userInput2;
                        Console.WriteLine("Забронирован стол №" + userInput + "\nЗабронированно " + userInput2 + " мест.");
                        for(int i = 0; i < tables.Length; i++)// выводим столы заного для проверки.
                        {
                            Console.WriteLine("За столом - " + (i + 1) + " свободно " + tables[i] + " мест.");
                            // i + 1 делаем для того чтоб нумерация стовлов показывалась как удобно пользователю - не с 0, а с 1.
                        }
                        break;
                    case 3:
                        isOpen = false;
                        break;//мы не можем в таком варианте указать break второй раз - чтоб показать выход из программы
                              // добавляем isOpen (открыто заведение или закрыто.

                }
                
            }

            Console.ReadKey();
        }
    }
}