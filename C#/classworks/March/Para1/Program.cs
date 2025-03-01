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
        public List<mafuncu> cars {  get; set; } = new List<mafuncu>();

        public IEnumerator<mafuncu> GetEnumerator()
        {
            for (int i = 0; i < cars.Count; i++)
            {
                yield return cars[i];
            }
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
            Garage gar = new Garage()
            {
                cars = new List<mafuncu>() { new mafuncu(), new mafuncu(), new mafuncu()}
            };
            
            




            foreach (var car in gar.cars)
            {
                Console.WriteLine($"{car.name}, {car.size}");
            }
            Console.ReadLine();
        }
    }
}
