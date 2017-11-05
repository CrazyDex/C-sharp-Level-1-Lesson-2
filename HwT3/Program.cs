using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwT3
{
    //Евдохин Д.

    // С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int res = 0;
            Console.WriteLine("Вводите числа, для прекращения введите \"0\"");
            while (true)
            {
                x = int.Parse(Console.ReadLine());
                if (x % 2 != 0) { res += x; }
                string s = $"asdasd";
                if (x == 0) { Console.WriteLine($"Сумма всех нечетных чисел равна {res}"); break; }
            }
            Console.ReadKey();
        }
    }
}

