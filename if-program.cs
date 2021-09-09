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

			int i = 10, j = 20;

			if (i > j)
			{
				Console.WriteLine("i is greater than j");
			}

			if (i < j)
			{
				Console.WriteLine("i is less than j");
			}

			if (i == j)
			{
				Console.WriteLine("i is equal to j");
			}
			Console.ReadKey();
		}
    }
}
