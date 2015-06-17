using System;

namespace ConsoleApplication1
{
    class ClassConversion
    {
      public static void Main(string[] args)
      {
       char a;
       int b;
       Console.WriteLine("Enter A Letter Between a-z:");
       a = Convert.ToChar(Console.ReadLine());
       b = (int)a;
       
       if (b >= 97 && b <= 122)
        {
           b = b - 32;
           a = (char)b;
           Console.WriteLine("In Upper Case Letter:{0}", a);
        }
        else
        {
            b = b + 32;
            a = (char)b;
            Console.WriteLine("In lower case letter :{0}", a);
           //Console.WriteLine("You Enter Wrong Letter, Please Enter Letter Between a-z....!");
        }
        Console.ReadKey();
        }

    }

}
