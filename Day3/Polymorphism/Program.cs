using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    enum role
    {
        Developer, Delivery_Manager
    }
    class User
    {
        public string name { get; }//read only
        public const int age = 10; //instance count
        public role role;    //developer, PM, delivery manager, thief
        public User(string name)
        {
            const int age = 100; //local constant
           
            this.name = name;
        }
        static int COUNT;
        static User()
        {
            Console.WriteLine("static called");
        }

        public User()
        {
        }

        
        public virtual void Enter()
        {
            Console.WriteLine("user constructor {0}", User.age);
            Console.WriteLine("1");
        }
    }

    class Employee : User
    {
        public Employee(string name) : base(name)
        {
            Console.WriteLine("emp");
        }
        
        public new void Enter()
        {
            Console.WriteLine("2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Rahul");
            e1.role = role.Delivery_Manager;
            Console.WriteLine((int)e1.role);
            string strRole = role.Delivery_Manager.ToString();
            Console.WriteLine(strRole);
            e1.Enter();
            Console.WriteLine(e1.name);
            User u1 = new User();
            u1.Enter();
            Console.ReadLine();

        }
    }
}
