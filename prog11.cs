using System;
namespace ConsoleApplication1
{
  class Program
   {
       abstract class Draw 
       {
           public abstract double findArea(); 
       }
       class Circle : Draw
       {
           double radius = 0;
           public Circle(double r)
           {
               radius = r;
           }
           public override double findArea()  
           {
               return Math.PI * radius * radius;
           }
       }
        static void Main()
       {
           Circle c1 = new Circle(5);
           Console.WriteLine("Area = " + c1.findArea());
           Circle c2 = new Circle(7);
           Console.WriteLine("Area = " + c2.findArea()); 
	   }
   }
}