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
            // игра
            Console.CursorVisible = false;// отключаем курсор.
            // 1)создаём карту - область с символами-объектами.
            char[,] map = //двухммерный массив с элмементами карты, массив из символов
            {
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
                {'#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ','#',' ',' ',' ',' ','X',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','X',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','X',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'}
            };

            // 6) устанавливаем координаьты нашего игрока.
            int userX = 6, userY = 6;
            // 12) создадим сокровища, нужна сумка для них 
            char[] bag = new char[0]; // изначально в сумке ни его нет
            // расширяем её когда что-то утда положим.


            while(true)// 2)вечный цикл, постоянно нажо переррисовывать, так как будут изменнения.
            {
                Console.SetCursorPosition(0, 15); // 14) позиция рюкзака
                Console.Write("Сумка: ");
                for(int i = 0; i < bag.Length; i++)
                {
                    Console.Write(bag[i] + " ");// 15) дальше нужно обработать сбор.
                }

                Console.SetCursorPosition(0, 0);// 13) поциция карты
                // 3) отрисуем карту
                for (int i = 0; i < map.GetLength(0); i++) //перебераем массив по первому измерению
                {
                    for(int j = 0; j < map.GetLength(1); j++)//перебераем массив по второму измерению
                    {
                        Console.Write(map[i, j]);//выводим в печать перебарнный массив.
                    }
                    Console.WriteLine();// пропуст строки
                }
                Console.SetCursorPosition(userY, userX);// 7) ставим персонажа.
                Console.Write('@'); // 8) сам персонаж.
                ConsoleKeyInfo charKey = Console.ReadKey();// 9) мы записали информацию о нажатой клавише.

                switch (charKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (map[userX - 1, userY] != '#')
                        {
                            userX--;// 10) движение вверх
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (map[userX + 1, userY] != '#')
                        {
                            userX++;// 11) движение вниз
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (map[userX, userY - 1 ] != '#')
                        {
                            userY--;// 12) движение вниз
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (map[userX, userY + 1] != '#')
                        {
                            userY++;// 11) движение вниз
                        }
                        break;
                }

                if (map[userX,userY] == 'X') // 16)
                {
                    map[userX, userY] = 'O';

                    // 17) чтоб расширить массив, нужен новый массив такого же типа.
                    char[] tempBag = new char[bag.Length + 1];
                    for(int i = 0; i< bag.Length; i++)
                    {
                        tempBag[i] = bag[i];
                    }
                    tempBag[tempBag.Length - 1] = 'X';
                    bag = tempBag;
                }

                //Console.ReadKey(); // 5)ставим временно чтоб посмотреть карту.
                Console.Clear(); //  4)очистака экрана, потом зададим частоту обновления.
            }
        }
    }
}
