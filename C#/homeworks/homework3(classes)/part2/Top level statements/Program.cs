using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Top_level_statements
{

    public class website
    {
        public string name;

        public string url { get; set; }

        public string description { get; set; }

        public string ip { get; set; }

        public website()
        {
            Console.WriteLine("Enter name:");
            this.name = Console.ReadLine();

            Console.WriteLine("Enter url:");
            this.url = Console.ReadLine();

            Console.WriteLine("Enter description:");
            this.description = Console.ReadLine();

            Console.WriteLine("Enter ip:");
            this.ip = Console.ReadLine();
        }

        public void print()
        {
            Console.WriteLine($"{this.name}, url: {this.url}\n{this.description}\nIP:{this.ip}");
        }

    }
        internal class Program
    {

        static void Main(string[] args)
        {
            #region Task 4
            website first = new website();
            website second = new website();
            website third = new website();

            first.print();
            second.print();
            third.print();

            Console.ReadLine();
            #endregion
        }
    }
}
