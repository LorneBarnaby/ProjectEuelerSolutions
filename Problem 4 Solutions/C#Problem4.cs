using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pE4CS
{
    class Program
    {
        public static List<int> palindromes = new List<int>();
        static void Main(string[] args)
        {
            Start(3);
            palindromes.Sort();
            Console.WriteLine(palindromes[palindromes.Count -1]);
            Console.Read();
        }

        public static void Start(int digs){
            int limit = Convert.ToInt32((Math.Pow(10, digs)-1));
            for(int i = 1; i <= limit; i++)
            {
                for(int j = 1; j <= limit; j++)
                {
                    int product = i * j;
                    if (isPalin(product))
                    {
                        palindromes.Add(product);
                    }
                }
            }
        }

        public static bool isPalin(int n)
        {
            string first = n.ToString();
            char[] firstAsArray = first.ToCharArray();
            Array.Reverse(firstAsArray);
            string reversed = new string(firstAsArray);
            if(first == reversed)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
