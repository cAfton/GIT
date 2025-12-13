namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> surnames = new List<string> { "Smith", "Johnson", "Brown", "Taylor", "Anderson", "Thomas", "Jackson", "White", "Harris", "Martin" };
            Console.WriteLine(surnames.All(elem => elem.Length > 3));
            Console.WriteLine(surnames.All(elem => elem.Length > 3 && elem.Length < 10));
            Console.WriteLine(surnames.Any(elem => elem.StartsWith("W")));
            Console.WriteLine(surnames.Any(elem => elem.EndsWith("y")));
            Console.WriteLine(surnames.Contains("Orange"));
            Console.WriteLine(surnames.FirstOrDefault(elem => elem.Length == 6));
            Console.WriteLine(surnames.LastOrDefault(elem => elem.Length < 15));
        }
    }
}
