using System.Collections;
using System.Numerics;

namespace Para1
{


    public class mafuncu //Мафинки
    {
        public string name {  get; set; }

        public int size {  get; set; }

        public mafuncu()
        {
            name = "Mafunku!";
            size = 0;
        }

    }

    public class Garage : IEnumerable<mafuncu>     //клас Гараге
    {
        public List<mafuncu> cars { private get; set; } = new List<mafuncu>();

        public IEnumerator<mafuncu> GetEnumerator()
        {
            for (int i = 0; i < cars.Count; i++)
            {
                yield return cars[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    


    internal class Program
    {
        static void Main(string[] args)
        {
            Garage gar = new Garage()
            {
                cars = new List<mafuncu>() { new mafuncu(), new mafuncu(), new mafuncu()}
            };


            foreach (var car in gar)
            {
                Console.WriteLine($"{car.name}, {car.size}");
            }

            Biblioteca<HandWrite> library = new Biblioteca<HandWrite>() { books = new List<HandWrite>() { 
                new Book() {Name = "name1", Author = "Author1", Ganre = "Ganre1", PublishYear = 2000 }, 
                new Book() {Name = "name12", Author = "Author3", Ganre = "Ganre2", PublishYear = 2012 }, 
                new Book() {Name = "name13", Author = "Author3", Ganre = "Ganre3", PublishYear = 2019 }, 
                new Book() {Name = "name14", Author = "Author3", Ganre = "Ganre2", PublishYear = 2023 }, 
                new Book() {Name = "name15", Author = "Author1", Ganre = "Ganre4", PublishYear = 2007 }, 
                new Magasine() {Name = "name2", Author = "Author2", Ganre = "Ganre2", PublishYear = 2000, NumberOfPublish = 12}, 
                new Magasine() {Name = "name3", Author = "Author1", Ganre = "Ganre3", PublishYear = 2011, NumberOfPublish = 13}, 
                new Magasine() {Name = "name4", Author = "Author1", Ganre = "Ganre4", PublishYear = 2014, NumberOfPublish = 14}, 
                new Magasine() {Name = "name5", Author = "Author2", Ganre = "Ganre5", PublishYear = 2020, NumberOfPublish = 15}, 
                new Magasine() {Name = "name6", Author = "Author1", Ganre = "Ganre2", PublishYear = 2020, NumberOfPublish = 16}, 
                new Magasine() {Name = "name7", Author = "Author2", Ganre = "Ganre1", PublishYear = 2011, NumberOfPublish = 17}, 
            } };

            foreach (var item in library)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

            List<HandWrite> list = library.FindYear(2000);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            foreach (var item in library.FindYearIteratated(2000))
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
            var iterator = library.FindYearIterator(2000);
            do
            {
                Console.WriteLine(iterator.Current);
            } while (iterator.MoveNext());

            Console.ReadLine();
        }
    }
}
