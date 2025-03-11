namespace para1
{
    public class Performance : IDisposable
    {
        public string Name { get; set; }
        public string Theater {  get; set; }

        public string Janre {  get; set; }

        public List<string> Actors { get; set; }
        public Performance() {
            Name = "name";
            Theater = "theater";
            Janre = "janre";
            Actors = new List<string>();
        }
        public Performance(string name, string theater, string janre) {
            Name = name;
            Theater = theater;
            Janre = janre;
            Actors = new List<string>();
        }

        public void Dispose()
        {
            Actors.Clear();
            Console.WriteLine("Dispose done");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Performance perf = new Performance();
            Console.WriteLine(perf.Name);
            perf.Dispose();
            if (true)
            {
                Performance perf2 = new Performance();
                Console.WriteLine(perf.Theater);
                perf2.Dispose();
                using (Performance spect = new Performance())
                {
                    spect.Actors.Add("actor1");
                    Console.WriteLine(spect.Actors[0]);
                }   
                char.is
            }
        }
    }
}
