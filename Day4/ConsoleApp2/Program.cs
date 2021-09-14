using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_demo
{
    interface IUser
    {
        int a { get; set; }
        void work();
    }
    interface A: IUser { }
    class User: IUser
    {
        public int a { get => a;
            set => a = value;

        }
        public void work()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}