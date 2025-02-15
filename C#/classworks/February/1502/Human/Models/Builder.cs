using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human.Models
{
    internal class Builder: Humen
    {
        public int Id {  get; set; }
        public string PlantName { get; set; }

        public int CarryingCapacity {  get; set; }

        public override int Pahat(int workTime)
        {
            if (DateTime.Now.Hour < 23 || DateTime.Now.Hour > 7)
            {
                int Salary = CarryingCapacity * workTime;
                return Salary;
            }
            else
            {
                return 0;
            }
        }
    }
}
