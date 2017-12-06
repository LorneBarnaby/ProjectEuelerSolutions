using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3cs
{
    class Program
    {
        public static long number = 600851475143;
        public static List<long> divisors = new List<long>();
        public static List<long> primeDivisors = new List<long>();
        static void Main(string[] args)
        {
            getDivs(number);
            getPrimes();
            primeDivisors.Sort();
            Console.WriteLine(primeDivisors[primeDivisors.Count - 1]);
            Console.Read();
        }

        public static void getDivs(long n)
        {
            double half = n / 2; //as in every other one of these that i have written i would recommend changing that 2 to 87million (double half = n / 87000000;)
            for (long i = 1; i < Math.Floor(half); i++)
            {
                if(n % i == 0)
                {
                    divisors.Add(i);
                    //Console.WriteLine(i);
                }
            }
        }

        public static void getPrimes()
        {
            foreach(long num in divisors)
            {
                if (isPrime(num))
                {
                    primeDivisors.Add(num);
                }
            }
        }

        public static bool isPrime(long n)
        {
            if (n <= 1)
            {
                return false;
            }
            else if (n <= 3)
            {
                return true;
            }
            else if ((n % 2 == 0) || (n % 3 == 0))
            {
                return false;
            }
            var i = 5;
            while (i * i <= n)
            {
                if ((n % i == 0) || (n % (i + 2) == 0))
                {
                    return false;
                }
                i += 6;
            }
            return true;
        }

      
    }
}
