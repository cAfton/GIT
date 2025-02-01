using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para_2
{

    public class City
    {
        public string CityName { get; set; }
        public string CityPhoneCode { get; set; }
        public string Country { get; set; }
        public int NumberOfPeople { get; set; }
        public List<string> RayonName { get; set; }
        public City(string cityName, string cityPhoneCode, string country, int numberOfPeople, List<string> rayonName)
        {
            CityName = cityName;
            CityPhoneCode = cityPhoneCode;
            Country = country;
            NumberOfPeople = numberOfPeople;
            RayonName = rayonName;
        }
        public City()
        {
            CityName = "";
            CityPhoneCode = "cityPhoneCode";
            Country = "country";
            NumberOfPeople = 0;
            RayonName = new List<string>();
        }
        public override string ToString()
        {
            string vse = $"Name: {CityName}\nCountry: {Country}\nCity's phone number: {CityPhoneCode}\nNumber of puople: {NumberOfPeople}\nDistrict name: ";
            for (int i = 0; i < RayonName.Count; i++)
            {
                vse += RayonName[i].ToString();
                vse += ", ";
            }
            return vse;
        }
        public void ReadFromConsole()
        {
            Console.WriteLine("Enter city\'s name: ");
            CityName = Console.ReadLine();
            Console.WriteLine("Enter city\'s phone: ");
            CityPhoneCode = Console.ReadLine();
            Console.WriteLine("Enter country: ");
            Country = Console.ReadLine();
            Console.WriteLine("Enter number of puople: ");
            NumberOfPeople = int.Parse(Console.ReadLine());
            bool True = true;
            int i = 0;
            while (True)
            {
                Console.WriteLine("You want to continue?(0 - no)(1 - yes)");
                if (int.Parse(Console.ReadLine()) == 0)
                {
                    True = false;
                }
                else
                {
                    Console.WriteLine("Enter district name: ");
                    RayonName.Add(Console.ReadLine());
                }
            }

        }
    }


        internal class Program
    {
        static void Main(string[] args)
        {
            City first = new City();
            first.ReadFromConsole();
            Console.WriteLine(first.ToString());
            Console.ReadLine();
        }
    }
}
