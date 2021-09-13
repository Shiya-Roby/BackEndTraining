using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class RefAndOutDemo
    {
        
        public static void Main(string[] values)
        {
            //OutDemo();
            RefDemo();
            Console.Read();
        }

        private static void RefDemo()
        {
            string str1 = "Rahul";
            SetValue(ref str1);
        }

        private static void OutDemo()
        {
            int result;
            bool returnedValue = Add(out result);
            Console.WriteLine(returnedValue);
            Console.WriteLine(result);
           
        }

        static void SetValue(ref string str)
        {
            str = "Shiya";
        }

        public static bool Add(out int a)
        {
            a = 20;
            a=a+ a;
            return true;


        }
    }
}
