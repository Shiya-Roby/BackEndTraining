using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User
    {
        public string name { get; set; }
    }
    
    class Class1
    {
        public void createPattern()
        {
            byte b1 = 45;
            //sbyte b2 = 45;
            int a1 = b1; //type casting
            Object obj = new object();
            User user1 = new User();
            obj = user1;
            dynamic dat = 10;
            dat = "Shiya";

            var name = "Welcome";
            var a = 34;
            Console.WriteLine("name = {0} \na = {1}", name, a);

            Console.WriteLine(dat is string);
            Console.WriteLine(typeof(User));
            Console.WriteLine(user1 is User);
            
            Console.ReadLine();
        }
        public int age { get; } = 10;
        private int privateProp = 90;
        //balance
        public int publicName
        {
            get { return privateProp; }
            set {  if (value != 90)
                    Console.WriteLine("wrong value");
                   else
                {
                    privateProp = value;

                }
            }
        }
        

        
    }
}
