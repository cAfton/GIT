using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Menu
{
    public class Logger : IDisposable
    {
        private StreamWriter writer;

        private static Logger logger;

        private Logger()
        {
            writer = new StreamWriter("Log.log", append: true);
        }

        public void Log(string message)
        {
            writer.WriteLine($"[{DateTime.Now}]   {message}");
            writer.Flush();
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

        public void Dispose()
        {
            writer?.Dispose();
        }
    }
}
