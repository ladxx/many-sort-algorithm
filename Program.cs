using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 斐波那契
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Feibo(30));
        }
        static int Feibo(int n)
        {
            if (n<=0)
            {
                return 0;
            }else if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return (Feibo(n - 1) + Feibo(n - 2));
            }
        }
    }
}
