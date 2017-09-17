using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Add(4, 8);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static int Add(int num01, int num02)
        {
            return num01 + num02;
        }
    }
}
