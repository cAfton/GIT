using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human.Models
{
    public enum seaJobs
    {
        Alcoholyk,
        Sanitazer,
        Capitan,
        Lox
    }
    internal class Sailor: Humen
    {
        public string seaName {  get; set; }

        public int YearsInside { get; set; }

        public seaJobs job { get; set; }

        public override int Pahat(int WorkTime)
        {
            switch (job)
            {
                case seaJobs.Alcoholyk:
                    int Salary = WorkTime * -1;
                    return Salary;
                case seaJobs.Sanitazer:
                    Salary = WorkTime * 2 * YearsInside;
                    return Salary;
                case seaJobs.Capitan:
                    Salary = YearsInside * WorkTime * 100;
                    return Salary;
                case seaJobs.Lox:
                    Salary = WorkTime * 0 + YearsInside;
                    return Salary;
                default:
                    return 0;
            }
        }
    }
}
