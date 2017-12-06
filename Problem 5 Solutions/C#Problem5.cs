using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p5cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var j = 20;
            while (true)
            {
                if (divisibleBy1To(20, j))
                {
                    break;
                }
                else
                {
                    j += 20;
                }
            }
            Console.WriteLine(j);
            Console.Read();
        }
        public static bool divisibleBy1To(int rangeOf, int n)
        {
            for (int i = 1; i < rangeOf; i++)
            {
                if (n % i == 0)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }

}
