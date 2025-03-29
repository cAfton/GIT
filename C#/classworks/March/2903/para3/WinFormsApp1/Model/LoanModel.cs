using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    public class LoanModel
    {
        public double MonthlyPayment {  get; set; }
        public double Sum {  get; set; }
        public double OverPayment { get; set; }

        public override string ToString()
        {
            return $"{MonthlyPayment}, {Sum}, {OverPayment}";
        }
    }
}
