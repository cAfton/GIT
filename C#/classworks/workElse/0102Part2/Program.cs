using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0102Part2
{
    public class Worker
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }

        public Worker(string FirstName, string SecondName, int Age)
        {
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.Age = Age;
        }
        public (double, string) CalculateSalary(double stavka, double days)
        {
            double salary = days / CountDays * stavka;

            
            return (salary, "ne premia");
        }

        public (double, string) CalculateSalary(double stavka, int hours)
        {
            double salary = hours * stavka;
            return (salary, "ne premia");
        }
        public (double, string) CalculateSalary(double stavka, int hours, double premia)
        {
            double salary = hours * stavka + premia;
            if (premia > 0)
            {
                return (salary, "premia");
            }
            else
            {
                return (salary, "shtraf");
            }
        }
        public (double, string) CalculateSalary(double stavka, double days, double premia)
        {
            double salary = days / CountDays * stavka + premia;
            return (salary, "premia");
        }

        private const int CountDays = 24;

    }


    internal class Program
    {
        static int calculate()
        {
            Console.WriteLine("write expression: ");
            string line = Console.ReadLine();

            string[] nums = line.Split('*');

            int count = 1;

            foreach (var item in nums)
            {
                count *= int.Parse(item);
            }


            return count;

        }
        static void Main(string[] args)
        {
            Worker rab = new Worker("Oleksii", "Petriv", 16);
            (double, string) Calc1 = rab.CalculateSalary(80, -4);
            Console.WriteLine(Calc1);

            (double, string) Calc2 = rab.CalculateSalary(5000, 6.0, -300);
            Console.WriteLine(Calc2);

            Console.WriteLine(calculate());




            Console.ReadLine();


        }
    }
}
