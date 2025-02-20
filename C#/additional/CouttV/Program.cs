using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            _ = cout << "HHHH";
            Console.ReadLine();
        }
    }
}
