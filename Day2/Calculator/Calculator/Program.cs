using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            int total;
            total = num1 + num2;
            return total;
        }
        public int Equation(int y) {
            int a;
            a = (y * y) + (2 * y) + 1;
            return a;
            
        }
        public void tryParsing()
        {
            string val = "null";
            string val1 = "101.11";
            string val2 = "999";
            int result;
            bool ifSuccess = int.TryParse(val, out result);
            Console.WriteLine("{0} => {1}", ifSuccess, result);
            bool ifSuccess1 = int.TryParse(val1, out result);
            Console.WriteLine("{0} => {1}", ifSuccess1, result);
            bool ifSuccess2 = int.TryParse(val2, out result);
            Console.WriteLine("{0} => {1}", ifSuccess2, result);
            }
        public static void Main()
        {
            Console.WriteLine("Enter: \n1. To add two numbers \n2. For equation \n3. For array \n4. For TryParsing \n5.For ArrayCount \n6. Find elements by first letter \n7. Combine number arrays" +
                "\n8. Sort array \n9. Sort array based on category");
            int num= Convert.ToInt32(Console.ReadLine());
            Program ob = new Program();
            switch (num)
            {
                case 1:
                    Console.Write("Enter a number: ");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter another number: ");
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nThe sum of two numbers is : {0} \n", Sum(n1, n2));
                    break;

                case 2:
                    Boolean b = true;
                    while (b)
                    {
                        Console.Write("Input the value of y : (Enter 'q' to quit)");
                        string input = Console.ReadLine();
                        try
                        {

                            if (input == "q")
                            {
                                //Environment.Exit(0);
                                //break;
                                b = false;
                            }
                            else
                            {
                                
                                int y = Convert.ToInt32(input);
                                int x = ob.Equation(y);
                                Console.WriteLine("Value of x: " + x);
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Integer input is required");
                        }
                    }
                    break;
                case 3:
                    Class1 obj = new Class1();
                    obj.arryRelated();
                    break;

                case 4:
                    ob.tryParsing();
                    break;
                case 5:
                    string[] animals = { "Cat", "Alligator", "fox", "donkey", "Cat", "alligator" };
                    var totalCats = animals.Count(s => s == "Cat");
                    Console.WriteLine(totalCats);

                    var animalsStartsWithA = animals.Count(s => s.StartsWith("a", StringComparison.CurrentCultureIgnoreCase));
                    Console.WriteLine(animalsStartsWithA);

                    int[] nums = { 1, 2, 3, 4, 3, 55, 23, 2, 5, 6, 2, 2 };
                    var totalEvenNums = nums.Count(n => n % 2 == 0);
                    Console.WriteLine(totalEvenNums);
                    break;
                case 6:
                    string[] names = { "Steve", "Bill", "James", "Mohan", "Salman", "Boski" };

                    string[] result = Array.FindAll(names, element => element.StartsWith("B"));
                    Console.WriteLine("[{0}]", string.Join(", ",result));
                   
                    break;

                case 7:
                    int[] num1 = { 1, 2, 3, 4, 3, 55, 23, 2 };
                    int[] num2 = { 55, 23, 45, 50, 80 };

                    var all = num1.Union(num2).ToArray();
                    Array.ForEach(all, n => Console.WriteLine(n));
                    break;
                case 8:
                    int[] numbers = { 2, 1, 4, 3 };
                    String[] numberNames = { "two", "one", "four", "three" };

                    Array.Sort(numbers, numberNames);

                    Array.ForEach<int>(numbers, n => Console.WriteLine(n));
                    Array.ForEach<string>(numberNames, s => Console.WriteLine(s));
                    break;
                case 9:
                    SortClass obj3 = new SortClass();
                    obj3.SortOnCategory();
                    break;

            }


           // Program ob = new Program();
            //ob.tryParsing();
            Object MyObj = 30;
            int i = (int)MyObj;
            //Console.WriteLine(i);
           
            Console.ReadLine();
        }
    }
}
