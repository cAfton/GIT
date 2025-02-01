using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para_3
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
        public double CalculateSalary(double stavka, double days)
        {
            double salary = days / CountDays * stavka;
            return salary;
        }

        public double CalculateSalary(double stavka, int hours)
        {
            double salary = hours * stavka;
            return salary;
        }
        public double CalculateSalary(double stavka, int hours, double premia)
        {
            double salary = hours * stavka + premia;
            return salary;
        }
        public double CalculateSalary(double stavka, double days, double premia)
        {
            double salary = days / CountDays * stavka + premia;
            return salary;
        }

        private const int CountDays = 24;

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Worker rab = new Worker("Oleksii", "Petriv", 16);
            double Calc1 = rab.CalculateSalary(80, -4);
            Console.WriteLine(Calc1);

            double Calc2 = rab.CalculateSalary(5000, 6.0, -300);
            Console.WriteLine(Calc2);
            Console.ReadLine();
        }
    }
}
}
