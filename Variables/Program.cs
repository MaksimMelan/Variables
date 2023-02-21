using System.Security.Principal;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rubToUSD = 72, usdToRub = 75;
            float rub;
            float usd;
            string userInput;
            float currencyCount;

            Console.WriteLine("Какую операцию хотите провести?");

            Console.WriteLine("ведите баланс рублей");
            rub = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("введите баланс долларов");
            usd = Convert.ToSingle(Console.ReadLine());

            
            Console.WriteLine("1 -  рубли на доллары.");
            Console.WriteLine("2 - доллары на рубли.");            
            userInput = Console.ReadLine();
            
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("1 - обмен  рубли на доллары.");
                    Console.WriteLine("Сколько вы хотите обменять?");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    
                    if (rub >= currencyCount)
                    {
                        rub -= currencyCount;
                        usd += currencyCount / rubToUSD; 
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое количесвто рублей");
                    }
                    break;
                case "2":
                    Console.WriteLine("2 - доллары на рубли."); 
                    Console.WriteLine("Сколько вы хотите обменять?");
                    currencyCount = Convert.ToSingle(Console.ReadLine());

                    if (usd >= currencyCount)
                    {
                        usd -= currencyCount;
                        rub -= currencyCount * usdToRub;
                    }
                    break;

            }


            Console.WriteLine("Ваш баланс - " + rub + " рублей и " + usd + " долларов.");
            Console.ReadLine();
        }
    }
}