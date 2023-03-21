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
            //массив - ссылочный тип
            //int[] array = new int[5];
            //int[] array2 = new int[3];
            //array[0] = 5; // изменяем у массива нулевой  элемент на 5 - это 0 (первый) стал содержать 5
            //array = array2; // После инициализации от одного массива до другого, мы передаём ссылку на память.
            // после этого они пользуются одой памятью для обоих, изменение данных в одном массиве, приведеёт к изменениям данных в другом.
            //Console.WriteLine(array2[0]);
            //Console.ReadKey();
            int[] petrovich = new int[3];
            int[] ivanovich = new int[5];
            int[] sidorovich;
            petrovich = ivanovich;
            // после того как petrovich = ivanovich,  они оба ссылаются  область паяти ivanovich,
            // а предыдущая область пмяти petrovich  сгорает.  Её большене верноуть                    
            petrovich[0] = 5;
            ivanovich[1] = 3;
            sidorovich = ivanovich;
            Console.WriteLine(sidorovich[0]);
            Console.WriteLine(sidorovich[1]);
            for (int i = 0; i < petrovich.Length; i++)
            {
                Console.WriteLine("petrovich " + petrovich[i]);
            }
            for (int i = 0; i < ivanovich.Length; i++)
            {
                Console.WriteLine("ivanovich " + ivanovich[i]);
            }
            for (int i = 0; i < sidorovich.Length; i++)
            {
                Console.WriteLine("sidorovich " + sidorovich[i]);               
            }       
            // петрович остновал новый гараж на 10 вещей вместимостью, и ушол из старого.
            petrovich = new int[10];
            for (int i = 0; i < petrovich.Length; i++)
            {
                Console.WriteLine("petrovich " + petrovich[i]);                
            }
            Console.ReadKey();
        }
    }
}
