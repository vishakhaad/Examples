using System;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main()
        {
            Random obj = new Random();
            string[] places = { "london", "usa", "france", "germany", 
                                "swiz" };
            string[] car = { "bmw","volvo","honda","maruti","ferrari","hyundai"};

            for (int i = 1; i < 4; i++)
            {
                int placeindex = obj.Next(0, places.Length);
                int carindex = obj.Next(0, car.Length);
                Console.WriteLine("Suggested pet name of the day: ");
                Console.WriteLine("   best place: {0}", places[placeindex]);
                Console.WriteLine("   best car:   {0}", car[carindex]);
                Console.ReadKey();
            }
           }
        }
}