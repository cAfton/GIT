using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V
{
    public enum Category
    {
        car,
        computer,
        desk,
        box,
        food,
        slave
    }

    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public Category category { get; set; }
        public string? description { get; set; }

        public Item() { }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
