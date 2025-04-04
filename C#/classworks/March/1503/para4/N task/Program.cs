using Newtonsoft.Json;
using System.Linq;
using System.Linq.Expressions;

namespace N_task
{

    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Janre { get; set; }
        public int pages { get; set; }
        public int year { get; set; }


        public override string ToString()
        {
            return $"{Name}, {Author}, {Janre}, {pages}, {year}";
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book> ();

            var serializer = JsonSerializer.Create();

            using (JsonTextReader File = new JsonTextReader(new StreamReader("fileJSON.json")))
            {
                books = serializer.Deserialize<List<Book>>(File);

            }


            books.ForEach(elem => Console.WriteLine(elem.ToString()));

            Console.WriteLine(books.Remove(books.FirstOrDefault(elem => elem.Name == "The Hobbit")) ? "Book deleted" : "Book not found");

            Console.WriteLine(books.All(elem => elem.pages > 100) ? "Yes" : "No");
            Console.WriteLine(books.All(elem => elem.Janre == "Fantasy" || elem.Janre == "Dystopian") ? "Yes" : "No");
            Console.WriteLine(books.Any(elem => elem.Janre == "Horror") ? "Yes" : "No");
            Console.WriteLine(books.Any(elem => elem.Author == "Shakespeare") ? "Yes" : "No");
            Console.WriteLine(books.Contains(books.FirstOrDefault(elem => elem.Author == "Byron")) ? "Yes" : "No");
            Console.WriteLine(books.FirstOrDefault(elem => elem.year == 1993)?.ToString());
            Console.WriteLine(books.LastOrDefault(elem => elem.year == 2002)?.ToString());




            using (StreamWriter File = new StreamWriter("fileJSON.json"))
            {
                JsonSerializer.Create().Serialize(File, books);
            }

        }
    }
}
