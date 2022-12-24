using System.Security.Principal;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string birthday;
            string zodiacSign;
            string sity;
            string profession;

            Console.WriteLine
                ("Здравствуйте!");
            Console.Write("Укажите Ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Укажите свой возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Укажите свой день рождения: ");
            birthday = Console.ReadLine();
            Console.Write("Укажите свой знак задиака: ");
            zodiacSign = Console.ReadLine();
            Console.Write("Укажите место проживания: ");
            sity = Console.ReadLine();
            Console.Write("Укажите свою профессию: ");
            profession = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine($"Вас зовут {name}, возраст {age}, дата вашего рождения {birthday}");
            Console.WriteLine($"Ваш знак задиака {zodiacSign}, место проживания {sity}, профессия {profession} ");
           
            
            Console.ReadKey();
        }
    }
}