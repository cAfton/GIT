namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1, 1, 1);
            DateTime dateTime1 = new DateTime(1, 1, 1);

            Console.WriteLine(dateTime == dateTime1);

            return;
            Task_Manager.Menu();
        }
    }
}
