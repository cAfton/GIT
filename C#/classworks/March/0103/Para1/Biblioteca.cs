using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para1
{
    public class HandWrite
    {
        public string Name {  get; set; }

        public string Author { get; set; }   

        public string Ganre {  get; set; }

        public int PublishYear { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nAuthor: {Author}\nGanre: {Ganre}\nPublish year: {PublishYear}";
        }
    }

    public class Book: HandWrite
    {

    }

    public class Magasine: HandWrite
    {
        public int NumberOfPublish {  get; set; }

        public override string ToString()
        {
            return base.ToString() + $"\nNumber of publishing: {NumberOfPublish}";
        }
    }


    public class Biblioteca<T> : IEnumerable<T> where T : HandWrite
    {
        public List<T> books { get; set; }
        public IEnumerator<T> GetEnumerator()
        {
            //for (int i = 0; i < books.Count; i++)
            //{
            //    yield return books[i];
            //}
            return books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public List<T> FindGanre(string findGanre)
        {

            List<T> list = books.FindAll(elem => findGanre == elem.Ganre);
            
            return list;
        }

        public IEnumerable<T> FindYear(int findYear)
        {
            return books
                .Where(elem => elem.PublishYear == findYear)
                .OrderBy(elem => elem.PublishYear);
        }

        public IEnumerable<T> FindYearIteratated(int findYear)
        {
            List<T> list = books
                .Where(elem => elem.PublishYear == findYear)
                .OrderBy(elem => elem.PublishYear)
                .ToList();

            foreach (var item in list)
            {
                yield return item;
            }
        }

        public IEnumerator<T> FindYearIterator(int findYear)
        {
            List<T> list = books
                .Where(elem => elem.PublishYear == findYear)
                .OrderBy(elem => elem.PublishYear)
                .ToList();

            return list.GetEnumerator();
        }
    }
}
