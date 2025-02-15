using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human.Models
{
    internal class Humen
    {
        public string Name { get; set; }
        public DateTime BDay { get; set; }

        private int age {  get; set; }
        public int Age { get { return age; } set
            {
                if (BDay.Month < DateTime.Now.Month)
                {
                    age = DateTime.Now.Year - BDay.Year;
                }
                else if(BDay.Month == DateTime.Now.Month)
                {
                    if (BDay.Day > DateTime.Now.Day)
                    {
                        age = DateTime.Now.Year - BDay.Year - 1;
                    }
                    else
                    {
                        age = DateTime.Now.Year - BDay.Year;
                    }
                }
                else
                {
                    age = DateTime.Now.Year - BDay.Year - 1;
                }

                if (age == value)
                {
                    age = value;
                }
            }
        }


        public int RabNumber { get; set; }


        public virtual int Pahat(int WorkTime)
        {
            if (WorkTime <= 8)
            {
                int Salaty = WorkTime * 2;
                return Salaty;
            }
            else
            {
                Console.WriteLine("stop working");
                return 0;
            }
        }
    }


}
