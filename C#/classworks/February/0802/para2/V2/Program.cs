using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace V2
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
        public Item(string line) {
            string[] strings = line.Split(';');
            id = int.Parse(strings[0]);
            name = strings[1];

            strings[2].ToLower();
            switch (strings[2])
            {
                case "car":
                    category = Category.car;
                    break;
                case "computer":
                    category = Category.computer;
                    break;
                case "desk":
                    category = Category.desk;
                    break;
                case "box":
                    category = Category.box;
                    break;
                case "food":
                    category = Category.food;
                    break;
                case "slave":
                    category = Category.slave;
                    break;
            }

            try
            {
                description = strings[3];
            }
            catch
            {
                description = null;
            }
        }

        public override string ToString()
        {
            string ret = $"Id: {id}\nName: {name}\nCategory: {category}\nDescription: {description}";
            return ret;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int userChoice = -1;
            List<Item> items = null;
            while (userChoice != 0)
            {
                Console.WriteLine("1 - add new\n2 - delete elem\n3 - upgrade element\n4 - print all\n0 - exit");
                try
                {
                    userChoice = int.Parse(Console.ReadLine());
                }
                catch (FormatException exc)
                {
                    Console.WriteLine(exc.Message);
                }

                switch (userChoice)
                {
                    case 0:
                        return;
                    case 1:
                        if (items == null)
                        {
                            items = new List<Item>();
                        }
                        Item newItem = new Item(Console.ReadLine());
                        items.Add(newItem); 
                        break;
                    case 2:
                        try
                        {
                            int findId = int.Parse(Console.ReadLine());
                            Item? itemDel = items?.Find(elem => elem.id == findId);
                            if (itemDel != null)
                            {
                                items?.Remove(itemDel);
                            }
                            else
                            {
                                Console.WriteLine("invalid id");
                            }
                        }
                        catch (FormatException exc)
                        {
                            Console.WriteLine(exc.Message);
                        }
                        break;
                    case 3:
                        int findIdToChange = int.Parse(Console.ReadLine());
                        Item? itemFind = items?.Find(elem => elem.id == findIdToChange);
                        if (itemFind != null)
                        {
                            Console.WriteLine("Change... \n1 - name\n2 - category\n3 - description");
                            try
                            {
                                userChoice = int.Parse(Console.ReadLine());
                            }
                            catch (FormatException exc)
                            {
                                Console.WriteLine(exc.Message);
                            }
                            switch (userChoice)
                            {
                                case 1:
                                    itemFind.name = Console.ReadLine();
                                    break;
                                case 2:
                                    string elem = Console.ReadLine().ToLower();
                                    try
                                    {
                                        itemFind.category = (Category)Enum.Parse(typeof(Category), elem);
                                    }
                                    catch (ArgumentException)
                                    {
                                        Console.WriteLine("not posible");
                                    }
                                    break;
                                case 3:
                                    itemFind.description = Console.ReadLine();
                                    break;
                            }
                        }
                        break;
                    case 4:
                        try
                        {
                            foreach (var item in items)
                            {
                                Console.WriteLine(item.ToString());
                            }
                        }
                        catch(NullReferenceException)
                        {
                            Console.WriteLine("nothing here");
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
