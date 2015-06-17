using System;
class Program
{
    public static void Main()
    {
       int[][] numbers = new int[5][];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new int[i + 5];
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Length of row {0} is {1}", i, numbers[i].Length);
        }
        Console.Read();
    }
}