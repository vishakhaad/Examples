using System;
namespace ConsoleApplication1
{
   class program
   {
      double getAverage(int[] arr, int size)
      {
         int i;
         double avg;
         int sum = 0;
         for (i = 0; i < size; ++i)
         {
            sum += arr[i];
         }
         avg = (double)sum / size;
         return avg;
      }
      
      public static void Main(string[] args)
      {
         MyArray app = new MyArray();
         int [] balance = new int[]{1000, 2, 3, 17, 50};
         double avg;
         avg = app.getAverage(balance, 5 ) ;
         Console.WriteLine( "Average value is: {0} ", avg );
         Console.ReadKey();
      }
   }
}