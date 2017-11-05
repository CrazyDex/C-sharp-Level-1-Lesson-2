using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwT1 // homework task 1
{
    //Евдохин Д.

    // Написать метод возвращающий минимальное из трех чисел.

    class Program
    {
        static void WhoMinRec(List<int> list, int n, int min)
        {
            if (n > 0)
            {
                if (list[n] <= min) { min = list[n]; }
                n--;
                WhoMinRec(list, n, min);
            }
            else
            {
                Console.WriteLine("Наименьшее из чисел: {0}\nОбработано рекурсивным методом", min);
            }
        }
        static void WhoMin()
        {
            Console.WriteLine("Введите сравниваемые числа");
            int[] abc = new int[] {int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())};
            DateTime ts = DateTime.Now;
            int res = abc[0];
            for (int i = 0; i < abc.Length-1; i++)
            {
                res = abc[i] < abc[i + 1] ? abc[i] : abc[i + 1];
            }
            Console.WriteLine("Наименьшее из чисел: {0}\nОбработано обычным методом", res);
            Console.WriteLine(DateTime.Now - ts);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            char x = (char)2020;
            Console.WriteLine(x);

            List<int> list = new List<int>();
            string proverka;
            Console.WriteLine("Вводите сравниваемые числа. Для сравнения введите \"stop\"\n");
            while (true)
            {
                proverka = Console.ReadLine();
                if (proverka != "stop") list.Add (int.Parse(proverka));
                else break;
            }

            //Random random = new Random();

            //for (int i = 0; i < 1000; i++)
            //{
            //    list.Add(random.Next(-1000, 1000));
            //    //Console.WriteLine(list[i]);
            //}

            //DateTime ts = DateTime.Now;
            WhoMinRec(list, list.Count - 1, list[0]); // 1 000 отправляет в рекурсию, при 10 000 уже стек оверфлоу
            //Console.WriteLine(DateTime.Now - ts);

            Console.WriteLine("\n");

            //ts = DateTime.Now;
            int minL = list[0];
            foreach (int znach in list)
            {
                if (znach < minL) { minL = znach; }
            }
            Console.WriteLine("Наименьшее из чисел: {0}\nОбработано foreach\nна обработку 1 000, 10 000, 100 000, 1 000 000,\n10 000 000 значений одинаковое время", minL);
            //Console.WriteLine(DateTime.Now - ts);
            
            Console.WriteLine("\n");

            //ts = DateTime.Now;
            list.Sort();
            Console.WriteLine("Наименьшее из чисел: {0}\nОбработано list.sort()\nПри листе в 10 000 000 работает на 1 сек. дольше фор ича,\nдо 1 000 000 разница вообще не ощущается", list[0]);
            //Console.WriteLine(DateTime.Now - ts);

            Console.WriteLine("\n");

            WhoMin();
            Console.ReadKey();
        }
    }
}
