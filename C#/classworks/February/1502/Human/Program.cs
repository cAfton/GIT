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
                    RabNumber = 11,
                    Age = 24
                },
                new Pilot()
                {
                    Name = "Ed",
                    BDay = new DateTime(1990, 2, 28),
                    RabNumber = 123,
                    Age = 14
                },
                new Sailor()
                {
                    Name = "Edvard",
                    BDay = new DateTime(1978, 9, 12),
                    RabNumber = 14,
                    job = seaJobs.Capitan,
                    seaName = "Black",
                    YearsInside = 34,
                    Age = 234
                },
                new Sailor()
                {
                    Name = "Pedro",
                    BDay = new DateTime(2012, 7, 8),
                    RabNumber = 1130,
                    job = seaJobs.Alcoholyk,
                    seaName = "Black",
                    YearsInside = 13,
                    Age = 3
                },
                new Builder
                {
                    Name = "Padre",
                    BDay = new DateTime(2008, 3, 11),
                    RabNumber = 1,
                    Id = 443,
                    PlantName = "KFA",
                    CarryingCapacity = 44,
                    Age = 1
                }

            };

            Array nani = new Array { HumanList = PlantWorkers };

            nani.SortDesc();

            Humen humen = new Humen()
            {
                RabNumber = 434892,
            };

            var elem = humen.GetType().GetProperty("RabNumber").GetValue(humen);
            
            humen.GetType().GetField("TryConst").SetValue(humen, (object)5);

            int num = (int)elem;

            //Console.WriteLine(num);

            var elem1 = humen.GetType().GetProperty("RabNumber").PropertyType;
            
            Console.WriteLine(humen.Ret());

            foreach (var item in nani)
            {
                Console.WriteLine( item.ToString());
            }
            Console.ReadLine();
        }
    }
}
