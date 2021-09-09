using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 20, y = 10;

            var result = x > y ? "x is greater than y" : "x is less than or equal to y";

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
