using System.Linq.Expressions;
using System.Reflection;

namespace task2
{

    public class Magazine
    {
        public string Name { get; set; }

        public string Genre { get; set; }
        public int Pages { get; set; }
        public DateTime Time { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Magazine> magazines = new List<Magazine>
            {
                new Magazine { Name = "Political Weekly", Genre = "Politics", Pages = 50, Time = new DateTime(2024, 3, 1, 14, 30, 0) },
                new Magazine { Name = "Fashion Trends", Genre = "Fashion", Pages = 80, Time = new DateTime(2024, 2, 15, 10, 45, 0) },
                new Magazine { Name = "Sports Illustrated", Genre = "Sports", Pages = 100, Time = new DateTime(2024, 1, 20, 18, 20, 0) },
                new Magazine { Name = "Garden Life", Genre = "Garden", Pages = 60, Time = new DateTime(2023, 12, 5, 9, 10, 0) },
                new Magazine { Name = "Fishing", Genre = "Fishing", Pages = 90, Time = new DateTime(2023, 11, 25, 16, 55, 0) },
                new Magazine { Name = "Hunting", Genre = "Hunting", Pages = 90, Time = new DateTime(2023, 11, 25, 16, 55, 0) }

            };

            if (magazines.All(elem => elem.Pages > 30))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            if (magazines.All(elem => elem.Genre == "Politics" || elem.Genre == "Fashion" || elem.Genre == "Sports"))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            if(magazines.Any(elem => elem.Genre == "Garden" && elem.Genre == "Backyard"))
            {
                Console.WriteLine(true);
            }
            else 
            { 
                Console.WriteLine(false);
            }

            if (magazines.Any(elem => elem.Genre == "Fishing"))
            {
                Console.WriteLine(true);
            }
            else 
            {
                Console.WriteLine(false);
            }

            if(magazines.Contains(magazines.FirstOrDefault(elem => elem.Genre == "Hunting")))
            {
                Console.WriteLine(true);
            }
            else
            { 
                Console.WriteLine(false); 
            }

            if (magazines.FirstOrDefault(elem => elem.Time.Year == 2022) != null)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            if (magazines.LastOrDefault(elem => elem.Name.StartsWith("Auto")) != null)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

        } 
    }
}
