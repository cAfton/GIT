namespace Task3
{
    public class Caffee
    {
        public Queue<string> queue { get; set; } = new Queue<string>();

        public void newPlace()
        {
            Console.WriteLine("new free place");
            queue.Dequeue();
        }

        public event Action newFreePlace;

        public void AddNewVisitor(bool isReserved)
        {
            if (isReserved)
            {
                queue.Enqueue("reserved");
                Console.WriteLine("New reserved visitor arrived");
                newFreePlace();
            }
            else
            {
                queue.Enqueue("visitor");
                Console.WriteLine("New visitor arrived");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Caffee caffee = new Caffee();
            caffee.newFreePlace += caffee.newPlace;

            while (true)
            {
                Thread.Sleep(100 * (rnd.Next() % 10));
                int tmp = rnd.Next();
                if (tmp % 5 == 0 || tmp % 5 == 1)
                {
                    caffee.AddNewVisitor(false);
                }
                else if (tmp % 5 == 3)
                {
                    caffee.AddNewVisitor(true); ;
                }

                Thread.Sleep(100 * (rnd.Next() % 3));
                if (rnd.Next() % 3 != 1 && caffee.queue.Count != 0)
                {
                    caffee.newPlace();
                }
            }

        }
    }
}
