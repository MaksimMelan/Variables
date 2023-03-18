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
            Random random = new Random();
            int sizeArrey = random.Next(0, 51);
            int[] cucumbers = new int[sizeArrey]; // размер массива 10, но каждый элемент массива == 0
            //Console.WriteLine(cucumbers[0]);// обращаемся к первой банке и спрашиваем, что у неё  внутри.
                                            // мерез имя массива и номер ячейки мы можем обратится к конкертному элементу массива.
                                            // это похоже на однотипное действие которое повторяется вновь и вновь.
                                            // значит тут можно использовать массив, так как нам изветсны условия и кол-во то используем for

            
            Console.WriteLine(cucumbers.Length + 1);
            for (int i = 0; i < cucumbers.Length; i++)
            {
                cucumbers[i] = random.Next(0, 101);
            }
            Console.WriteLine();
            for (int i = 0; i < cucumbers.Length; i++)
            {
                if(cucumbers[i] % 2 == 0)
                {
                    Console.Write(cucumbers[i] + ", ");
                }
            }


            Console.ReadKey();
        }
            
        
    }
}
