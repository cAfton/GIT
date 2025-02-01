using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Para_1
{
    public enum posada
    {
        director,
        employee
    }

    public class Rab
    {
        public string PIB { get; set; }

        public DateTime birthday { get; set; }

        public string number {  get; set; }

        public string mail { get; set; }

        public posada posa { get; set; }

        public string needToDO { get; set; }

        public Rab() { }

        public Rab(string pIB, DateTime birthday, string number, string mail, posada posa, string needToDO)
        {
            PIB = pIB;
            this.birthday = birthday;
            this.number = number;
            this.mail = mail;
            this.posa = posa;
            this.needToDO = needToDO;
        }

        public override string ToString()
        {

            string ret = $"pib: {PIB}\nbd: {birthday}\nnumber: {number}\nmail: {mail}\nposada: {posa}\nis doing {needToDO} ";
            return ret;
        }

        public void read(string line)
        {
            string[] strings = line.Split(' ');
            PIB = strings[0];
            birthday = DateTime.Parse( strings[1]);
            number = strings[2];
            mail = strings[3];
            switch (strings[4])
            {
                case "director":
                    posa = posada.director;
                    break;
                case "employee":
                    posa = posada.employee;
                    break;

                default:
                    break;
            }
            needToDO = strings[5];
        }

    }
    public class City
    {
        public string Country { get; set; }

        public string CityName { get; set; }

        public int numberOfHuman { get; set; }

        public int CityPhoneCode { get; set; }

        public List<string> rayonName { get; set; }

        public City(string country, string city, int num, int phone, List<string> rayons) {
            CityName = city;
            CityPhoneCode = phone;
            Country = country;
            numberOfHuman = num;
            rayonName = rayons;
        }

        public City() {
            CityName = "city";
            CityPhoneCode = 1;
            Country = "country";
            numberOfHuman = 1;
        }

        public override string ToString()
        {
            string vse = $"Country: {Country}\nName: {CityName}\nNumber of human: {numberOfHuman}\nPhone code: {CityPhoneCode}\nRayons: ";
            foreach (var item in rayonName)
            {
                vse += $"{item} \n";
            }
            return vse;
        }

        public void read(string line)
        {
            string[] strings = line.Split(' ');
            Country = strings[0];
            CityName = strings[1];
            numberOfHuman = int.Parse(strings[2]);
            CityPhoneCode = int.Parse(strings[3]);
            rayonName = new List<string>();

            string[] rayon = strings[4].Split(',');
            foreach (var item in rayon)
            {
                rayonName.Add(item);
            }
        }

    }

    public class Card
    {
        private string number;
        public string Number
        {
            get => number; set
            {
                if (value.Length == 16)
                {
                    foreach (var item in value)
                    {
                        if (char.IsNumber(item))
                        {
                            number += item;
                        }
                        else
                        {
                            throw new ArgumentException("char is not number");
                        }
                    }
                }
                else
                {
                    throw new ArgumentException("size is not 16");
                }
            }
        }
        public string NameOwner { get; set; }

        private string cvc;

        public string CVC { get=>cvc; set {
            if (value.Length == 3)
            {
                foreach (var item in value)
                {
                    if (char.IsNumber(item))
                    {
                        cvc += item;
                    }
                    else
                    {
                        throw new ArgumentException("char is not number");
                    }
                }
            }
            else
            {
                throw new ArgumentException("size is not 3");
            }
            } }

        private DateTime date;
        public DateTime Date { get=> date; set {
                if (value > DateTime.Now)
                {
                    date = value;
                }
                else
                {
                    throw new ArgumentException("card's time is out");
                }
            
            } }

        private double balance;
        public double Balance{ get=>balance; set {
                if (value >= 0)
                {
                    balance = value;
                }
                else
                {
                    throw new ArgumentException("balance is less than 0");
                }
            } }

        private bool isBlocked { get; set; }

        public Card(string number, string nameOwner, string cVC, DateTime Date, double balance, bool isBlocked)
        {
            Number = number;
            NameOwner = nameOwner;
            CVC = cVC;
            this.Date = Date;
            Balance = balance;
            this.isBlocked = isBlocked;
        }

        public Card() { }

        public void replenishCash(double cash)
        {
            if (!isBlocked)
            {
                Balance += cash;
            }
        }
        public void withdrawCash(double cash)
        {
            if (!isBlocked && Balance - cash >= 0)
            {
                Balance -= cash;
            }
        }

        public void changeAcssec(bool is_blocked)
        {
            isBlocked = is_blocked;
        }

        public override string ToString()
        {
            string ret = $"Number: {Number}\nOwner: {NameOwner}\nCVC: {cvc}\nDate: {Date.Month}/{Date.Year % 100}\nBalance: {Balance}";
            return ret;
        }

        public void read(string line)
        {
            string[] strings = line.Split(',');
            List<string> exceptions = new List<string>();
            try
            {
                Number = strings[0];
            }
            catch (ArgumentException exc) { 
                exceptions.Add(exc.Message);

            }
            NameOwner = strings[1];
            try
            {
                CVC = strings[2];
            }
            catch (ArgumentException exc) {
                exceptions.Add(exc.Message);
            }
            try
            {
                Date = DateTime.Parse(strings[3]);
            }
            catch (ArgumentException exc) {
                exceptions.Add(exc.Message);
            }
            try
            {
                Balance = Double.Parse(strings[4]);
            }
            catch (ArgumentException exc) {
                exceptions.Add(exc.Message);
            }

            if (exceptions.Any())
            {
                string ret = "";
                foreach (var item in exceptions)
                {
                    ret += $"{item} \n";
                }
                throw new ArgumentException(ret);
            }
        }

    }

    internal class Program
    {
        static List<int> NumbersFromConsole()
        {
            Console.WriteLine("Enter your numbers:");
            string numbersInString = Console.ReadLine();

            string[] numbersInArray = numbersInString.Split(' ');

            List<int> numbers = new List<int>();



            for (int i = 0; i < numbersInArray.Length; i++)
            {

                try
                {
                    numbers.Add(int.Parse(numbersInArray[i]));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong number");

                }
            }


            return numbers;
        }

        static int BinaryToNurmal()
        {
            Console.WriteLine("Enter your 1 and 0 number:");
            string BiN = Console.ReadLine();
            List<int> Bi = new List<int>();

            for (int i = 0; i < BiN.Length; i++)
            {
                int? tmp = null;
                try
                {
                    tmp = int.Parse(BiN[i].ToString());
                }
                catch (FormatException)
                {
                    Console.WriteLine(BiN[i].ToString());
                    Console.WriteLine("Wrong argument for number");
                }
                if (tmp != null && tmp <= 1)
                {
                    Bi.Add((int)tmp);
                }
            }
            int finalNumber = 0;
            for (int i = 0; i < Bi.Count; i++)
            {
                if (Bi[i] == 1)
                {
                    finalNumber += (int)Math.Pow(2, i);
                }
            }
            if (finalNumber < 0)
            {
                throw new ArgumentOutOfRangeException("Olecshii loh");
            }
            return finalNumber;
        }

        static void SortN(List<int> array, bool toBigger)
        {
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array.Count; j++)
                {
                    if (toBigger)
                    {
                        if (array[i] > array[j])
                        {
                            int tmp = array[i];
                            array[i] = array[j];
                            array[j] = tmp;
                        }
                    }
                    else
                    {
                        if (array[i] < array[j])
                        {
                            int tmp = array[i];
                            array[i] = array[j];
                            array[j] = tmp;
                        }
                    }

                }

            }

        }

        static void Main(string[] args)
        {
            #region First
            //List<int> numbers = NumbersFromConsole();

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.ReadLine();
            #endregion

            #region Second
            //try
            //{
            //    Console.WriteLine(BinaryToNurmal());
            //}
            //catch (ArgumentOutOfRangeException exp)
            //{
            //    Console.WriteLine(exp.Message);
            //}


            //Console.ReadLine();
            #endregion

            #region Third
            //bool choiceToBigger = true;
            //bool wonderCindSafe = true;
            //while (wonderCindSafe)
            //{
            //    Console.WriteLine("Enter numbers. How\'d you like to sort?\nTo smaller < (false)\nTo bigger > (true)\nEnter:");
            //    try
            //    {
            //        choiceToBigger = bool.Parse(Console.ReadLine());

            //        wonderCindSafe = false;
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Wrong value");
            //    }
            //}



            //List<int> Array = NumbersFromConsole();
            //SortN(Array, choiceToBigger);

            //for (int i = 0; i < Array.Count; i++)
            //{
            //    Console.WriteLine(Array[i]);
            //}
            //Console.ReadLine();
            #endregion

            #region fourth


            //City city = new City("Ukraine", "Lviv", 1000, 322, new List<string> {"Shevchenkivskii", "Sukhiv", "Zaliznychnii" });
            //Console.WriteLine(city.ToString());
            //City city2 = new City();
            //string data = Console.ReadLine();
            //city2.read(data);
            //Console.WriteLine(city2);

            #endregion

            #region fifth
            //Rab rab2 = new Rab("pib", new DateTime(2008, 3, 5), "r4756284", "mail", posada.director, "nothing");
            //Console.WriteLine(rab2);
            //Rab rab = new Rab();
            //rab.read(Console.ReadLine());
            //Console.WriteLine(rab);
            #endregion

            #region sixth
            Card card1 = new Card("1234567887654321", "Owner", "232", new DateTime(2027, 12, 1), 0, false);
            Console.WriteLine(card1);
            Card card2 = new Card();
            bool isEnteredWrongly = true;
            do
            {
                try
                {
                    card2.read(Console.ReadLine());
                    isEnteredWrongly = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            } while (isEnteredWrongly);
            Console.WriteLine(card2);

            #endregion

            Console.ReadLine();
        }
    }
}