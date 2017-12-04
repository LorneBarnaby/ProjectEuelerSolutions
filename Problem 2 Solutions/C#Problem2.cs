using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int num = 0;
            for(int i = 0; num < 4000000; i++)
            {
                num = fib(i);
                if(num % 2 == 0)
                {
                    total += num;
                }
            }
            Console.Write(total);
            Console.Read();
        }

        public static int fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return fib(n - 1) + fib(n - 2);
            }
        }
    }
}
