namespace delegat
{
    internal class Program
    {
        public delegate int calculator(int x, int y);
        public static int Add(int x, int y) { return x + y; }

        public static int Sub(int x, int y) { return x - y; }

        public static int Mul(int x, int y) { return x * y; }


        static void Main(string[] args)
        {
            calculator Calc = null;
            while (true)
            {
                string line = Console.ReadLine();

                //char[] chars = { '+', '-', '*' };
                //char ch = '\0';


                //foreach (var item in line)
                //{
                //    if (chars.Contains(item))
                //    {
                //        ch = item;
                //    }
                //}

                string[] strings = line.Split(' ');


                Calc = Add;
                Calc += Sub;
                Calc += Mul;

                foreach (calculator item in Calc.GetInvocationList())
                {
                    Console.WriteLine(item(int.Parse(strings[0]), int.Parse(strings[1])));
                }

            }
        }
    }
}
