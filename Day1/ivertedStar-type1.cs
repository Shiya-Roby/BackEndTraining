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

            int i, j, k = 0;
            for (i = 7; i >= 1; i--)
            {
                
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
		}
	}
}
