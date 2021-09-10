using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{   
        public void Star(int num)
        {
            int i, j, k = 0;
            for (i = num; i >= 1; i--)
            {

                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
		static void Main(string[] args)
		{

            Program program = new Program(); // Creating Object  
            program.Star(7);
            Console.ReadKey();
		}
	}
}
