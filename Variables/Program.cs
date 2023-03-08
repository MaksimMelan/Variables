using System.Security.Principal;

namespace Variables
{
    class Program 
    {
        static void Main(string[] args)
        {
            int tryCount = 5;
            string password = "123456";
            string userInput;

            for(int i = 0; i < tryCount; i++)
            {
                Console.Write("Введите пароль: ");
                userInput = Console.ReadLine();

                if(password == userInput)
                {
                    Console.WriteLine("Секретики");
                }
                else
                {
                    Console.WriteLine("У Вас осталось - " + (tryCount - i - 1) + " попытки.");
                }
            }


            Console.ReadKey();
        }
    }
}