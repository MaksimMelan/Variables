using System.Security.Principal;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password;
            Console.WriteLine("Здравствуёте! Какой сегодня день недели?");
            password = Console.ReadLine();

            if (password == "EDG1fsdR124B")
            {
                Console.WriteLine("Проходите!");
            }
            else
            {
                Console.WriteLine("Вам сюда нельзя");
            }

            Console.ReadLine();
        }
    }
}