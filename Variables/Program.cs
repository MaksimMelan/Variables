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
            // программа отвечающая за регистрацию пассажиров на рейс самолёта.
            int[] sectors = { 6, 28, 15, 15, 17 };
            bool isOpen = true;

            // чтоб  программа не закрывалась после каждого нашего действия используем цикл while.
            
            while (isOpen)
            {
                Console.SetCursorPosition(0, 10);
                for (int i = 0; i < sectors.Length; i++)
                {
                    Console.WriteLine($"В секторе {i + 1} свободно {sectors[i]} мест.");


                }

                Console.SetCursorPosition(0, 0); //местопоявления тектса который дан ниже
                Console.WriteLine("Регистраци рейса.");
                Console.WriteLine("\n1 - Забронированные места.\n\n2 - Выход из программы.");
                Console.Write("Введите номер команды: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userSector, userPlaceAmount;
                        Console.Write("В каком секторе вы хотите лететь? ");
                        userSector = Convert.ToInt32(Console.ReadLine()) -1; // при выюоре сектора пользователем мы ставим 
                        if(sectors.Length <= userSector || userSector < 0)// Кол-во секторов которое ввсёл админ, меньше или равно, кол-ву секторов.
                                                                          // Или меньше нуля.
                        {
                            Console.WriteLine("Такого сектора не существует.");
                            break;
                        }
                        Console.Write("Сколько вы хотите забронировать? ");
                        userPlaceAmount = Convert.ToInt32(Console.ReadLine());
                        if(userPlaceAmount < 0)
                        {
                            Console.WriteLine("Не верное количество мест. ");
                            break;
                        }
                        if (sectors[userSector] < userPlaceAmount) 
                        {
                            Console.WriteLine($"В секторе {userSector} недостаточно мест. " + $"Остаток {sectors[userSector]}");
                            break;
                        }
                        // Если значения введённые администратором прошли все проверки,
                        // мы у сектора который ввёл наш клиен вычитаем количество мест которое желал клиент

                        sectors[userSector] -= userPlaceAmount;
                        Console.WriteLine("Бронирование успешно!");
                        break;
                    case 2:
                        isOpen = false;
                        break;

                }


                Console.ReadKey(); // обновление списка по нажатию клавиши. вместо непрерывного цикла.
                Console.Clear();
            }


            Console.ReadKey();
        }


    }
}
