using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AnonimFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, string> Even = (elem) => {
                if (elem % 2 == 1)
                {
                    return "Not PaReNe";

                }
                else { return "PaReNe"; }

            };
            Console.WriteLine(Even(5));
            Console.ReadLine();
        }
    }
}
