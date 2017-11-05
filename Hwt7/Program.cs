using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwT7
{
    //Евдохин Д.

    //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b);
    //б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.
    class Program
    {
        static void Met(int a, int b)
        {
            if (a < b)
            {
                Console.WriteLine(a);
                a++;
                Met(a, b);
            }
        }

        static void Sum(int a, int b, ref int res)
        {
            if (a > b)
            {
                res += ++b; //так потому что нужна сумма чисел от а до б НЕ ВКЛЮЧАЯ саму б
                Sum(a, b, ref res);
            }
            else if (a < b)
            {
                res += a;
                a++;
                Sum(a, b, ref res);
            }
        }

        static void Main(string[] args)
        {
            #region Start data
            Console.WriteLine("Enter a, b");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            #endregion

            #region Task a
            Met(a, b); 
            #endregion

            #region Task b
            int res = 0;
            Sum(a, b, ref res);
            Console.Write($"\nResult: {res}");
            #endregion

            Console.ReadLine();
        }
    }
}
