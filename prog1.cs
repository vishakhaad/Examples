using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("hello world");
            Console.WriteLine("hello world");
            Console.Write("99");
            Console.WriteLine("the sum of {0} and {1} is {2}", 100, 30, 100 + 30);
            Console.ReadKey();
            Console.WriteLine(@"\servershare");
            Console.WriteLine("Currency formatting – {0:C} ", 88.8);
            string input = Console.ReadLine();
            Console.Write("{0}",input);
            int a = Console.Read();
            Console.WriteLine("{0}", a);
            
        }
    }
}
