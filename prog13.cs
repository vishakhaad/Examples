using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the rank list of players\n");
            Player obj = new Player();
            obj.AcceptDetails();
            obj.CompareDetails();
            obj.PrintDetails();
            Console.ReadKey();
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Player
    {
        public int temp = 0, index = 0;
        public int number = 0;
        string[] playerName = new string[10];
        int[] gamePoint = new int[10];
        
        public void AcceptDetails()
        {
            Console.WriteLine("Enter the number of players:");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine("enter {0} player name :", i);
                playerName[i] = Console.ReadLine();
                Console.WriteLine("enter {0} Lap time :", i);
                gamePoint[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(" The entered details of the player are :");
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine("\n", i);
                Console.WriteLine("player name:{0}", playerName[i]);
                Console.WriteLine("gamePoint Time:{0}", gamePoint[i]);
            }
            Console.WriteLine("\nPress Any key to proceed..");
            Console.ReadKey();
        }
        
        public int CompareDetails()
        {
            temp = gamePoint.Max();
            return temp;
        }

        
        public void PrintDetails()
        {
            int num = temp;
            int index = Array.IndexOf(gamePoint, num);
            Console.WriteLine(" The winner is :{0}", playerName[index]);
            Array.Sort(gamePoint);
            Array.Sort(gamePoint,playerName);
            for (int i = 0; i <= number; i++)
                Console.WriteLine("The Rank listing is : {0}:{1}", gamePoint[i],playerName[i]);
        }
    }
}
