using System;

public class Program
{
   public static void Main(string[] args)
   {

      Books Book1 = new Books();   
      Books Book2 = new Books();  

      Book1.getValues("c#","complete reference", "structures",6495407);
      Book2.getValues("pragmatic programming","Mike", "pragmatic programmer", 6495700);

      Book1.display();
      Book2.display(); 
      Console.ReadKey();

   }
}
struct Books
{
   private string title;
   private string author;
   private string subject;
   private int book_id;
   public void getValues(string t, string a, string s, int id)
   {
      title = t;
      author = a;
      subject = s;
      book_id = id;
   }
   public void display()
   {
      Console.WriteLine("Title : {0}", title);
      Console.WriteLine("Author : {0}", author);
      Console.WriteLine("Subject : {0}", subject);
      Console.WriteLine("Book_id :{0}", book_id);
   }

};  