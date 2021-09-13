using System;

namespace OOPS
{
    class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Shape()
        {
            Console.WriteLine("Super constructor is called");
        }

    }

    class Triangle : Shape
    {
        string kind;
        static long DateOfCreation;
        static Triangle() //Initialization
        {
            DateOfCreation = DateTime.Now.Ticks;
            Console.WriteLine("Called once");
        }
        public Triangle(double Width1, double v2): this(Width1)
        {
            
            Height = v2;
                      
        }

        public Triangle(double Width1): base()//parameterized constructor
        {
           Width = Width1;
            

        }
        public double Width { get; set; }
        public double Height { get; set; }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            BasicsOfInheritence();
            
        }

        private static void BasicsOfInheritence()
        {
            new Shape(); //ready for GC
            Triangle t1 = new Triangle(12.3, 34.0);
            Shape t2 = t1;

            new Triangle(12.3, 34.0);
            //new Triangle(); //can't create objects from static constructor
            Console.WriteLine(t1 == t2);

            Triangle triangleWithWidth = new Triangle(50.7);
            Console.WriteLine(triangleWithWidth.Width);
            Console.ReadLine();
        }
    }
}

//singleton design patterns