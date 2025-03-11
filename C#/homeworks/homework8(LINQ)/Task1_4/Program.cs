namespace Task1_4
{
    public enum TypeOfFirma
    {
        Marketing,
        IT,
        Eating
    }
    public class Firma
    {
        public string Name { get; set; }
        public DateTime DateOfCreating { get; set; }
        public string Director {  get; set; }
        public int NumberOfWorkers { get; set; }
        public string Address { get; set; }
        public TypeOfFirma Type { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Date of Creating: {DateOfCreating}\n" +
                $"Director: {Director}\n" +
                $"Number of workers: {NumberOfWorkers}\n" +
                $"Address: {Address}\n" +
                $"Type: {Type}\n\n";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Firma> list = new List<Firma>() { 
                new Firma() {Name = "Food Corporation", DateOfCreating = new DateTime(2008, 10, 29), Director = "Someone", NumberOfWorkers = 123, Address = "Kyev", Type = TypeOfFirma.Eating }, 
                new Firma() {Name = "SoftServe", DateOfCreating = new DateTime(2025, 01, 29), Director = "White Black", NumberOfWorkers = 500, Address = "Kyev", Type = TypeOfFirma.IT }, 
                new Firma() {Name = "Something", DateOfCreating = new DateTime(2024, 11, 8), Director = "White Sb", NumberOfWorkers = 99, Address = "London", Type = TypeOfFirma.IT }, 
                new Firma() {Name = "Food IMC", DateOfCreating = new DateTime(2018, 4, 11), Director = "I DK", NumberOfWorkers = 2345, Address = "London", Type = TypeOfFirma.Eating }, 
                new Firma() {Name = "Food IDK", DateOfCreating = new DateTime(2019, 10, 29), Director = "Someone", NumberOfWorkers = 123, Address = "Kyev", Type = TypeOfFirma.Marketing },
                new Firma() {Name = "Zeta Consulting", DateOfCreating = new DateTime(2024, 5, 10), Director = "White Brown", NumberOfWorkers = 95, Address = "Dallas" , Type = TypeOfFirma.IT},
                new Firma() {Name = "White Logistics", DateOfCreating = new DateTime(2023, 2, 18), Director = "Emma Black", NumberOfWorkers = 600, Address = "Seattle" , Type = TypeOfFirma.Marketing},
                new Firma() {Name = "Theta Finance", DateOfCreating = new DateTime(2018, 8, 22), Director = "White Miller", NumberOfWorkers = 250, Address = "London" , Type = TypeOfFirma.Marketing},
                new Firma() { Name = "GammaFoods", DateOfCreating = new DateTime(2012, 11, 5), Director = "Alice Johnson", NumberOfWorkers = 75, Address = "Chicago" , Type = TypeOfFirma.Eating},
                new Firma() { Name = "Food Marketing", DateOfCreating = new DateTime(2020, 7, 19), Director = "Bob White", NumberOfWorkers = 320, Address = "Miami" , Type = TypeOfFirma.Eating},
                new Firma() { Name = "Epsilon IT", DateOfCreating = new DateTime(2007, 9, 30), Director = "Charlie Black", NumberOfWorkers = 1200, Address = "Los Angeles" , Type = TypeOfFirma.IT}
            };
            int userChoise = -2;
            while (userChoise != -1)
            {
                Console.Write("1. Get information about all companies\n" +
                          "2. Get companies with 'Food' in the name\n" +
                          "3. Get companies operating in marketing\n" +
                          "4. Get companies operating in marketing or IT\n" +
                          "5. Get companies with more than 100 employees\n" +
                          "6. Get companies with employees between 100 and 300\n" +
                          "7. Get companies located in London\n" +
                          "8. Get companies where the director's last name is White\n" +
                          "9. Get companies founded more than two years ago\n" +
                          "10. Get companies founded exactly 123 days ago\n" +
                          "11. Get companies where the director's last name is Black and the company name contains 'White'\n" +
                          "0. Exit\n" +
                          ">>> ");
                userChoise = int.Parse(Console.ReadLine());

                    switch (userChoise)
                    {
                        case 1:
                            list.ForEach(elem => Console.WriteLine(elem));
                            break;
                        case 2:
                            list.ForEach(elem => {
                                if (elem.Name.Contains("Food"))
                                {
                                    Console.WriteLine(elem);
                                }
                            });
                            break;
                        case 3:
                            list.ForEach(elem => {
                                if (elem.Type == TypeOfFirma.Marketing)
                                {
                                    Console.WriteLine(elem);
                                }
                            });
                            break;
                        case 4:
                            list.ForEach(elem => {
                                if (elem.Type == TypeOfFirma.Marketing || elem.Type == TypeOfFirma.IT)
                                {
                                    Console.WriteLine(elem);
                                }
                            });
                            break;
                        case 5:
                            list.ForEach(elem => {
                                if (elem.NumberOfWorkers > 100)
                                {
                                    Console.WriteLine(elem);
                                }
                            });
                            break;
                        case 6:
                            list.ForEach(elem => {
                                if (elem.NumberOfWorkers > 100 && elem.NumberOfWorkers < 300)
                                {
                                    Console.WriteLine(elem);
                                }
                            });
                            break;
                        case 7:
                            list.ForEach(elem => {
                                if (elem.Address.Contains("London"))
                                {
                                    Console.WriteLine(elem);
                                }
                            });
                            break;
                        case 8:
                            list.ForEach(elem => {
                                if (elem.Director.Contains("White"))
                                {
                                    Console.WriteLine(elem);
                                }
                            });
                            break;
                        case 9:
                            list.ForEach(elem => {
                                if (DateTime.Now.Year - elem.DateOfCreating.Year > 2)
                                {
                                    Console.WriteLine(elem);
                                }
                            });
                            break;
                        case 10:
                            list.ForEach(elem => {
                                if (DateTime.Now.AddDays(-123).Date == elem.DateOfCreating)
                                {
                                    Console.WriteLine(elem);
                                }
                            });
                            break;
                        case 11:
                            list.ForEach(elem => {
                                if (elem.Name.Contains("White") && elem.Director.Contains("Black"))
                                {
                                    Console.WriteLine(elem);
                                }
                            });
                            break;
                        case 0:
                            Console.WriteLine("You cant escape:)");
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
