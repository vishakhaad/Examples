namespace ConsoleApplication1
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Some Random Numbers that are generated are : ");
            Random r = new Random();
            for (int i = 1; i < 10; i++)
            {
                int n = r.Next(1,9);
                Console.WriteLine(n);
                Console.ReadLine();
            }
        }
    }
}