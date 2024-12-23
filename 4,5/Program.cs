using System;
namespace Uppgift_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jämna tal mellan 1 och 20:");

           
            for (int i = 1; i <= 20; i++)
            {
                
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}