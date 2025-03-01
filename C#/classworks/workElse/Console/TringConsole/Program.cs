using System.Drawing;

namespace Papa3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ">:3";

            int i = 0;
            while (i < 1000)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(">:3");
                Console.WriteLine("HEHE>:3");
                Thread.Sleep(1000 - i);
                i += 50;
            }
            
        }
    }
}