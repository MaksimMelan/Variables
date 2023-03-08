using System.Security.Principal;

namespace Variables
{
    class Program 
    {
        static void Main(string[] args)
        {
            float money;
            int years;
            int percent;

            Console.Write("Введите кол-во денег на вклад:");
            money = Convert.ToSingle(Console.ReadLine());
            Console.Write("На сколько лет открыт вклад: ");
            years = Convert.ToInt32(Console.ReadLine());
            Console.Write("Под какой процент: ");
            percent = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < years; i++)
            {
                money += money / 100 * percent;
                Console.WriteLine("В этом году у вас - " + money);
                Console.ReadKey();

            }
        }
    }
}