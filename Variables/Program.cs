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
            string firstName = "Максимов ";
            string lastName = "Максим";
            string clipboard;
           
            Console.WriteLine($"Неправильно заполнены данные:\nИмя - {firstName}, фамилия - {lastName} ");
            Console.WriteLine("Нажмите любую клавишу чтобы поменять их местами.");
            Console.ReadKey();

            clipboard = firstName;
            firstName = lastName;
            lastName = clipboard;

            Console.WriteLine($"Данные поменялись местами.\nИмя - {firstName}, фамилия - {lastName} ");
            Console.ReadKey ();

            /* 
             * //можно ли пользоваатся второй способом? какие могут быть проблемы? Мне кажется так наглядней?
            Console.WriteLine("Второй способ");
            Console.WriteLine($"Неправильно заполнены данные имя - {firstName}, фамилия - {lastName} ");
            Console.WriteLine("Нажмите любую клавишу чтобы поменять их местами.");
            Console.ReadKey();

            (firstName, lastName) = (lastName, firstName); // 

            Console.WriteLine($"Второй способ - проверка:\nИмя - {firstName}, фамилия - {lastName} ");
            Console.ReadKey();
            */
        }
    }
}
