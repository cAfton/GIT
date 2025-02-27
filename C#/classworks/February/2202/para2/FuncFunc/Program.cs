using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FuncFunc
{
    public class Rab
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int workDays { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}\nWork days: {workDays}";
        }
    }

    public class Observer: IEnumerable
    {
        public string Name { get; set; }

        public int Age { get; set; }
        public List<Rab> rabs { get; set; } = new List<Rab>();

        public IEnumerator GetEnumerator()
        {
            return rabs.GetEnumerator();
        }

        public void sortRabs(Func<Rab, Rab, bool> comparer)
        {
            for (int i = 0; i < rabs.Count; i++)
            {
                for (int j = 0; j < rabs.Count; j++)
                {
                    if (comparer(rabs[i], rabs[j]))
                    {
                        Rab t = rabs[i];
                        rabs[i] = rabs[j];
                        rabs[j] = t;
                    }
                }
            }
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Observer observer = new Observer()
            {
                rabs = new List<Rab> {
                    new Rab { Name = "Oleksii", Age = 16, workDays = 8 },
                    new Rab { Name = "Nazar", Age = 15, workDays = 3 },
                    new Rab { Name = "name2", Age = 1, workDays = 4 },
                    new Rab { Name = "name13", Age = 11, workDays = 76 },
                    new Rab { Name = "name14", Age = -5, workDays = 2 },
                    new Rab { Name = "name5", Age = 7, workDays = 7 },
                    new Rab { Name = "name7", Age = 6, workDays = 0 },
                    new Rab { Name = "name9", Age = 116, workDays = 1 },
                },
                Name = "Viktoriia",
                Age = 16
            };

            observer.sortRabs((rab1, rab2) =>
            {
                if (rab1.Name.CompareTo(rab2.Name) == 1)
                {
                    return false;
                }
                return true;
            });

            foreach (var item in observer)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n\n");

            observer.sortRabs((rab1, rab2) =>
            {
                if (rab1.Age.CompareTo(rab2.Age) == 1)
                {
                    return false;
                }
                return true;
            });


            foreach (var item in observer)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n\n");

            observer.sortRabs((rab1, rab2) =>
            {
                if (rab1.workDays.CompareTo(rab2.workDays) == 1)
                {
                    return false;
                }
                return true;
            });

            foreach (var item in observer)
            {
                Console.WriteLine(item);
            }


            observer.rabs = observer.rabs.OrderBy(elem => elem.Name).ToList();

            Console.WriteLine("\n\n\n");
            foreach (var item in observer)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
