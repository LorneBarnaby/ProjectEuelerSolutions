using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEueler1
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for(int i = 0; i < 1000; i++)
            {
                if((i % 5 == 0) || (i % 3 == 0))
                {
                    total += i;
                }
            }
            Console.WriteLine(total);
            Console.Read();
        }
    }
}
