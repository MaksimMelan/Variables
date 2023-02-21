using System.Security.Principal;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 10;

            while(age-- > 0)
            {
                

                if (age == 5)
                {
                    continue;
                }
                Console.WriteLine( age + "С днём рождения!");
            }
            Console.ReadLine();
        }
    }
}