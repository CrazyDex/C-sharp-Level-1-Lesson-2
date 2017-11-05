using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwT6
{
    //Евдохин Д.
    
    //*Написать программу подсчета количества “Хороших” чисел в диапазоне от 1 до 1 000 000 000.
    //Хорошим называется число, которое делится на сумму своих цифр.
    //Реализовать подсчет времени выполнения программы, используя структуру DateTime.

    class Program
    {
        static void GoodNumberCount(int range)
        {
            int count = 0, sum = 0;
            int k;
            int ost;

            for (int i = 1; i <= range; i++)
            {
                k = i;
                while (k > 0)
                {
                    Math.DivRem(k, 10, out ost);
                    sum += ost;
                    k /= 10;
                }
                count = i % sum == 0 ? count+1 : count;
                sum = 0;
                //Console.WriteLine(i);
            }
            Console.WriteLine(count);
        }
        // рекорд чуть меньше 3х минут


        static void Main(string[] args)
        {
            int range = 1000000000;
            DateTime dtStart = DateTime.Now;
            GoodNumberCount(range);
            Console.WriteLine(DateTime.Now - dtStart);
            Console.ReadKey();
        }
    }
}
