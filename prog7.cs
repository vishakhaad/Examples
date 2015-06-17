using System;
namespace ConsoleApplication1  
{
   class program
   {
      public static void Main(string[] args)
      {
         int[] list = { 34, 72, 13, 44, 25, 30, 10 };
         int[] temp = list;
         Console.Write("Original Array: ");
         foreach (int i in list)
         {
            Console.Write(i + " ");
         }
         Console.WriteLine();
         Array.Reverse(temp);
         Console.Write("Reversed Array: ");
         foreach (int i in temp)
         {
            Console.Write(i + " ");
         }
         Console.WriteLine();
         Array.Sort(list);
         Console.Write("Sorted Array: ");
         foreach (int i in list)
         {
            Console.Write(i + " ");
         }
         Console.WriteLine();
         Console.ReadKey();
      }
   }
}