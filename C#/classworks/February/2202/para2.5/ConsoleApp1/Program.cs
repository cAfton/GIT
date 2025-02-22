using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public static class ExtensionMethod
    {
        public static bool isOdd(this Int32 elem) 
        {
            return (elem % 2) == 0;
        }

        public static int sentensusCounter(this string elem)
        {
            char[] chars = { '.', '?', '!' };
            return elem.Split(chars).Length - 1;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;

            Console.WriteLine(number.isOdd());

            string text = "Я люблю читати книги. А ти? Сонце світить яскраво, але вітер все ще холодний. Ми пішли в парк; там було дуже красиво. Не забудь купити хліб! Молоко теж візьми. Це неймовірно — я просто не можу повірити!";

            Console.WriteLine(text.sentensusCounter());

            Console.ReadLine();

        }
    }
}
