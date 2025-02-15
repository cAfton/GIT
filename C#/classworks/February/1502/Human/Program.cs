using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Human.Models;

namespace Human
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Humen> PlantWorkers = new List<Humen>()
            {
                new Humen()
                {
                    Name = "Bib",
                    BDay = new DateTime(2000, 6, 20),
                    RabNumber = 11234,
                    Age = 24
                },
                new Pilot()
                {
                    Name = "Ed",
                    BDay = new DateTime(1990, 2, 28),
                    RabNumber = 12341,
                    Age = 14
                },
                new Sailor()
                {
                    Name = "Edvard",
                    BDay = new DateTime(1978, 9, 12),
                    RabNumber = 11234,
                    job = seaJobs.Capitan,
                    seaName = "Black",
                    YearsInside = 34,
                    Age = 234
                },
                new Sailor()
                {
                    Name = "Pedro",
                    BDay = new DateTime(2012, 7, 8),
                    RabNumber = 11230,
                    job = seaJobs.Alcoholyk,
                    seaName = "Black",
                    YearsInside = 13,
                    Age = 3
                },
                new Builder
                {
                    Name = "Padre",
                    BDay = new DateTime(2008, 3, 11),
                    RabNumber = 11231,
                    Id = 443,
                    PlantName = "KFA",
                    CarryingCapacity = 44,
                    Age = 1
                }

            };

            Console.WriteLine(PlantWorkers[0].Age);

            Console.ReadLine();
        }
    }
}
