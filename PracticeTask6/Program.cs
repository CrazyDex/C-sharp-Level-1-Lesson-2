using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask6
{
    class Program
    {
        static uint Factorial(uint n)
        {
            uint res = 1;
            for (uint i = 0; i <= n; i++)
                if (i == 0)
                    res = 1;
                else
                    res *= i;
            return res;
        }

        static uint FactRecursion(uint n)
        {
            if (n == 0) return 1;
            else return FactRecursion(n - 1) * n;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            uint n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(FactRecursion(n));
            Console.ReadKey();
        }
    }
}
