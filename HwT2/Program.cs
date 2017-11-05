using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwT2
{
    //Евдохин Д.

    // Написать метод подсчета количества цифр числа.

    class Program
    {
        static void RecSchet(long chislo, ref short x)
        {
            if (chislo  != 0)
            {
                chislo /= 10;
                x++;
                RecSchet(chislo, ref x);
            }
        }



        static void Main(string[] args)
        {
            short x = 0;
            Console.WriteLine("Введите число");
            long ch = long.Parse(Console.ReadLine());
            RecSchet(ch, ref x);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
