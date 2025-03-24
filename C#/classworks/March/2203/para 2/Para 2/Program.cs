namespace Para_2
{
    
    
    public class Logger : IDisposable
    {
        private StreamWriter writer;

        private static Logger logger;

        private Logger() 
        { 
            writer = new StreamWriter("Log.log"); 
        }

        public void Log(string message)
        {
            writer.WriteLine($"{DateTime.Now}:{message}");
        }

        static public Logger getLogger
        {
            get
            {
                if (logger == null)
                {
                    logger = new Logger();
                }
                return logger;
            }
        }

        static public Logger Instance()
        {
            if (logger == null)
            {
                logger = new Logger();
            }
            return logger;
        }

        public void Dispose()
        {
            writer?.Dispose();
        }
    }

    public class MakeGold
    {
        public void DoCidsWork()
        {
            string tmp = "We are not mining. We are playing minecraft";
            Console.WriteLine(tmp);
            Logger.Instance().Log(tmp);
            Logger.Instance().Log("Olecsiy lox");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MakeGold makeGold = new MakeGold();
                makeGold.DoCidsWork();
                int? a = 5;
                if (a/0 == 5)
                    a = 1;
            }
            catch (Exception ElProblemo)
            {
                Logger.getLogger.Log(ElProblemo.Message);
                Console.WriteLine(ElProblemo.Message);
                
            }
            

            

            Logger.Instance().Dispose();
        }
    }
}
