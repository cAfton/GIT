using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human.Models
{
    internal class Pilot: Humen
    {
        public int PlaneId {  get; set; }
        public int RedBullInBlood {  get; set; }

        public int ButtonValue {  get; set; }

        public override int Pahat(int WorkTime)
        {
            if (RedBullInBlood < 100)
            {
                int Salaty = WorkTime * ButtonValue - RedBullInBlood;
                return Salaty;
            }
            else
            {
                Console.WriteLine("He is dead");
                return 0;
            }
        }

    }
}
