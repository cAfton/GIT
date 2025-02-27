namespace boler
{
    public class Boler
    {
        public int max { get; set; }
        public int min { get; set; }
        public int value { get; set; }
        public event Action<bool> LevelChenged;

        public Boler()
        {
            max = 10;
            min = 3;
            value = 10;
            LevelChenged += DoClapan;
        }
        public async void GetWater(int n)
        {
            for (int i = 0; i < n; i++)
            {
                await Task.Delay(1000);
                value--;
                Console.WriteLine(value.ToString());
                if (value <= min)
                {
                    LevelChenged(true);
                }
            }
        }

        public async void DoClapan(bool a)
        {
            while (a)
            {
                await Task.Delay(500);
                value++;
                Console.WriteLine(value.ToString());
                if (value > max)
                {
                    LevelChenged(false);
                    break;
                }
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Boler boler = new Boler();

            boler.GetWater(8);

            Console.ReadLine();
        }
    }
}