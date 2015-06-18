using System;
namespace ConsoleApplication1
{
   class Box
   {
      private int length;  
      private int breadth;  
      private int height;  
      public int getVolume()
      {
         return length * breadth * height;
      }
     public void setLength( int len )
      {
         length = len;
      }
      public void setBreadth( int bre )
      {
         breadth = bre;
      }
      public void setHeight( int hei )
      {
         height = hei;
      }
      public static Box operator+ (Box b, Box c)
      {
         Box box = new Box();
         box.length = b.length + c.length;
         box.breadth = b.breadth + c.breadth;
         box.height = b.height + c.height;
         return box;
      }
   }
   class Tester
   {
      static void Main(string[] args)
      {
         Box Box1 = new Box();   
         Box Box2 = new Box();   
         Box Box3 = new Box();  
         double volume = 0;   

         Box1.setLength(6);
         Box1.setBreadth(7);
         Box1.setHeight(5);
         
         Box2.setLength(12);
         Box2.setBreadth(13);
         Box2.setHeight(10);

         volume = Box1.getVolume();
         Console.WriteLine("Volume of Box1 : {0}", volume);
         
         volume = Box2.getVolume();
         Console.WriteLine("Volume of Box2 : {0}", volume);
        
         Box3 = Box1 + Box2;
       
         volume = Box3.getVolume();
         Console.WriteLine("Volume of Box3 : {0}", volume);
         Console.ReadKey();
      }
   }
}