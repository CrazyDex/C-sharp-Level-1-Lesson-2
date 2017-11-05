using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// практическое задание №5 из методички
// эффективность программы


namespace PracticeTask5
{
    class Program
    {
        static bool IsSimple(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            int k = 0;
            for (int i = 2; i < 1000000; i++)
                if (IsSimple(i))
                {
                    k++;
                    //Console.WriteLine("{0} {1}", k, i);
                }
            Console.WriteLine(k);
            Console.WriteLine(DateTime.Now - start);
            Console.ReadKey();
        }
    }
}
