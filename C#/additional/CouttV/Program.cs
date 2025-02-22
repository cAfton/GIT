using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

namespace CouttV
{
    public class Cout
    {
        public static string operator <<(Cout c, string line)
        {
            Console.WriteLine(line);
            return line;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cout cout = new Cout();

            Console.WriteLine("фф");

            _ = cout << "feregdr";
            Console.ReadLine();
        }
    }
}
