using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Currency
{
    public class Currency
    {
        public Currency() { }

        public static Dictionary<string, double> exchangeRace = new Dictionary<string, double>()
        {
            ["USD/EUR"] = 1.03,
            ["EUR/GBP"] = 1.24,
            ["USD/GBP"] = 1.27
        };


    }
    public class USD: Currency
    {
        public double money {  get; set; }

        public USD(int m) {
            money = m;
        }

        public static implicit operator USD (int num)
        {
            return new USD(num);
        }
        public USD(EUR eur) {
            money = eur.money * exchangeRace["USD/EUR"];
        }
    }
    public class EUR: Currency
    {
        public double money { get; set; }
        public EUR(int m)
        {
            money = m;
        }
        public static implicit operator EUR(USD num)
        {
            return new EUR(num);
        }
        public EUR(USD usd) {
            money = usd.money / exchangeRace["USD/EUR"];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            USD a = 5;
            EUR b = a;
            Console.WriteLine(b.money);

            Console.ReadLine();
        }
    }
}
