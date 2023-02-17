using System.Security.Principal;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string sity;
            int age;
            Console.WriteLine("Здравствуйте! Как Вас зовут? ");
            name = Console.ReadLine();
            Console.WriteLine("ВВедите ваш возраст");
            age =Convert.ToInt32(Console.ReadLine());


            if ( name == "Максим" && age >= 18  )
            {
                Console.WriteLine("Здравствуйте " + name + "." + "Пройдите пожалуйста проверку");
            }
            else
            {
                Console.WriteLine("У Вас нет доступа");
                Main(args);
            }

            Console.WriteLine("В каком городе Вы живёте?");
            sity = Console.ReadLine();

            if (sity == "Оренбург")
            {
                Console.WriteLine("ААА! Оренбургские пуховые платки?...");
            }
            else if (sity == "Самара")
            {
                Console.WriteLine("AAA!Бункер Сталина?...");
            }
            else if (sity == "Москва")
            {
                Console.WriteLine("ААА! Золотые купала?...");
            }
            Console.WriteLine("Ну проходи гостем будешь");
            Console.ReadLine();
        }
    }
}