using System.Collections;
using System.Numerics;

namespace Para1
{


    public class mafuncu //Мафинки
    {
        public string name {  get; set; }

        public int size {  get; set; }

        mafuncu()
        {
            name = "Mafunku!";
            size = 0;
        }

    }

    public class Garage : IEnumerable<mafuncu>     //клас Гараге
    {
        public List<mafuncu> cars {  get; set; } = new List<mafuncu>();

        public IEnumerator<mafuncu> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
