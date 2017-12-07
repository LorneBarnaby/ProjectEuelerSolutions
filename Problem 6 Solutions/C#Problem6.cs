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
            var sumto = 100;
            int totsumto = 0;
            int totsumtosqr;
            var sqrOfAllFrom1Tosumto = 0;

            for (int i = 1; i <= sumto; i++)
            {
                totsumto += i;
            }
            totsumtosqr = Convert.ToInt32(Math.Pow(totsumto, 2));
            for (int i = 1; i <= sumto; i++)
            {
                sqrOfAllFrom1Tosumto += Convert.ToInt32(Math.Pow(i, 2));
            }
            Console.WriteLine(totsumtosqr - sqrOfAllFrom1Tosumto);
            Console.Read();
        }
    }

}
