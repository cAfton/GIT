using Human.Interfaces;
using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human.Models
{
    internal class Humen : IComparable<Humen>
    {
        public const int TryConst = 1;
        public int Ret() {
            return TryConst;
        }
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

        public int CompareTo(Humen other)
        {
            if (this.RabNumber > other.RabNumber)
            {
                return 1;
            }
            else if (this.RabNumber == other.RabNumber)
            {
                return 0;
            }
            else
            {
                return -1;
            }


        }

        public override string ToString()
        {
            return $"{Name}, {RabNumber}";
        }

    }


}
