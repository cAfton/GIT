using System.Collections.Generic;

namespace Queue
{
    public class News
    {
        public string Article { get; set; }

        public override string ToString()
        {
            return $"Article: {Article} \n";
        }

    }
    public class Pacient
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nDescroption: {Description}\n";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<Pacient, DateTime> queuePacient = new PriorityQueue<Pacient, DateTime>();

            queuePacient.Enqueue(new Pacient() {Name = "name1", Description = "NoDesc" }, new DateTime(2025, 1, 3, 13, 30, 0));
            queuePacient.Enqueue(new Pacient() {Name = "name2", Description = "NoDesc1" }, new DateTime(2025, 1, 3, 14, 30, 0));
            queuePacient.Enqueue(new Pacient() {Name = "name3", Description = "NoDesc2" }, new DateTime(2025, 1, 3, 14, 00, 0));

            while(queuePacient.Count > 0)
            {
                Console.WriteLine(queuePacient.Dequeue());
            }

            PriorityQueue<News, DateTime> queueNews = new PriorityQueue<News, DateTime>(Comparer<DateTime>.Create((a, b) => b.CompareTo(a)));

            queueNews.Enqueue(new News() { Article = "Article1" }, new DateTime(2025, 2, 28, 13, 30, 0));
            queueNews.Enqueue(new News() { Article = "Article2" }, new DateTime(2025, 2, 20, 14, 30, 0));
            queueNews.Enqueue(new News() { Article = "Article3" }, new DateTime(2025, 2, 24, 15, 30, 0));

            while (queueNews.Count > 0)
            {
                Console.WriteLine(queueNews.Dequeue());
            }
        }
    }
}
