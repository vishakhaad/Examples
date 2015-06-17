using System;
namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] array2 = new int[10];
            Console.WriteLine("Array1 Values:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(array1[i]);
                Console.Write(" ");
            }
            int j=9;
            for (int i = 0; i < 10; i++)
            { 
                array2[i]=array1[j];
                j--;
            }
            Console.WriteLine("\n Values of Array2 In Reverse Order:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(array2[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
