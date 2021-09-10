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
            takeInputFromConsole();

            ArrayDemo();
            Class1 ob = new Class1(); // Creating Object  
            ob.createPattern();
            

            //Console.ReadKey();
        }

        private static void takeInputFromConsole()
        {
            double IVal = 123.45;
            int iVal = Convert.ToInt32(IVal);
            Console.WriteLine(iVal);

        }

        private static void ArrayDemo()
        {
            int[] array = { 1, 2, 4, 6, 8, 9, 11, 14, 15 };
            var a = from i in array where i % 2 == 0 select i;
            foreach (var _b in a)
            {
                Console.WriteLine("{0}", _b);
                //Console.ReadLine();
            }
        }
    }
}
