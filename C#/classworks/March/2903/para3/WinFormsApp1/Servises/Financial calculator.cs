using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;

namespace WinFormsApp1.Servises
{
    static public class Financial_calculator
    {
        static public LoanModel LoanCalculation(double Sum, double Percentages, int Time)
        {
            LoanModel loanModel = new LoanModel();
            loanModel.Sum = Sum + Sum * Percentages;
            loanModel.OverPayment = Percentages * Sum;
            loanModel.MonthlyPayment = loanModel.Sum / Time;
            Logger.Instance.CreateLog($"Calculation loan for {Sum}$ with {Percentages}% for {Time} months");
            return loanModel;
        }
        static public decimal CurrencyConverter(decimal Sum, decimal rate)
        {
            Logger.Instance.CreateLog($"Currency converter: {Sum}");
            return Sum*rate;
        }
        /// <summary>
        /// Deposit calculation
        /// </summary>
        /// <param name="Sum"></param>
        /// <param name="Time"></param>
        /// <param name="isAnnual">Annual rate if true/Monthly rate if false</param>
        /// <param name="Percentages"></param>
        /// <returns></returns>
        static public decimal DepositCalculator(decimal Sum, int Time, bool isAnnual, double Percentages)
        {
            decimal tmp = Sum * (decimal)Math.Pow((1 + Percentages), (isAnnual == true)? Time/12:Time);
            Logger.Instance.CreateLog(tmp.ToString());
            return tmp;
        }
    }
}
